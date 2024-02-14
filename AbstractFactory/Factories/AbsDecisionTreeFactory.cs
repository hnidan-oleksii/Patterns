using AbstractFactory.Entities.Interfaces;
using AbstractFactory.Entities.Models;
using AbstractFactory.Entities.Scalers;

namespace AbstractFactory.Factories
{
    public class AbsDecisionTreeFactory : IAbsModelFactory
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
