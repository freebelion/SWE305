using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSoop
{
    internal class Fraction
    {
        // These two are field (member variable) definitions:
        private int _num;   // numerator (pay) value
        private int _denum; // denominator (payda) value

        /// <summary>
        /// This is a property definition which enables outside access
        /// to the private field _num.
        /// </summary>
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

        /// <summary>
        /// This is a property definition which enables outside access
        /// to the private field _denum.
        /// Note that its set block does not let a value of 0 to be assigned.
        /// </summary>
        public int Denum
        {
            get { return _denum; }
            set {
                if(value > 0) { _denum = value; }
                else if(value < 0)
                {
                    _num = -_num;
                    _denum = -value;
                }
                // An exception stops the program execution with an error message.
                else throw new ArgumentException("Denominator value cannot be zero!");
            }
        }

        /// <summary>
        /// This is the default (empty) constructor which is used
        /// to create a Fraction object without any initial values.
        /// </summary>
        public Fraction()
        {
            Num = 0;
            Denum = 1;
        }

        /// <summary>
        /// This is a constructor with parameters for the initial values of the member variables
        /// </summary>
        public Fraction(int p, int q)
        { Num = p; Denum = q; }

        /// <summary>
        /// This operator definiton returns the decimal numerical value of a Fraction
        /// when used as a type-cast operator as in (double)k.
        /// </summary>
        /// <param name="k"></param>
        public static explicit operator double(Fraction k)
        { return (double)k.Num / k.Denum; }

        /// <summary>
        /// This operator definition helps write a Fraction object in string form.
        /// It has to be called explicitly like a type-cast operator, as in (string)k.
        /// </summary>
        /// <param name="k"></param>
        public static explicit operator string(Fraction k)
        { return "[" + k.Num + "/" + k.Denum + "]"; }
    }
}
