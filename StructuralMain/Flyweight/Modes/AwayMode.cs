namespace StructuralMain.Flyweight.Modes
{
    public class AwayMode : IDeviceMode
    {
        public void ApplyMode(ISmartDevice device) => Console.WriteLine($"Applying 'Away' mode to {device.GetName()}");
    }
}
