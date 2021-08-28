using Microsoft.AspNetCore.Mvc;
using API.models;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;
using System.Net;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AirQualityController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromQuery] string city)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://u50g7n0cbj.execute-api.us-east-1.amazonaws.com/v2/");

                var responseTask = client.GetStringAsync($"locations?limit=100&page=1&offset=0&sort=desc&radius=1&city={city}&order_by=lastUpdated&dumpRaw=false");

                responseTask.Wait();

                dynamic jsonData = JObject.Parse(responseTask.Result);

                AQCityResults results = new AQCityResults(jsonData.results);
                return Ok(results);
            }

        }
    }
}