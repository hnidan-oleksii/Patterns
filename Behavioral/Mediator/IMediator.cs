using Behavioral.Observer;

namespace Behavioral.Mediator
{
    internal interface IMediator
    {
        void Send(string message, Sensor sensor);
    }
}
