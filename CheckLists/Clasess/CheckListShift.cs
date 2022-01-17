using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists.Clasess
{
    public class CheckListShift : Shift, ICheckListShift
    {
        private bool _isLasts;
        public bool IsLasts
        {
            get { return _isLasts; }
            set { _isLasts = value; }
        }
        //  !!!!!!!!      БАГ ТУТ          !!!!!!!!!!!!!!!!!!!!!!!         БАГ ТУТ       !!!!!!!!!!!!!!! был
        public CheckListShift(int id, int indexNumber, string name, string timeAfter, string timeBefore,
            List<IShiftItem> checkListItems, bool isLasts)
            : base(id, indexNumber, name, timeAfter, timeBefore, checkListItems)
        {
            IsLasts = isLasts;
        }
    }
}
