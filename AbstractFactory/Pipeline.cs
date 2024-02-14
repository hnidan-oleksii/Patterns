using AbstractFactory.Entities.Interfaces;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Pipeline
    {
        private IModelProcessor _modelProcessor;
        private IDataScaler _dataScaler;

        public Pipeline(IAbsModelFactory modelFactory)
        {
            _modelProcessor = modelFactory.CreateModelProcessor();
            _dataScaler = modelFactory.CreateScaler();
        }

        public void RunPipeline()
        {
            _dataScaler.ScaleData();
            _modelProcessor.TrainModel();
            _modelProcessor.UseModel();
        }
    }
}
