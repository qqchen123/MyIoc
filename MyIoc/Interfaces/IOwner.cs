using MyIoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Interfaces
{
    public interface IOwner
    {
        IList<Owner> getAllOwners();
    }
}