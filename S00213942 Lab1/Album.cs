using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00213942_Lab1
{
    public class Album
    {
        //Properties
        public string Name { get; set; }
        public int YearOfRelease { get; set; }
        public int Sales { get; set; }


        //Constructors
        public Album(string name, int yearOfRelease, int sales)
        {
            Name = name;
            YearOfRelease = yearOfRelease;
            Sales = sales;
        }

        public Album() { }

        //Methods
        public override string ToString()
        {
            return string.Format($"{Name} - reeleased in {YearOfRelease}. Sales of: {Sales}");
        }

    }
}
