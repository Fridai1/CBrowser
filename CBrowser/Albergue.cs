using System.Collections.Generic;
using System.Linq;

namespace CBrowser
{
    public class Albergue
    {
        
        private Rating _Rating;
        private double _IncRating;

        public Albergue(string adresse, string name, double rating, int telephone, bool wifi, bool washingMachine, bool kitchen, bool bike)
        {
            Adresse = adresse;
            Name = name;
            _Rating.NewRating(rating);
            Telephone = telephone;
            Wifi = wifi;
            WashingMachine = washingMachine;
            Kitchen = kitchen;
            Bike = bike;
        }

        public Albergue()
        {

        }

        public string Name { get; set; }
        public string Adresse { get; set; }

        public double Rating
        {
            get => _Rating.GetRating;
            set=> _Rating.NewRating(value);
        }
        public int Telephone { get; set; }
        public bool Wifi { get; set; }
        public bool Kitchen { get; set; }
        public bool WashingMachine { get; set; }
        public bool Bike { get; set; }
        
    }
}