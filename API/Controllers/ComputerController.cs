using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web.Http;
using System.Net;

namespace API
{
    public class ComputerController : ApiController
    {
        // GET: api/computer

        public List <Computer> Get()
        {
            return Global.PCs;
        }

        public string Post([FromBody]Computer bodyPC)
        {
            // GET NEW / UPDATE PC
            Global.PCs.Add(bodyPC);
            return "200 OK - Added PC";
        }

        public string Put(int id, string para, string para2, int para3, string para4, string para5, int para6)
        {
            // UPDATE PC
            int index = Global.PCs.FindIndex(pc => id == pc.ID);
            Global.PCs[index].Cpu = para;
            Global.PCs[index].Graka = para2;
            Global.PCs[index].Ram = para3;
            Global.PCs[index].Motherboard = para4;
            Global.PCs[index].Power = para5;
            Global.PCs[index].Storage = para6;
            return $"200 Ok - Changed PC with id:{id}";
        }

        public string Delete(int id)
        { 
            Global.PCs[id] = null;
            return $"200 Ok - deleted PC with the id:{id}";
        }
    }
}
