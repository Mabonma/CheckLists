using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists.Clasess
{
    public class CheckListItem : ICheckListItem
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

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
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

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private int _shiftID;
        public int ShiftID
        {
            get { return _shiftID; }
            set { _shiftID = value; }
        }

        public CheckListItem(IShiftItem item)
        {
            ID = item.ID;
            IndexNumber = item.IndexNumber;
            Name = item.Name;
            Description = item.Description;
            TimeAfter = item.TimeAfter;
            TimeBefore = item.TimeBefore;
            IsActive = item.IsActive;
            ShiftID = item.ShiftID;
        }
    }
}
