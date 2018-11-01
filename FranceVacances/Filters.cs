using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances
{
    class Filters
    {
        List<String> facilities = new List<string>();
        List<String> houseType = new List<string>();
        private double priceFrom;
        private double priceTo;
        private int ratingOfficial;
        private int ratingGuest;
        private bool travelFood;
        private String travelClass;
        private int roomAmount;

        public Filters()
        {
            
        }

        public void ApplyFilter()
        {
            //TODO: 
        }
    }
}
