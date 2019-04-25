using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sequel {

    public class LogDevice {
        private int logAge;
        private int logSize;
        private StreamWriter device;

        public int LogAge { get => logAge; set => logAge = value; }
        public int LogSize { get => logSize; set => logSize = value; }
        public StreamWriter Device { get => device; set => device = value; }


        public LogDevice(StreamWriter logDevice, int logAge, int logSize) {
            Device = logDevice;
            Device.AutoFlush = true;
            Console.SetOut(Device);
        }

        public void Write(string message) {
            Device.WriteLine(message);
        }
    }
}
