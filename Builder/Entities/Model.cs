namespace Builder.Entities
{
    public class Model
    {
        public string ModelType { get; set; }
        public void TrainModel() => Console.WriteLine($"Training {ModelType} model...");
    }
}
