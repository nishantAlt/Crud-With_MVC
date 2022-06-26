using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo_CRUD.Controllers
{
    public class DemoController : ApiController
    {


        //[FromBody]Bean data
        Dbclass obj = new Dbclass();

        
        [HttpPost]
        public string Post([FromBody]Bean data)
        {
            Bean bean = new Bean();
            bean.Id = data.Id;
            bean.Name = data.Name;
            int i = obj.insert(bean);
            // int i = obj.insert(new Bean(data.Id, data.Name));
            //int i = obj.insert(data);
            return "Rows Inserted: "+ i; 
           // return "Post Called";
        }

        [HttpGet]
        public List<Bean> Get()
        {
            return obj.selectAll();
        }

        
    }
}
