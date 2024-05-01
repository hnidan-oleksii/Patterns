using Behavioral.Observer;

namespace Behavioral.Visitor
{
    internal class SensorVisitor : IVisitor, IObserver
    {
        public void Visit(Sensor sensor)
        {
            Console.WriteLine("Visiting sensor...");
            Console.WriteLine("Sensor data: " + string.Join(" ", sensor.Data));
        }

        public void Update(ISubject subject)
        {
            if (subject is Sensor sensor)
            {
                Console.WriteLine("Visiting sensor...");
                Console.WriteLine("Sensor data: " + string.Join(" ", sensor.Data));
            }
        }
    }
}
