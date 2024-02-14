using FactoryMethod.Entities.Interfaces;
using FactoryMethod.Entities.Models;
using FactoryMethod.Entities.Scalers;

namespace FactoryMethod.Factory
{
    public class DecisionTreeFactory : IModelProcessorFactory
    {
        public IModelProcessor CreateModelProcessor()
        {
            return new DecisionTreeProcessor();
        }

        public IDataScaler CreateScaler()
        {
            return new MinMaxScaler();
        }
    }
}
