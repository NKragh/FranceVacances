using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacances
{
    class Houses
    {
        //TODO: Indfør dictionary for facilities
        private double _price;
        private int _rooms;
        private string _location;
        private int _ratingOfficial;
        private int _ratingGuest;
        private string _destinationType;


        private Dictionary<string, bool> facilitiesDict = new Dictionary<string, bool>()
        {
            { "Internet", false},
            {"Breakfast", false},
            {"Dinner", false},
            {"Pets", false},
            {"Pool", false},
            {"Parking", false},
            {"Aircondition", false},
            {"Kitchen", false},
            {"Elevator", false},
        };

        /// <summary>
        /// Constructor of Houses class. Takes multiple inputs.
        /// </summary>
        /// <param name="price">Price pr. day</param>
        /// <param name="rooms">Number of rooms</param>
        /// <param name="address">The address of the house</param>
        /// <param name="ratingOfficial">Official rating from Hotelstars Union</param>
        /// <param name="ratingGuest">The rating </param>
        /// <param name="destinationType"></param>
        /// <param name="inputDict"></param>
        public Houses(double price, int rooms, string address, string destinationType, Dictionary<string, bool> inputDict)
        {
            _price = price;
            _rooms = rooms;
            _location = address;
            _destinationType = destinationType;

            foreach (KeyValuePair<string, bool> facility in facilitiesDict)
            {
                if (inputDict.ContainsKey(facility.Key))
                {
                    inputDict[facility.Key] = facility.Value;
                }
            }
        }
    }
}
