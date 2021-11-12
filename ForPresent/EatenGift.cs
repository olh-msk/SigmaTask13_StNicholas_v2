using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    class EatenGift
    {
        public string Name { get; set; }

        public EatenGift()
        {
            Name = GetRandomEatenGift();
        }

        public string GetRandomEatenGift()
        {
            Random r = new Random();

            var valuesList = Enum.GetValues(typeof(ForEatenGift)).Cast<ForEatenGift>().ToList();

            return valuesList[r.Next(0, valuesList.Count)].ToString();
        }
    }
}

