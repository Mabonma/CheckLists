using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    interface ICheckListShift : IShift
    {
        bool IsLasts { get; set; }
    }
}
