using Behavioral.Command;
using Behavioral.CoR;
using Behavioral.Iterator;
using Behavioral.Mediator;
using Behavioral.Memento;
using Behavioral.Observer;
using Behavioral.State;
using Behavioral.Strategy;
using Behavioral.TemplateMethod;
using Behavioral.Visitor;

namespace Behavioral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create sensor
            Sensor sensor = new Sensor();
            sensor.Data = new double[] { 10.5, 20.3, 100.7 };


            // Register observers
            IObserver observer = new SensorVisitor();
            sensor.RegisterObserver(observer);

            // Command pattern
            ICommand command = new DataProcessingCommand(sensor);
            command.Execute();

            // State pattern
            IState state = new NormalState(sensor);
            state.Handle();

            // Strategy pattern
            sensor.Strategy = new ThresholdStrategy();
            sensor.ApplyStrategy();

            // Chain of Responsibility pattern
            Handler lengthHandler = new DataLengthHandler();
            Handler negativeHandler = new NegativeDataHandler();
            Handler highHandler = new HighDataHandler();
            lengthHandler.SetSuccessor(negativeHandler);
            negativeHandler.SetSuccessor(highHandler);
            lengthHandler.HandleRequest(sensor.Data);

            // Template method pattern
            DataProcessor dataProcessor = new SensorDataProcessor();
            dataProcessor.ProcessData(sensor.Data);

            // Iterator pattern
            IIterator<double> iterator = new SensorDataIterator(sensor);
            while (iterator.HasNext())
            {
                Console.WriteLine("Sensor data: " + iterator.Next());
            }

            // Visitor pattern
            sensor.Accept(new SensorVisitor());

            // Memento pattern
            SensorCareTaker careTaker = new SensorCareTaker();
            careTaker.Memento = new SensorMemento(sensor);

            // Mediator pattern
            IMediator mediator = new SensorMediator();
            mediator.Send("Data alert", sensor);
        }
    }
}
