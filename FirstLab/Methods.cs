using System;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;

namespace FirstLab
{
    public static class Methods
    {
        public static Tuple<decimal, decimal> Adding(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal start = aB + bB;
            decimal end = aE + bE;
            return Tuple.Create(start, end);

        }
        public static Tuple<decimal, decimal> Subtraction(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal start = aB - bB;
            decimal end = aE - bE;
            return Tuple.Create(start, end);

        }
        public static Tuple<decimal, decimal> Multiply(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal start = aB * bB;
            decimal end = aE * bE;
            return Tuple.Create(start, end);

        }
        public static Tuple<decimal, decimal> Division(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal start = (decimal)aB / bB;
            decimal end = (decimal)aE / bE;
            return Tuple.Create(start, end);
        }
        public static Tuple<decimal, decimal> AddingToA(decimal aB, decimal aE, decimal num)
        {
            decimal start = aB + num;
            decimal end = aE + num;
            return Tuple.Create(start, end);

        }
        public static Tuple<decimal, decimal> SubtractionFromB(decimal bB, decimal bE, decimal num)
        {
            decimal start = bB - num;
            decimal end = bE - num;
            return Tuple.Create(start, end);

        }
        public static Tuple<decimal, decimal> MultiplyAByNum(decimal aB, decimal aE, decimal num)
        {
            decimal start = aB * num;
            decimal end = aE * num;
            return Tuple.Create(start, end);

        }
        public static Tuple<decimal, decimal> DivisionBByNum(decimal bB, decimal bE, decimal num)
        {
            decimal start = (decimal)bB / num;
            decimal end = (decimal)bE / num;
            return Tuple.Create(start, end);
        }
        public static Tuple<decimal, decimal> InverseB(decimal bB, decimal bE)
        {
            decimal start = bE ;
            decimal end = bB ;
            return Tuple.Create(start, end);

        }

        public static Tuple<decimal, decimal> DivisionH(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal[] array = new decimal[4];

       

            array[0] = aB / bB;
            array[1] = aB / bE;
            array[2] = bB / aE;
            array[3] = bB / aB;

            var min = array.Min();
            var max = array.Max();
            return Tuple.Create(min, max);

        }
        public static Tuple<decimal, decimal> MapA(decimal aB, decimal aE)
        {
            return Tuple.Create(aB, aE);

        }
        public static Tuple<decimal, decimal> Maximum(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal beg = aB > bB ? aB : bB;
            decimal end = aE > bE ? aE : bE;
            
            return Tuple.Create(beg, end);

        }

        public static Tuple<decimal, decimal> Minimum(decimal aB, decimal aE, decimal bB, decimal bE)
        {
            decimal beg = aB < bB ? aB : bB;
            decimal end = aE < bE ? aE : bE;

            return Tuple.Create(beg, end);
        }
    }
}