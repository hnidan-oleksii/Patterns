using AbstractFactory.Entities.Interfaces;
using AbstractFactory.Entities.Models;
using AbstractFactory.Entities.Scalers;

namespace AbstractFactory.Factories
{
    public class AbsLinearRegressionFactory : IAbsModelFactory
    {
        public IModelProcessor CreateModelProcessor()
        {
            return new LinearRegressionProcessor();
        }

        public IDataScaler CreateScaler()
        {
            return new StandardScaler();
        }
    }
}
