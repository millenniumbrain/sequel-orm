using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace Sequel {
    public class Migration {
        private SQLiteConnection connection;
        public SQLiteConnection Connection { get => connection; set => connection = value; }

        Migration() {

        }

        public void Migrate() {

        }
        
        private string primaryKey() {
            return "";

        }

        private string foreignKey() {
            return "";
        }

        private string Text() {
            return "";
        }
    }
}
