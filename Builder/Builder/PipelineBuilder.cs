using Builder.Entities;

namespace Builder.Builder
{
    public class PipelineBuilder : IPipelineBuilder
    {
        private Pipeline _pipeline = new Pipeline();

        public IPipelineBuilder SetModel(string modelType)
        {
            _pipeline.Model = new Model { ModelType = modelType };
            return this;
        }

        public IPipelineBuilder SetScaler(string scalerType)
        {
            _pipeline.Scaler = new DataScaler { ScalerType = scalerType };
            return this;
        }

        public Pipeline Build()
        {
            Pipeline result = _pipeline;
            _pipeline = new Pipeline();
            return result;
        }
    }
}
