using FactoryMethod.Entities.Interfaces;

namespace FactoryMethod.Entities.Scalers
{
    public class MinMaxScaler : IDataScaler
    {
        public void ScaleData()
        {
            Console.WriteLine("Scaling data using Min-Max Scaler...");
        }
    }
}
