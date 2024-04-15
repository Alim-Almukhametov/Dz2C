using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semi2
{
    internal interface IBits
    {
        long Value { get; set; }
        bool GetBit(int i);
        void SetBit(bool bit , int i);

    }
}
