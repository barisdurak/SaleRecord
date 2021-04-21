using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Model
{

    [Table("product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int ProductCode { get; set; }

    }
}
