using StructuralMain.Bridge;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Decorator
{
    public class SmartDeviceLogger : ISmartDevice
    {
        private ISmartDevice _decoratedDevice;

        public SmartDeviceLogger(ISmartDevice decoratedDevice)
        {
            _decoratedDevice = decoratedDevice;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Logging: Turning on {_decoratedDevice.GetName()}");
            _decoratedDevice.TurnOn();
        }

        public void TurnOff()
        {
            Console.WriteLine($"Logging: Turning off {_decoratedDevice.GetName()}");
            _decoratedDevice.TurnOff();
        }

        public void ChangeMode(IDeviceMode mode)
        {
            Console.WriteLine($"Logging: Changing mode of {_decoratedDevice.GetName()} to {mode.GetType().Name}");
            _decoratedDevice.ChangeMode(mode);
        }

        public void SetConnection(IDeviceConnection connection)
        {
            Console.WriteLine($"Logging: Connecting {_decoratedDevice.GetName()} via {connection.GetType().Name}");
            _decoratedDevice.SetConnection(connection);
        }

        public string GetName() => _decoratedDevice.GetName();
    }

}
