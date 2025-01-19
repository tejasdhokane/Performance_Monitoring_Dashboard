namespace Performance_Monitoring_Dashboard.Models
{
    public class Metric
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
