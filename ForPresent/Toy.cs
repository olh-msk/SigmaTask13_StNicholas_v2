using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    class Toy
    {
        public string Name { get; set; }

        public Toy()
        {
            Name = "N/A";
        }
    }

    class BoyToy : Toy
    {
        public BoyToy() : base()
        {
            Name = GetRandomBoyToy();
        }

        public string GetRandomBoyToy()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(ToyForBoy)).Cast<ToyForBoy>().ToList();

            return valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }

    class GirlToy : Toy
    {
        public GirlToy() : base()
        {
            Name = GetRandomGirlToy();
        }

        public string GetRandomGirlToy()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(ToyForGirl)).Cast<ToyForGirl>().ToList();

            return valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }
}
