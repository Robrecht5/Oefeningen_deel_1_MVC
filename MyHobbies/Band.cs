using System;
using System.Collections.Generic;
using System.Text;

namespace MyHobbies
{
    public class Band
    {
        public string Naam { get; set; }
        public int Jaar { get; set; }

        public static Band[] GetAll()
        {
            Band im = new Band
            {
                Naam = "Iron Maiden",
                Jaar = 1986
            };

            return new Band[] { im };
        }

    }
    

}
