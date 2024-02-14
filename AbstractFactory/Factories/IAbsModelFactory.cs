using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Factories
{
    public interface IAbsModelFactory
    {
        IModelProcessor CreateModelProcessor();
        IDataScaler CreateScaler();
    }

}
