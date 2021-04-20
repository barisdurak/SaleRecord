using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.Model
{

    [Table("sale")]
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int Price { get; set; }
        
        public string RecordDate { get; set; }

    }
}
