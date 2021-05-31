﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Model
{
    [Table("store")]
    public class Store
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
