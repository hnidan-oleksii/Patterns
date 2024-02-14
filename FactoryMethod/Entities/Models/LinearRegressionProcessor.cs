using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities.Models
{
    public class LinearRegressionProcessor : IModelProcessor
    {
        public void TrainModel()
        {
            Console.WriteLine("Training Linear Regression Model...");
        }

        public void UseModel()
        {
            Console.WriteLine("Using Linear Regression Model...");
        }
    }
}
