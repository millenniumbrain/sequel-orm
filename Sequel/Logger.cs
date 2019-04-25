using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sequel {

    public class Logger {
        public const int DEBUG = 0;
        public const int INFO = 1;
        public const int WARN= 2;
        public const int ERROR = 3;
        public const int FATAL = 4;
        public const int UNKNOWN = 5;

        private LogDevice logDevice;
        private int level;
        private string progName;
        private string dateTimeFormat;
        private string[] levelLabels;

        public int Level { get => level; set => level = value; }
        public LogDevice LogDevice { get => logDevice; set => logDevice = value; }
        public string[] LevelLabels { get => levelLabels; set => levelLabels = value; }
        public string ProgName { get => progName; set => progName = value; }
        public string DateTimeFormat { get => dateTimeFormat; set => dateTimeFormat = value; }

        public Logger(StreamWriter logDevice, int logAge = 0, int logSize = 1048576, int level = DEBUG) {
            
            if (logDevice != null) {
                LogDevice = new LogDevice(logDevice, logAge, logSize);
            }

            DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
            LevelLabels = new string[] { "DEBUG", "INFO", "WARN", "ERROR", "FATAL", "UNKNOWN" };
        }

        public void Debug(string message) {
            Add(DEBUG, message);
        }

        public void Info(string message) {
            Add(INFO, message);
        }

        public void Warn(string message) {
            Add(WARN, message);
        }

        public void Error(string message) {
            Add(ERROR, message);
        }

        public void Fatal(string message) {
            Add(FATAL, message);
        }
        
        public void Unknown(string message) {
            Add(UNKNOWN, message);
        }

        public void Add(int level,  string message) {
            LogDevice.Write(Format(level, message));
        }
        
        public string Format(int level, string message) {
            string levelFormat = $"[{LevelLabels[level]}]";
            string dateTime = DateTime.UtcNow.ToString(DateTimeFormat);
            return $"{levelFormat} {message} {dateTime}";

        }


    }


}
