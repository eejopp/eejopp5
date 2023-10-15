using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy
{
    class Tag
    {
        public DateTime dateTime;
        public List<Describe> notes;
    }

    class Describe
    {
       public string text;
       public string info;
    }
}
