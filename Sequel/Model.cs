using System;
using System.Collections.Generic;
using System.Text;

namespace Sequel {
    class Model {
        private string tableName;
        private string TableName { get => tableName; set => tableName = value; }
        public Model(string table) {
            TableName = table;
        }

        public void BeforeCreate() {

        }

        public void AfterCreate() {

        }
    }
}
