namespace Prototype
{
    public class ModelConfig : IPrototype<ModelConfig>
    {
        public string ModelType { get; set; }
        public double LearningRate { get; set; }
        public int Epochs { get; set; }

        public ModelConfig(string modelType, double learningRate, int epochs)
        {
            ModelType = modelType;
            LearningRate = learningRate;
            Epochs = epochs;
        }

        public ModelConfig Clone()
        {
            return new ModelConfig(ModelType, LearningRate, Epochs);
        }

        public void DisplayConfig()
        {
            Console.WriteLine($"Model Type: {ModelType}, Learning Rate: {LearningRate}, Epochs: {Epochs}");
        }
    }

}
