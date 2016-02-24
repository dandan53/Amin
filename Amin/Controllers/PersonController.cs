using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Amin.Controllers
{
    public class PersonController : ApiController
    {
        //private List<Item> Items;

        // GET api/person
        public List<string> Get()
        {
            var retVal = (List<string>)DBDAL.Instance.GetPersonList();
            return retVal;
        }


        //// GET api/Todo/5
        //public Item Get(int id)
        //{
        //    Item item = DAL.Instance.GetItem(id);
        //    return item;
        //}

        //// DELETE api/Item/5
        //public HttpResponseMessage Delete(int id)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, new Item());
        //}

        // POST api/person?person=aaa
        public bool Post(string person)
        {
            var retVal = DBDAL.Instance.AddPerson(person);
            return retVal;
        }

        //// PUT api/Item/5
        //public HttpResponseMessage PutTodo(int id, Item item)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

    }
}