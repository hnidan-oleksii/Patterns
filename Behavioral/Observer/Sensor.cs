using Behavioral.State;
using Behavioral.Strategy;
using Behavioral.Visitor;

namespace Behavioral.Observer
{
    internal class Sensor : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private double[] data;
        private IState currentState;
        private IStrategy strategy;

        public double[] Data
        {
            get { return data; }
            set
            {
                data = value;
                NotifyObservers();
            }
        }

        public IStrategy Strategy { set => strategy = value; }

        public Sensor()
        {
            currentState = new NormalState(this);
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void ChangeState(IState newState)
        {
            currentState = newState;
        }

        public void HandleState()
        {
            currentState.Handle();
        }

        public void ApplyStrategy()
        {
            this.strategy.Apply(this);
        }
    }
}