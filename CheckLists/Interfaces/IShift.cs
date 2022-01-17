using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    interface IShift : IBaseItem
    {
        string TimeAfter { get; set; }
        string TimeBefore { get; set; }
        List<IShiftItem> ShiftItems { get; set; }
    }
}
