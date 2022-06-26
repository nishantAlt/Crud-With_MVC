using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo_CRUD.Controllers
{
    public class DemoAllController : ApiController
    {

        Dbclass obj = new Dbclass();

        /*
        [HttpPost]
        public string Post([FromBody] Bean data)
        {
            Bean bean = new Bean();
            int i = obj.insertCustom(new Bean(data.Id, data.Name));
            return "Rows Inserted: " + i;
            // return "Post Called";
        }*/

        [HttpPost]
        public string PostAll([FromBody] List<Bean> data)
        {
            int i = obj.insertCustomAll(data);
            return "Rows Inserted: " + i;
            //return "PostAll Called";
        }

        [HttpGet]
        public List<Bean> Get()
        {
            return obj.selectAll();
        }
    }
}
