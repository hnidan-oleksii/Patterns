using Behavioral.Observer;

namespace Behavioral.Command
{
    internal class DataProcessingCommand : ICommand
    {
        private Sensor sensor;

        public DataProcessingCommand(Sensor sensor)
        {
            this.sensor = sensor;
        }

        public void Execute()
        {
            Console.WriteLine("Data processed: " + string.Join(" ", sensor.Data));
        }
    }
}
