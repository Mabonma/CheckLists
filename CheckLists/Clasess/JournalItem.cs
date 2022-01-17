using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    public class JournalItem : IJournalItem
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _recordTime;
        public string RecordTime
        {
            get { return _recordTime; }
            set { _recordTime = value; }
        }

        private string _shiftName;
        public string ShiftName
        {
            get { return _shiftName; }
            set { _shiftName = value; }
        }

        private string _shiftDescription;
        public string ShiftDescription
        {
            get { return _shiftDescription; }
            set { _shiftDescription = value; }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _shiftTimeAfter;
        public string ShiftTimeAfter
        {
            get { return _shiftTimeAfter; }
            set { _shiftTimeAfter = value; }
        }

        private string _shiftTimeBefore;
        public string ShiftTimeBefore
        {
            get { return _shiftTimeBefore; }
            set { _shiftTimeBefore = value; }
        }

        private string _authorName;
        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public JournalItem(int id, string recordTime, string shiftName, string shiftDescription,
            string comment, string shiftTimeAfter, string shiftTimeBefore, string authorName)
        {
            ID = id;
            RecordTime = recordTime;
            ShiftName = shiftName;
            ShiftDescription = shiftDescription;
            Comment = comment;
            ShiftTimeAfter = shiftTimeAfter;
            ShiftTimeBefore = shiftTimeBefore;
            AuthorName = authorName;
        }
    }
}
