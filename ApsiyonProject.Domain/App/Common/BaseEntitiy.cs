﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Domain.App.Common
{
    public class BaseEntitiy
    {
        public Guid Id { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
