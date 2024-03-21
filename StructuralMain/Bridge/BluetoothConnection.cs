namespace StructuralMain.Bridge
{
    public class BluetoothConnection : IDeviceConnection
    {
        public void Connect() => Console.WriteLine("Connected via Bluetooth");
        public void Disconnect() => Console.WriteLine("Disconnected from Bluetooth");
        public void SendCommand(string command) => Console.WriteLine($"Sent over Bluetooth: {command}");
    }
}
