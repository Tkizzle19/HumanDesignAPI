namespace HumanDesign
{
    public static class Chart
    {
        public static object Generate(DateTime dateTime, double latitude, double longitude)
        {
            return new
            {
                Type = "Generator",
                Profile = "3/5",
                Authority = "Emotional",
                Definition = "Split",
                Gates = new[] { "34", "10", "57" },
                Centers = new[] { "Sacral", "G" },
                Channels = new[] { "34-57" },
                Timestamp = dateTime,
                Coordinates = new { latitude, longitude }
            };
        }
    }
}
