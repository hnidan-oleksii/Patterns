using Behavioral.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.State
{
    internal class AlertState : IState
    {
        private Sensor sensor;

        public AlertState(Sensor sensor)
        {
            this.sensor = sensor;
        }

        public void Handle()
        {
            Console.WriteLine("Alert: Sensor data exceeds threshold!");
        }
    }
}
