using Behavioral.Observer;

namespace Behavioral.State
{
    internal class NormalState : IState
    {
        private Sensor sensor;

        public NormalState(Sensor sensor)
        {
            this.sensor = sensor;
        }

        public void Handle()
        {
            Console.WriteLine("Sensor is in normal state.");
        }
    }
}
