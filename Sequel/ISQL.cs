using System;
using System.Collections.Generic;
using System.Text;

namespace Sequel {
    interface ISQL {

        object Select(string columns);

        object Where(string expression);

        object Where(Dictionary<string, int> expression);

        object Where(Dictionary<string, string> expression);

        object Limit(string limit);

        object Limit(int limit);

        object Join(string tables);

        object Join(string[] tables);

        object Join(Model tableOne, Model tableTwo);
    }
}
