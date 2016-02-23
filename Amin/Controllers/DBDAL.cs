using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Amin.Controllers
{
    public sealed class DBDAL
    {
        private List<string> personList = new List<string>();

        private static DBDAL instance = null;

        private DBDAL()
        {
            InitPersonList();
        }

        public static DBDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBDAL();

                    //Init();
                }
                return instance;
            }
        }

        public List<string> GetPersonList()
        {
            return personList;
        }

        public void AddPerson(string person)
        {
            if (IsPersonExist(person) == false)
            {
                personList.Add(person);
            }
        }

        public bool IsPersonExist(string person)
        {
            bool retVal = personList.Exists(item => item.Equals(person));
            return retVal;
        }

        public void Init()
        {
            InitPersonList();
        }

        private void InitPersonList()
        {
            personList.Add("שלום ברכה בן טליה");
            personList.Add("בני בק בן קטי");
            personList.Add("שלווה כהן בת רונית");
            personList.Add("אריק עמנואל בן ריטה");
            personList.Add("שלומי ברק בן קטיה");
            personList.Add("שלומית ברכה בת שפרה ");
            personList.Add("אריה עמנואל בן ריטה");

        }
    }
}