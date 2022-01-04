using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    interface ISeries
    {
        int setStart();
        int getNext();
        void reset();
    }
}
