using FactoryMethod.Entities.Interfaces;
using FactoryMethod.Entities.Models;
using FactoryMethod.Entities.Scalers;

namespace FactoryMethod.Factory
{
    public class LinearRegressionFactory : IModelProcessorFactory
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
