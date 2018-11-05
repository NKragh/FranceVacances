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
        private DateTime? dateFrom;
        private DateTime? dateTo;
        private int people;
        private string travelType;

        public Searchbar(string travelType, string airportFrom, string airportTo, DateTime? dateInput, int numberOfTravelers)
        {
            //Grib værdier fra UI, hvor brugeren skriver de værdier der skal søges efter, og sæt dem lige med properties.

            this.travelType = travelType;
            this.airportFrom = airportFrom;
            this.airportTo = airportTo;
            this.dateFrom = dateInput;
            this.dateTo = dateInput;
            this.people = numberOfTravelers;
        }

        public void MakeSearch()
        {
            //TODO: Implementer; Skal kunne display de boliger der matcher de valgte properties

            
        }

        public void printValues()
        {

        }
    }
}
