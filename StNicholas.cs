using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    #region [StNicholas operations]
    interface IOperationAddRemoveKid
    {
        public bool AddKid(Child chl);
        public bool RemoveKid(Child chl);
    }
    interface IOperationGivePresents
    {
        public string GivePresents(bool onlyGood);
        public string GiveAgeBasedPresents();
    }
    class StNicholas : IOperationAddRemoveKid, IOperationGivePresents
    {
        private static StNicholas instance;

        List<Child> currentChilds;

        Present present;

        private StNicholas()
        {
            currentChilds = new List<Child>();
            present = new Present();
        }

        public static StNicholas Instance()
        {
            if(instance == null)
            {
                instance = new StNicholas();
            }
            return instance;
        }

        //прості подарки------------
        public string GivePresents(bool onlyGood)
        {
            string res = "";

            foreach(Child kid in currentChilds)
            {
                //чи враховувати хороші вчинки=================================
                if(onlyGood == true)
                {
                    //більше хороших вчинків-------------------
                    if(kid.IsGood())
                    {
                        //хлопець
                        if (kid.Gender == true)
                        {
                            present.Factory = new BoyPresentsFactory();

                            present.MakePresent();

                            res += MakeStringWithKid(kid);

                        }
                        //дівчина
                        else
                        {
                            present.Factory = new GirlPresentsFactory();
                            present.MakePresent();

                            res += MakeStringWithKid(kid);

                        }
                    }
                    //більше поганих вчинків--------------------------
                    else
                    {
                        present.MakeBadPresent();
                        res += MakeStringWithKid(kid);
                    }
                }
                //не враховувати хороші вчинки=============================
                else
                {
                    //хлопець
                    if (kid.Gender == true)
                    {
                        present.Factory = new BoyPresentsFactory();

                        present.MakePresent();

                        res += MakeStringWithKid(kid);

                    }
                    //дівчина
                    else
                    {
                        present.Factory = new GirlPresentsFactory();
                        present.MakePresent();

                        res += MakeStringWithKid(kid);

                    }
                }
            }

            return res;
        }

        //подарки залежно від віку-------
        public string GiveAgeBasedPresents()
        {
            string res = "";


            foreach(Child kid in currentChilds)
            {
                if(kid.Gender == true)
                {
                    present.Factory = new BoyPresentsFactory();
                    present.MakePresent();
                    //корегуємо іграшку відносно віку і статі
                    present.Toy = new AgeToyAdapter(kid.Age,kid.Gender);
                    res += MakeStringWithKid(kid);
                }
                else
                {
                    present.Factory = new GirlPresentsFactory();
                    present.MakePresent();
                    //корегуємо іграшку відносно віку і статі
                    present.Toy = new AgeToyAdapter(kid.Age, kid.Gender);
                    res += MakeStringWithKid(kid);
                }
            }
            return res;
        }
        public string MakeStringWithKid(Child child)
        {
            string res = "";
            string gender = "girl";
            if(child.Gender == true)
            {
                gender = "boy";
            }
            res += string.Format("Name: {0}\tGender: {1}\tAge: {2}\nHas present:\n{3}\n\n", child.Name,gender,child.Age, present.ToString());
            return res;
        }

        public bool AddKid(Child chl)
        {
            int count = currentChilds.Count;
            currentChilds.Add(chl);
            return count > currentChilds.Count;
        }
        public bool RemoveKid(Child chl)
        {
            int count = currentChilds.Count;
            currentChilds.Add(chl);
            return count < currentChilds.Count;
        }
    }
    #endregion
}
