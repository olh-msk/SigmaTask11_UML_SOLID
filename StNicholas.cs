using SigmaTask11.gift_st.Nicholas_day.ForPresent;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaTask11.gift_st.Nicholas_day
{
    interface IOperationAddRemoveKid
    {
        public bool AddKid(Child chl);
        public bool RemoveKid(Child chl);
    }
    class StNicholas : IOperationAddRemoveKid
    {
        private static StNicholas instance;

        List<Child> childs;

        Present present;

        private StNicholas()
        {
            childs = new List<Child>();
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



        public string GivePresents(bool onlyGood)
        {
            string res = "";

            foreach(Child kid in childs)
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

                            res += StringWithKid(kid);

                        }
                        //дівчина
                        else
                        {
                            present.Factory = new GirlPresentsFactory();
                            present.MakePresent();

                            res += StringWithKid(kid);

                        }
                    }
                    //більше поганих вчинків--------------------------
                    else
                    {
                        present.MakeBadPresent();
                        res += StringWithKid(kid);
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

                        res += StringWithKid(kid);

                    }
                    //дівчина
                    else
                    {
                        present.Factory = new GirlPresentsFactory();
                        present.MakePresent();

                        res += StringWithKid(kid);

                    }
                }
            }

            return res;
        }

        public string StringWithKid(Child child)
        {
            string res = "";
            string gender = "girl";
            if(child.Gender == true)
            {
                gender = "boy";
            }
            res += string.Format("Name: {0}\tGender: {1}\t\tHas present:\n{2}\n\n", child.Name,gender, present.ToString());
            return res;
        }

        public bool AddKid(Child chl)
        {
            int count = childs.Count;
            childs.Add(chl);
            return count > childs.Count;
        }
        public bool RemoveKid(Child chl)
        {
            int count = childs.Count;
            childs.Add(chl);
            return count < childs.Count;
        }
    }
}
