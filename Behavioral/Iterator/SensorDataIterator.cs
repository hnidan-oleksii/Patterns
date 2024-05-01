using Behavioral.Observer;

namespace Behavioral.Iterator
{
    internal class SensorDataIterator : IIterator<double>
    {
        private Sensor sensor;
        private int position = 0;

        public SensorDataIterator(Sensor sensor)
        {
            this.sensor= sensor;
        }

        public bool HasNext()
        {
            return position < sensor.Data.Length;
        }

        public double Next()
        {
            if (HasNext())
            {
                return sensor.Data[position++];
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
