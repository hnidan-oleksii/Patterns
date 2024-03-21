namespace StructuralMain.Adapter
{
    public class ExternalThermostat
    {
        public void SetTemperature(int temperature) => Console.WriteLine($"Thermostat set to {temperature} degrees");
    }
}
