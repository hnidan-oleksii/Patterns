using StructuralMain.Composite;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Facade
{
    public class SmartHomeFacade
    {
        private SmartDeviceGroup _deviceGroup = new SmartDeviceGroup("Home");

        public void AddDevice(ISmartDevice device) => _deviceGroup.AddDevice(device);

        public void TurnOnHome() => _deviceGroup.TurnOn();

        public void TurnOffHome() => _deviceGroup.TurnOff();

        public void ApplyModeToAllDevices(IDeviceMode mode)
        {
            _deviceGroup.ChangeMode(mode);
        }
    }
}
