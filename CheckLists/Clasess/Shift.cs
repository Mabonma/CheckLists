using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists.Clasess
{
    public class Shift : IShift
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _indexNumber;
        public int IndexNumber
        {
            get { return _indexNumber; }
            set { _indexNumber = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _timeAfter;
        public string TimeAfter
        {
            get { return _timeAfter; }
            set { _timeAfter = value; }
        }

        private string _timeBefore;
        public string TimeBefore
        {
            get { return _timeBefore; }
            set { _timeBefore = value; }
        }

        private List<IShiftItem> _shiftItems;
        public List<IShiftItem> ShiftItems
        {
            get { return _shiftItems; }
            set { _shiftItems = value; }
        }

        public Shift(int id, int indexNumber, string name, string timeAfter, string timeBefore,
            List<IShiftItem> checkListItems)
        {
            ID = id;
            IndexNumber = indexNumber;
            Name = name;
            TimeAfter = timeAfter;
            TimeBefore = timeBefore;
            ShiftItems = checkListItems;
        }
    }
}
