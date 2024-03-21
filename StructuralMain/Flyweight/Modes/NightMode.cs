namespace StructuralMain.Flyweight.Modes
{
    public class NightMode : IDeviceMode
    {
        public void ApplyMode(ISmartDevice device) => Console.WriteLine($"Applying 'Night' mode to {device.GetName()}");
    }
}
