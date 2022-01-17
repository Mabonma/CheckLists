using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    interface IOracleItem
    {
        int ID { get; set; }

        string Author_Name { get; set; }

        string DB_Name { get; set; }

        string User_Name { get; set; }

        string SQL_Query_Text { get; set; }
    }
}
