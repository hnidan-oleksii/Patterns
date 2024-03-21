namespace StructuralMain.Bridge
{
    public interface IDeviceConnection
    {
        void Connect();
        void Disconnect();
        void SendCommand(string command);
    }
}
