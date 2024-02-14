using Builder.Entities;

namespace Builder.Builder
{
    public interface IPipelineBuilder
    {
        IPipelineBuilder SetModel(string modelType);
        IPipelineBuilder SetScaler(string scalerType);
        Pipeline Build();
    }
}
