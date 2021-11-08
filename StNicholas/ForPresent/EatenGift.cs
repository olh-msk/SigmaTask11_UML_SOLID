using SigmaTask11.gift_st.Nicholas_day.ForPresent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaTask11.gift_st.Nicholas_day.ForPresent
{
    class EatenGift
    {
        public string Name{ get; set; }

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
