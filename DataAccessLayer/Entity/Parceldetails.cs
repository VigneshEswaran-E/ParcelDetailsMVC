using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Parceldetails
    {
        [Key]
        public long ParcelID { get; set; }
        public string FromAddress { get; set; }
        public string TOAddress { get; set; }
        public decimal NetWeight { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string ParcelServiceName { get; set; }
    }
}
