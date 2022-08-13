using FluentNHibernate.Mapping;
using MyIoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Mapping
{
    public class OwnerMap : ClassMap<Owner>
    {
        public OwnerMap() {
            Id(x => x.Id).Column("ID").GeneratedBy.Sequence("SEQ_T_OWNERS");
            Map(x => x.Name).Column("NAME");
            Map(x => x.AddressId).Column("ADDRESSID");
            //Map(x => x.AddDate).Column("ADDDATE");
            Map(x => x.HouseNumber).Column("HOUSENUMBER");
            Map(x => x.OwnerTypeId).Column("OWNERTYPEID");
            Map(x => x.WaterMeter).Column("WATERMETER");
            Table("T_OWNERS");
        }
    }
}