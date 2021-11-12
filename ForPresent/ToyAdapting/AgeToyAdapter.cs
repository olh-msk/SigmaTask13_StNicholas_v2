using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    class AgeToyAdapter : Toy
    {
        AgeToy ageToy;

        public AgeToyAdapter(int age=10, bool gender = true)
        {
            SetAgeToy(age,gender);
            Name = ageToy.GetAgeToy();
        }
         public void SetAgeToy(int age, bool gender)
        {
            ageToy = new AgeToy(age,gender);
        }

        public override string GetRandomToy()
        {
            return ageToy.GetAgeToy();
        }
    }
}
