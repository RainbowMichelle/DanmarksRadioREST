using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRCDRest.Model
{
    public class QuerryItemTracks
    {
        private int _tracksLower;
        private int _tracksHigher;

        public QuerryItemTracks()
        {

        }

        public QuerryItemTracks(int tracksLower, int tracksHigher)
        {
            TracksLower = tracksLower;
            TracksHigher = TracksHigher;
        }

        public int TracksLower
        {
            get { return _tracksLower; }
            set { _tracksLower = value; }
        }

        public int TracksHigher
        {
            get { return _tracksHigher; }
            set { _tracksHigher = value; }
        }

        public override string ToString()
        {
            return $"TracksLower: {TracksLower}, TracksHigher: {TracksHigher}";
        }

    }
}
