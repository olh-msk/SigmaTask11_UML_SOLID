using SigmaTask11.gift_st.Nicholas_day.ForPresent;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask11.gift_st.Nicholas_day
{
    interface AbstractPresentsFactory
    {
        public Toy CreateToy();
        public Wish CreateWish();
        public EatenGift CreateEatenFift();
    }

    class BoyPresentsFactory : AbstractPresentsFactory
    {
        public EatenGift CreateEatenFift()
        {
            return new EatenGift();
        }

        public Toy CreateToy()
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

        public Toy CreateToy()
        {
            return new GirlToy();
        }

        public Wish CreateWish()
        {
            return new GirlWish();
        }
    }
}
