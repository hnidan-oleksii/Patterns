using Behavioral.Observer;

namespace Behavioral.Visitor
{
    internal interface IVisitor
    {
        void Visit(Sensor sensor);
    }
}
