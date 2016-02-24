using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Amin.Controllers
{
    public class DAL
    {
        private List<string> personList;

        private static DAL instance = null;

        private DAL()
        {
        }

        public static DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL();
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

                DBDAL.Instance.AddPerson(person);
            }
        }

        public bool IsPersonExist(string person)
        {
            bool retVal = personList.Exists(item => item.Equals(person));
            return retVal;
        }

        public void Init()
        {
            personList = DBDAL.Instance.GetPersonList();
        }

    }
}