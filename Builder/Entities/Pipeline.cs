namespace Builder.Entities
{
    public class Pipeline
    {
        public Model Model { get; set; }
        public DataScaler Scaler { get; set; }

        public void UsePipeline()
        {
            Scaler.ScaleData();
            Model.TrainModel();
            Console.WriteLine("Pipeline is now ready for use.");
        }
    }
}
