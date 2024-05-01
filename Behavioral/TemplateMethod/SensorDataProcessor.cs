namespace Behavioral.TemplateMethod
{
    internal class SensorDataProcessor : DataProcessor
    {
        protected override void ValidateData(double[] data)
        {
            Console.WriteLine("Validating sensor data...");
        }

        protected override void TransformData(double[] data)
        {
            Console.WriteLine("Transforming sensor data...");
        }
    }
}
