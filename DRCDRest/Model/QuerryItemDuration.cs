using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRCDRest
{
    public class QuerryItemDuration
    {
        private double _durationLower;
        private double _durationHigher;

        public QuerryItemDuration()
        {

        }

        public QuerryItemDuration(double durationLower, double durationHigher)
        {
            DurationLower = durationLower;
            DurationHigher = durationHigher;
        }

        public double DurationLower
        {
            get { return _durationLower; }
            set { _durationLower = value; }
        }

        public double DurationHigher
        {
            get { return _durationHigher; }
            set { _durationHigher = value; }
        }
    }
}
