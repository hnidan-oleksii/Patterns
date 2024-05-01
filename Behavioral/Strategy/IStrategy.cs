using Behavioral.Observer;

namespace Behavioral.Strategy
{
    internal interface IStrategy
    {
        void Apply(Sensor sensor);
    }
}
