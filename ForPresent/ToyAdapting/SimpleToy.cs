using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    #region [Toys]
    abstract class Toy
    {
        public string Name { get; set; }
        //вертає іграшку незалежно від віку і статі дитини
        public virtual string GetRandomToy()
        {
            List<string> toys = new List<string>();
            toys.Add("Doll");
            toys.Add("Bike");
            toys.Add("Car");
            toys.Add("Dress");
            toys.Add("Ring");
            Random r = new Random();

            return toys[r.Next(0, toys.Count)];
        }
    }

    class SimpleToy : Toy
    {
        public SimpleToy()
        {
            Name = GetRandomToy();
        }
    }

    class BoyToy : SimpleToy
    {
        public BoyToy() : base()
        {
            Name = GetRandomToy();
        }
        public override string GetRandomToy()
        {
            return GetRandomBoyToy();
        }

        public string GetRandomBoyToy()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(ToyForBoy)).Cast<ToyForBoy>().ToList();

            return valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }

    class GirlToy : SimpleToy
    {
        public GirlToy() : base()
        {
            Name = GetRandomToy();
        }

        public override string GetRandomToy()
        {
            return GetRandomGirlToy();
        }
        public string GetRandomGirlToy()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(ToyForGirl)).Cast<ToyForGirl>().ToList();

            return valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }

    #endregion
}
