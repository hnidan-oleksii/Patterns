namespace StructuralMain.Flyweight.Modes
{
    public class HomeMode : IDeviceMode
    {
        public void ApplyMode(ISmartDevice device) => Console.WriteLine($"Applying 'Home' mode to {device.GetName()}");
    }
}
