using System;
using System.Collections.Generic;

namespace SigmaTask13_StNicholas_v2
    {
    class Program
    {
        static void Main(string[] args)
        {
            StNicholas stNicholas = StNicholas.Instance();

            List<Child> childList = new List<Child>();

            childList.Add(new Child());
            childList[0].Name = "Oleh";
            childList.Add(new Child());
            childList[1].Name = "Pavlo";
            childList.Add(new Child());
            childList[2].Name = "Taras";
            childList.Add(new Child());
            childList[3].Name = "Nazar";

            childList.Add(new Child());
            childList[4].Name = "Nada";
            childList[4].Gender = false;
            childList.Add(new Child());
            childList[5].Name = "Olya";
            childList[5].Gender = false;
            childList.Add(new Child());
            childList[6].Name = "Sophia";
            childList[6].Gender = false;

            foreach (Child kid in childList)
            {
                stNicholas.AddKid(kid);
            }

            bool onlyGoodKids = true;

            Console.WriteLine(stNicholas.GivePresents(onlyGoodKids));


        }
    }
}
