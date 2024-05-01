namespace Behavioral.TemplateMethod
{
    internal abstract class DataProcessor
    {
        public void ProcessData(double[] data)
        {
            ValidateData(data);
            TransformData(data);
        }

        protected abstract void ValidateData(double[] data);
        protected abstract void TransformData(double[] data);
    }
}
