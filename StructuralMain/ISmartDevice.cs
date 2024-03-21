using StructuralMain.Bridge;
using StructuralMain.Flyweight.Modes;

namespace StructuralMain
{
    public interface ISmartDevice
    {
        void TurnOn();
        void TurnOff();
        string GetName();
        void ChangeMode(IDeviceMode mode);
        void SetConnection(IDeviceConnection connection);
    }
}
