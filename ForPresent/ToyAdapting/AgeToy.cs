using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    enum BabyToy {Pacifier, Diarers, Romper, BabyStoller }
    enum TeenagerToy {Money, BoomBox, Smartphone, Laptop }
    class AgeToy
    {
        public int ChildAge { get; set; }
        //true - хлопчик
        public bool ChildGender { get; set; }

        public AgeToy(int age = 10, bool gender = true)
        {
            ChildAge = 10;
            if (age > 0)
                ChildAge = age;
            ChildGender = gender;
            
        }

        public string GetAgeToy()
        {
            //немовля
            if(ChildAge<6)
            {
                Random r = new Random();

                var valuesList = Enum.GetValues(typeof(BabyToy)).Cast<BabyToy>().ToList();

                return valuesList[r.Next(0, valuesList.Count)].ToString();
            }
            //дитина
            else if(ChildAge < 16)
            {
                if(ChildGender == true)
                {
                    Random r = new Random();

                    var valuesList = Enum.GetValues(typeof(ToyForBoy)).Cast<ToyForBoy>().ToList();

                    return valuesList[r.Next(0, valuesList.Count)].ToString();
                }
                else
                {
                    Random r = new Random();

                    var valuesList = Enum.GetValues(typeof(ToyForGirl)).Cast<ToyForGirl>().ToList();

                    return valuesList[r.Next(0, valuesList.Count)].ToString();
                }
            }
            //підліток
            else
            {
                Random r = new Random();

                var valuesList = Enum.GetValues(typeof(TeenagerToy)).Cast<TeenagerToy>().ToList();

                return valuesList[r.Next(0, valuesList.Count)].ToString();
            }
        }
    }
}
