using StructuralMain.Flyweight.Modes;

namespace StructuralMain.Flyweight
{
    public class DeviceModeFactory
    {
        private Dictionary<string, IDeviceMode> _modes = new Dictionary<string, IDeviceMode>();

        public IDeviceMode GetMode(string modeName)
        {
            if (!_modes.ContainsKey(modeName))
            {
                switch (modeName)
                {
                    case "Away":
                        _modes.Add(modeName, new AwayMode());
                        break;
                    case "Home":
                        _modes.Add(modeName, new HomeMode());
                        break;
                    case "Night":
                        _modes.Add(modeName, new NightMode());
                        break;
                    case "Energy Saving":
                        _modes.Add(modeName, new EnergySavingMode());
                        break;
                    default:
                        throw new ArgumentException("Invalid mode name");
                }
            }
            return _modes[modeName];
        }
    }
}
