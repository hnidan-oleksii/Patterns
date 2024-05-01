using Behavioral.Observer;

namespace Behavioral.Memento
{
    internal class SensorMemento
    {
        public Sensor Sensor { get; private set; }
        public double[] Data { get; private set; }

        public SensorMemento(Sensor sensor)
        {
            Sensor = sensor;
            Data = sensor.Data;
        }
    }
}
