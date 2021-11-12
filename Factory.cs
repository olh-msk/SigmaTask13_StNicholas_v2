using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    #region [Factories]
    interface AbstractPresentsFactory
    {
        public SimpleToy CreateToy();
        public Wish CreateWish();
        public EatenGift CreateEatenFift();
    }

    class BoyPresentsFactory : AbstractPresentsFactory
    {
        public EatenGift CreateEatenFift()
        {
            return new EatenGift();
        }

        public SimpleToy CreateToy()
        {
            return new BoyToy();
        }

        public Wish CreateWish()
        {
            return new BoyWish();
        }
    }

    class GirlPresentsFactory : AbstractPresentsFactory
    {
        public EatenGift CreateEatenFift()
        {
            return new EatenGift();
        }

        public SimpleToy CreateToy()
        {
            return new GirlToy();
        }

        public Wish CreateWish()
        {
            return new GirlWish();
        }
    }
    #endregion
}
