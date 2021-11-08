using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask11.gift_st.Nicholas_day.ForPresent
{
    enum WishForBoe {Be, Strong, BePolite, }
    class Present
    {
        public Toy Toy {get;set;}
        public Wish Wish { get; set; }
        public EatenGift EatenGift { get; set; }
        public PresentsFactory Factory { get; set; }


        public void MakePresent()
        {
            this.EatenGift = this.Factory.CreateEatenFift();
            this.Toy = this.Factory.CreateToy();
            this.Wish = this.Factory.CreateWish();
        }

        public void MakeBadPresent()
        {
            this.EatenGift = new EatenGift();
            this.Toy = new Toy();
            this.Wish = new Wish();

            this.EatenGift.Name = "Rust";
            this.Toy.Name = "Brich";
            this.Wish.Message = "Be more obedient";

        }
        public override string ToString()
        {
            string res = "";

            res += string.Format("Toy: {0}\tWish: {1}\t\tEaten Gift: {2}",Toy.Name, Wish.Message, EatenGift.Name);

            return res;
        }
    }
}
