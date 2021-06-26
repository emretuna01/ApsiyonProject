﻿using ApsiyonProject.Domain.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Entities
{
    public class Flat : BaseEntity
    {
        public string FlatNumer { get; set; }
        public Floor  Floor{ get; set; }
        public HouseOwner HouseOwner { get; set; }
    }
}