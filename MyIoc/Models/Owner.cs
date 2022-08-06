using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public int HouseNumber { get; set; }
        public int WaterMeter { get; set; }
        public DateTime AddDate { get; set; }
        public int OwnerTypeId { get; set; }
    }
}