using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLists
{
    public interface IBaseItem
    {
        int ID { get; set; }
        int IndexNumber { get; set; }
        string Name { get; set; }
    }
}
