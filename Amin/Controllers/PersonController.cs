﻿using System;
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
        public IEnumerable<string> Get()
        {
            List<string> personList = DAL.Instance.GetPersonList();

            return personList;
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

        // POST api/person
        public HttpResponseMessage PostTodo(string person)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, person);
            
            DAL.Instance.AddPerson(person);

            return response;
        }

        //// PUT api/Item/5
        //public HttpResponseMessage PutTodo(int id, Item item)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK);
        //}

    }
}