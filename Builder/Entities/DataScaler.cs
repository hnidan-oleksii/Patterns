namespace Builder.Entities
{
    public class DataScaler
    {
        public string ScalerType { get; set; }
        public void ScaleData() => Console.WriteLine($"Scaling data using {ScalerType}...");
    }
}
