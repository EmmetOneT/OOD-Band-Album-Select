using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00213942_Lab1
{
    public abstract class Band :IComparable
    {
        //Properties
        public string Bandname { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }
        public List<Album> AlbumList { get; set; }
        //Constructors
        public Band(string bandname, int yearFormed, string members)
        {
            Bandname = bandname;
            YearFormed = yearFormed;
            Members = members;

            AlbumList = new List<Album>();
        }

        public Band() : this("Unknown", 1960, "Unknown") { }
        

        //Methods
        public override string ToString()
        {
            return Bandname;
        }

        public int CompareTo(object obj)
        {
            Band otherband = obj as Band;
            return this.Bandname.CompareTo(otherband.Bandname);
        }
    }

    public class RockBand : Band
    {

        public override string ToString()
        {
            return base.ToString() + " - Rock Band";
        }
    }

    public class PopBand : Band 
    {
        public override string ToString()
        {
            return base.ToString() + " - Pop Band";
        }
    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Indie Band";
        }
    }
}
