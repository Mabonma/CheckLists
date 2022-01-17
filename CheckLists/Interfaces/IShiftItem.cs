using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    public interface IShiftItem : IBaseItem
    {
        string Description { get; set; }
        string TimeAfter { get; set; }
        string TimeBefore { get; set; }
        bool IsActive { get; set; }
        int ShiftID { get; set; }
    }
}
