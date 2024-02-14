using AbstractFactory.Entities.Interfaces;

namespace AbstractFactory.Entities.Scalers
{
    public class StandardScaler : IDataScaler
    {
        public void ScaleData()
        {
            Console.WriteLine("Scaling data using Standard Scaler...");
        }
    }
}
