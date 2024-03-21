using StructuralMain.Bridge;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Composite
{
    public class SmartDeviceGroup : ISmartDevice
    {
        private List<ISmartDevice> _devices = new List<ISmartDevice>();
        private string _name;

        public SmartDeviceGroup(string name) { _name = name; }

        public void AddDevice(ISmartDevice device) => _devices.Add(device);
        public void TurnOn() => _devices.ForEach(device => device.TurnOn());
        public void TurnOff() => _devices.ForEach(device => device.TurnOff());
        public void ChangeMode(IDeviceMode mode) => _devices.ForEach(device => device.ChangeMode(mode));
        public void SetConnection(IDeviceConnection connection) => _devices.ForEach(device => device.SetConnection(connection));
        public string GetName() => _name;
    }
}
