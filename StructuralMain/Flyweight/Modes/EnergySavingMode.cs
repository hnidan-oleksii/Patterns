namespace StructuralMain.Flyweight.Modes
{
    public class EnergySavingMode : IDeviceMode
    {
        public void ApplyMode(ISmartDevice device) => Console.WriteLine($"Applying 'Energy Saving' mode to {device.GetName()}");
    }
}
