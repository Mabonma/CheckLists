using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    public interface ICheckListItem : IShiftItem
    {
        string Comment { get; set; }
    }
}
