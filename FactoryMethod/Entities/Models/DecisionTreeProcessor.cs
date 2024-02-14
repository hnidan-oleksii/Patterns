using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities.Models
{
    public class DecisionTreeProcessor : IModelProcessor
    {
        public void TrainModel()
        {
            Console.WriteLine("Training Decision Tree Model...");
        }

        public void UseModel()
        {
            Console.WriteLine("Using Decision Tree Model...");
        }
    }
}
