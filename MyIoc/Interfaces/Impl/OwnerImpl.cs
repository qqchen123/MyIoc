using log4net;
using MyIoc.Models;
using MyIoc.MyUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Interfaces.Impl
{
    public class OwnerImpl : IOwner
    {
        private static ILog log = LogManager.GetLogger(typeof(OwnerImpl));
        public IList<Owner> getAllOwners()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var cateList = session.QueryOver<Owner>();
                    transaction.Commit();
                    return cateList.List();
                }
            }
        }

        public Owner getOneOwner()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    return session.Get<Owner>(11);
                }
            }
        }
    }
}