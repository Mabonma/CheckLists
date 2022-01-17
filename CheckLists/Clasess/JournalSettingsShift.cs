using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    public class JournalSettingsShift : IBaseItem
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

        public JournalSettingsShift(int id, int indexNumber, string name)
        {
            ID = id;
            IndexNumber = indexNumber;
            Name = name;
        }
    }
}
