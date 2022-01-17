using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists.Clasess
{
    public class AccentJournalItem
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

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public AccentJournalItem(int id, string recordTime, string message)
        {
            ID = id;
            RecordTime = recordTime;
            Message = message;
        }
    }
}
