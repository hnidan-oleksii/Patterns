using StructuralMain.Adapter;
using StructuralMain.Composite;
using StructuralMain.Decorator;
using StructuralMain.Facade;
using StructuralMain.Proxy;
using StructuralMain.Flyweight;
using StructuralMain.Bridge;

namespace StructuralMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var homeFacade = new SmartHomeFacade();

            // DeviceModeFactory for Flyweight pattern
            var modeFactory = new DeviceModeFactory();
            var awayMode = modeFactory.GetMode("Away");
            var nightMode = modeFactory.GetMode("Night");

            // Creating devices
            var kitchenLight = new Light("Kitchen Light");
            var bedroomLight = new Light("Bedroom Light");

            // Set Connections
            var wifiConnection = new WiFiConnection();
            var bluetoothConnection = new BluetoothConnection();
            kitchenLight.SetConnection(wifiConnection);
            bedroomLight.SetConnection(bluetoothConnection);

            // Wrapping devices with a Proxy for security, then adding logging via Decorator
            var secureKitchenLight = new SecureDeviceProxy(kitchenLight, "123");
            var loggedKitchenLight = new SmartDeviceLogger(secureKitchenLight);

            var secureBedroomLight = new SecureDeviceProxy(bedroomLight, "123");
            var loggedBedroomLight = new SmartDeviceLogger(secureBedroomLight);

            // Adding devices to the system
            homeFacade.AddDevice(loggedKitchenLight);
            homeFacade.AddDevice(loggedBedroomLight);

            // Applying modes
            homeFacade.ApplyModeToAllDevices(awayMode);
            homeFacade.ApplyModeToAllDevices(nightMode);

            // Adding a thermostat through an adapter, with logging
            var thermostat = new ThermostatAdapter(new ExternalThermostat());
            thermostat.SetConnection(wifiConnection);
            var loggedThermostat = new SmartDeviceLogger(thermostat);
            homeFacade.AddDevice(loggedThermostat);

            Console.WriteLine("\nSecurely turning on the home with logging...");
            homeFacade.TurnOnHome();

            Console.WriteLine("\nSecurely turning off the home with logging...");
            homeFacade.TurnOffHome();
        }
    }
}
