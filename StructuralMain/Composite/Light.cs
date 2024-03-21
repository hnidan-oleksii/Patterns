using StructuralMain.Bridge;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Composite
{
    public class Light : ISmartDevice
    {
        private string _name;
        private IDeviceConnection _connection;

        public Light(string name) { _name = name; }


        public void TurnOn() => _connection?.SendCommand($"{_name} Light turned on");
        public void TurnOff() => _connection?.SendCommand($"{_name} Light turned off");
        public void ChangeMode(IDeviceMode mode) => mode.ApplyMode(this);
        public void SetConnection(IDeviceConnection connection) => _connection = connection;
        public string GetName() => _name;
    }
}
