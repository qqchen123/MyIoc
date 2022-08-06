using log4net;
using MyIoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Interfaces.Impl
{
    public class OwnerImpl : IOwner
    {
        private static ILog log = LogManager.GetLogger(typeof(OwnerImpl));
        public List<Owner> getAllOwners()
        {
            log.Info("getAllOwners -method--");
            List<Owner> OwnerList = new List<Owner>();
            Owner owner = new Owner();
            owner.Id = 1001;
            owner.Name = "sunwukong";
            owner.AddressId = 1;
            owner.HouseNumber = 1;
            owner.AddDate = DateTime.Today;
            OwnerList.Add(owner);

            return OwnerList;
        }
    }
}