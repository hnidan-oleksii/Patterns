using System.Runtime.InteropServices.JavaScript;

namespace Behavioral.Observer
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
