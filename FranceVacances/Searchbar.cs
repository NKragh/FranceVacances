using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances
{
    class Searchbar
    {
        private String airportTo;
        private String airportFrom;
        private DateTime dateFrom;
        private DateTime dateTo;
        private int people;
        private string travelType;

        public Searchbar()
        {
            //TODO: Grib værdier fra UI, og sæt dem lige med properties, hvor brugeren skriver de værdier der skal søges efter.
        }

        public void MakeSearch()
        {
            //TODO: Implementer; Skal kunne display de boliger er matcher de valgte properties
        }
    }
}
