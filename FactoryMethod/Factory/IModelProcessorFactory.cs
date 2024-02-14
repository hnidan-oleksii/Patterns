using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Factory
{
    public interface IModelProcessorFactory
    {
        IModelProcessor CreateModelProcessor();
        IDataScaler CreateScaler();
    }
}
