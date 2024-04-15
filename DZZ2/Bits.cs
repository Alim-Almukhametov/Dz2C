using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semi2
{
    internal class Bits : IBits

    {  // Неявное приведение из long, int ,byte  в Bits.
        public static implicit operator Bits(long a)
        {
            return new Bits(a);
        }
        public static implicit operator Bits(int i)=> new Bits(i);
        public static implicit operator Bits(byte b) => new Bits(b);
        private int Size;
       
        public Bits(byte value)  // Тут нарушенно многое , но так на семинаре сказал сделать 
            // преподаватель. Не судите строго , ДЗ наверху.
        {
            Size = sizeof(byte) * 8;
            Value = value;
        }
        public Bits(int value)
        {
            Size = sizeof(int) * 8;
            Value = value;
        }
        public Bits(short value)
        {
            Size = sizeof(short)*8;
            Value = value;
        }
        public Bits(long value)
        {
            Size = sizeof(long)*8;
            Value = value;
        }
        public long Value { get ; set ; }

        public bool GetBit(int i)
        {
            if (i>Size || i<0) { return false; }   
            return ((Value >> i) & 1)==1;
        }

        public void SetBit(bool bit , int i)
        {
            if (i>Size||i<0) { return; }
            if (bit == true)
                Value = (byte)(Value|(1 << i));
            else 
            {
                var mask = (byte)(1 << i);
                mask= (byte)(0xff^mask);
                Value &= (byte)(Value & mask);
            }
        }
    }
}
