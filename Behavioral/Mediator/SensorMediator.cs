using Behavioral.Observer;

namespace Behavioral.Mediator
{
    internal class SensorMediator : IMediator
    {
        public void Send(string message, Sensor sensor)
        {
            Console.WriteLine("Message '" + message + "' sent from sensor.");
        }
    }
}
