using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask13_StNicholas_v2
{
    interface IOperationMakePresent
    {
        public void MakePresent();
        public void MakeBadPresent();
    }

    class Present : IOperationMakePresent
    {
        public Toy Toy { get; set; }
        public Wish Wish { get; set; }
        public EatenGift EatenGift { get; set; }
        public AbstractPresentsFactory Factory { get; set; }


        public void MakePresent()
        {
            this.EatenGift = this.Factory.CreateEatenFift();
            this.Toy = this.Factory.CreateToy();
            this.Wish = this.Factory.CreateWish();
        }

        public void MakeBadPresent()
        {
            this.EatenGift = new EatenGift();
            this.Toy = new SimpleToy();
            this.Wish = new Wish();

            this.EatenGift.Name = "Rust";
            this.Toy.Name = "Brich";
            this.Wish.Message = "Be more obedient";

        }
        public override string ToString()
        {
            string res = "";

            res += string.Format("Toy: {0}\t\tWish: {1}\t\tEaten Gift: {2}", Toy.Name, Wish.Message, EatenGift.Name);

            return res;
        }
    }
}

