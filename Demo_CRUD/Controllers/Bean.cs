﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_CRUD.Controllers
{
    public class Bean
    {
        private String id,name;
        public Bean() { }
        public Bean(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}