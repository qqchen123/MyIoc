﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyIoc.Models
{
    public class CurrentUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}