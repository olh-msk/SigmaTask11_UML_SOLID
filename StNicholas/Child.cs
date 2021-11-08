using SigmaTask11.gift_st.Nicholas_day.ForPresent;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask11.gift_st.Nicholas_day
{
    class Child
    {
        public string Name { get; set; }
        //true - хлопець
        public bool Gender { get; set; }

        public int GoodActions{get;set;}
        public int BadActions{get;set;}



        public Child()
        {
            Name = "doesn`t have";
            Gender = true;

            GoodActions = GetNumOfAction();
            BadActions = GetNumOfAction();
        }
        
        public int GetNumOfAction()
        {
            Random r = new Random();
            return r.Next(0,10);
        }

        public bool IsGood()
        {
            return GoodActions - BadActions >= 0 ? true : false;
        }

        public void SendRequest()
        {
            StNicholas.Instance().AddKid(this);
        }
    }
}
