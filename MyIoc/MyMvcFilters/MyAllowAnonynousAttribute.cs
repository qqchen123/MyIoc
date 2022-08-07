using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.MyMvcFilters
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MyAllowAnonynousAttribute:Attribute
    {
    }
}