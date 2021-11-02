using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web.Http;

namespace API
{
    public class coreController : ApiController
    {
        // GET: api/core

        // GET: api/core/5
        public string Get(int id)
        {
            return $"Wert der übergeben wurde: {id}";
        }

        public string Get(string para ="", string para2 ="")
        {
            return $"{para} {para2}";
        }

        public Computer Get(string para, string para2, int para3, string para4, string para5, int para6)
        {
            return new Computer(para, para2, para3, para4, para5, para6);
        }

        // POST: api/core
        public string Post([FromBody]string para)
        {
            // Create new PC
            return para;
        }

        // PUT: api/core/1337
   

        // DELETE: api/core/1337
        public string Delete()
        {
            //DELETE PC
            return "Wert wurde auf 0 gesetzt";
        }
    }
}
