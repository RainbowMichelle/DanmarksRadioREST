using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRCDRest.Model
{
    public class QuerryItemYear
    {
        private int _yearLower;
        private int _yearHigher;

        public QuerryItemYear()
        {

        }

        public QuerryItemYear(int yearLower, int yearHigher)
        {
            YearLower = yearLower;
            YearHigher = yearHigher;
        }

        public int YearLower
        {
            get { return _yearLower; }
            set { _yearLower = value; }
        }

        public int YearHigher
        {
            get { return _yearHigher; }
            set { _yearHigher = value; }
        }

        public override string ToString()
        {
            return $"YearLower: {YearLower}. YearHigher: {YearHigher}";
        }
    }
}
