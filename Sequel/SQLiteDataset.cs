using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace Sequel {
    public class SQLiteDataset {

        private SQLiteConnection connection;
        private string tableName;

        public string TableName { get => tableName; set => tableName = value; }
        public SQLiteConnection Connection { get => connection; set => connection = value; }

        public SQLiteDataset(SQLiteConnection DBconnection) {
            Connection = DBconnection;
        }

        public SQLiteDataset this[string tableName] {
            get {
                this.TableName = tableName;
                return this;
            }
        }
        
        public string Select(params string [] columns) {
            string sql = "SELECT ";

            return sql + columnFormatter(columns) + $"FROM {TableName}";
        }

        public string Select(string columns) {
            return $"SELECT {columns} FROM {TableName}";
        }

        public string columnFormatter(string[] columns) { 
            string sepColumns = "";
            for (int i = 0; i < columns.Length; i++) {
                if (i < columns.Length - 1) {
                    sepColumns = sepColumns + columns[i] + ", ";
                } else {
                    sepColumns = sepColumns + columns[i] + " ";
                }
            }
            return sepColumns;
        }
    }
}
