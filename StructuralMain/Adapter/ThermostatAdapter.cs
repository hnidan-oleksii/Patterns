using StructuralMain.Bridge;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Adapter
{
    public class ThermostatAdapter : ISmartDevice
    {
        private ExternalThermostat _thermostat;
        private IDeviceConnection _connection;

        public ThermostatAdapter(ExternalThermostat thermostat) => _thermostat = thermostat;
        public void TurnOn() => _thermostat.SetTemperature(22);
        public void TurnOff() => _thermostat.SetTemperature(18);
        public void ChangeMode(IDeviceMode mode) { }
        public void SetConnection(IDeviceConnection connection) => _connection = connection;
        public string GetName() => "Thermostat";
    }
}
