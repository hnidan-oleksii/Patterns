using StructuralMain.Bridge;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Proxy
{
    public class SecureDeviceProxy : ISmartDevice
    {
        private ISmartDevice _realDevice;
        private string _password;

        public SecureDeviceProxy(ISmartDevice realDevice, string password)
        {
            _realDevice = realDevice;
            _password = password;
        }

        public void TurnOn()
        {
            if (Authenticate()) _realDevice.TurnOn();
            else Console.WriteLine("Unauthorized attempt to turn on device");
        }

        public void TurnOff()
        {
            if (Authenticate()) _realDevice.TurnOff();
            else Console.WriteLine("Unauthorized attempt to turn off device");
        }

        public void ChangeMode(IDeviceMode mode)
        {
            if (Authenticate()) _realDevice.ChangeMode(mode);
            else Console.WriteLine("Unauthorized attempt to change mode device");
        }
        public void SetConnection(IDeviceConnection connection)
        {
            if (Authenticate()) _realDevice.SetConnection(connection);
            else Console.WriteLine("Unauthorized attempt to connect to device");
        }

        private bool Authenticate()
        {
            Console.WriteLine("Enter password:");
            var input = true ? _password : Console.ReadLine();
            return input == _password;
        }

        public string GetName() => _realDevice.GetName();
    }
}
