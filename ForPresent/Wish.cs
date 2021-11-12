using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    class Wish
    {
        public string Message { get; set; }

        public Wish()
        {
            Message = "no message";
        }
    }

    class BoyWish : Wish
    {
        public BoyWish() : base()
        {
            Message = GetRandomBoyWish();
        }

        public string GetRandomBoyWish()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(WishForBoy)).Cast<WishForBoy>().ToList();

            return "Be " + valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }
    class GirlWish : Wish
    {
        public GirlWish() : base()
        {
            Message = GetRandomGirlWish();
        }

        public string GetRandomGirlWish()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(WishForGirl)).Cast<WishForGirl>().ToList();

            return "Be " + valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }
}
