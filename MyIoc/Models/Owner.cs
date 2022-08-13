using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Models
{
    public class Owner
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int AddressId { get; set; }
        public virtual string HouseNumber { get; set; }
        public virtual int WaterMeter { get; set; }
        public virtual DateTime AddDate { get; set; }
        public virtual int OwnerTypeId { get; set; }
    }
}