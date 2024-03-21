namespace StructuralMain.Bridge
{
    public class WiFiConnection : IDeviceConnection
    {
        public void Connect() => Console.WriteLine("Connected via WiFi");
        public void Disconnect() => Console.WriteLine("Disconnected from WiFi");
        public void SendCommand(string command) => Console.WriteLine($"Sent over WiFi: {command}");
    }
}
