using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities.Scalers
{
    public class StandardScaler : IDataScaler
    {
        public void ScaleData()
        {
            Console.WriteLine("Scaling data using Standard Scaler...");
        }
    }
}
