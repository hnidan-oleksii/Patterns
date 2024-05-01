namespace Behavioral.Memento
{
    internal class SensorCareTaker
    {
        private Stack<SensorMemento> mementosHistory = new();
        public SensorMemento Memento 
        { 
            get => mementosHistory.Pop(); 
            set => mementosHistory.Push(value); 
        }
    }
}
