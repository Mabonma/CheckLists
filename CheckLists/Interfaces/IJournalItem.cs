using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    interface IJournalItem
    {
        int ID { get; set; }

        string RecordTime { get; set; }

        string ShiftName { get; set; }

        string ShiftDescription { get; set; }

        string Comment { get; set; }

        string AuthorName { get; set; }
    }
}
