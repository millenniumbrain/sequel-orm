using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace Sequel {
    public class SQLiteAdapter {
        private List<SQLiteConnection> connections;
        private Dictionary<string, dynamic> adapter;
        private Logger logger;
        public readonly Dictionary<string, string[]> SQLITE_TYPES = new Dictionary<string, string[]> {
            {"date", new string[] { "date"} },
            {"boolean", new string[] { "bit", "bool", "boolean"} },
            {"integer", new string[] { "integer", "smallint", "mediumint", "int", "bigint"} },
            {"decimal", new string[] { "decimal", "money", "numeric"} },
            {"float", new string[] { "float", "double", "real", "dec", "fixed", "double precision"} },
            {"blob", new string[] { "blob"} }
        };
        public List<SQLiteConnection> Connections { get => connections; set => connections = value; }
        public Dictionary<string, dynamic> Adapter { get => adapter; set => adapter = value; }
        //public List<DBLogger> Loggers { get => loggers; set => loggers = value; }
        public Logger Logger { get => logger; set => logger = value; }
        public SQLiteAdapter() {
            Connections = new List<SQLiteConnection>();
        }

        public void SetAdapter(Dictionary<string, dynamic> adapter) {

        }

        public void Migration(Migration migration) {

        }

        public SQLiteDataset SQLite(string filepath) {
            if (System.IO.File.Exists(filepath)) {
                SQLiteConnection connection = new SQLiteConnection($"Data Source={filepath};Version=3;");
                Connections.Add(connection);

                return new SQLiteDataset(connection);
            }
            return null;
        }
    }
}
