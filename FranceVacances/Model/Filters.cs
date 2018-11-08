using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances.Model
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
        private string travelClass;
        private int roomAmount;

        public Filters()
        {
            //TODO: Checkliste i UI skal ændre på liste med filtrene
        }

        public void ApplyFilter()
        {
            //TODO: Metode til at applyfilter ud fra checkliste.
        }
    }
}
