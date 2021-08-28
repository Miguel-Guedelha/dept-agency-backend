namespace API.models
{
    public class Parameters
    {

        public Parameters(dynamic parameters)
        {
            Id = parameters.id;
            Unit = parameters.unit;
            LastValue = parameters.lastValue;
            DisplayName = parameters.displayName;
        }

        public int Id { get; set; }
        public string Unit { get; set; }
        public int LastValue { get; set; }
        public string DisplayName { get; set; }
    }
}