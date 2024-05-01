using Behavioral.Observer;
using Behavioral.State;

namespace Behavioral.Strategy
{
    internal class ThresholdStrategy : IStrategy
    {
        public void Apply(Sensor sensor)
        {
            if (sensor.Data.Length > 100)
            {
                Console.WriteLine("Threshold exceeded!");
                sensor.ChangeState(new AlertState(sensor));
            }
            else
            {
                sensor.ChangeState(new NormalState(sensor));
            }
        }
    }
}
