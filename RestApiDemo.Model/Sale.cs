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

        public int StoreId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }
        [Write(false)]
        public DateTime RecordDate { get; set; }
        [Write(false)]
        public string ProductCode { get; set; }

    }
}
