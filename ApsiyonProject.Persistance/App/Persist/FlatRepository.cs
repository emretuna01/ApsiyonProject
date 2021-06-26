﻿using ApsiyonProject.Application.App.Common.Interfaces.DbRepository;
using ApsiyonProject.Domain.App.Entities;
using ApsiyonProject.Persistance.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonProject.Persistance.App.Persist
{
    public class FlatRepository : ApplicationDbRepository<Flat>, IFlatRepository
    {
        public FlatRepository(ApplicationDbContext aplicationDbContext) : base(aplicationDbContext)
        {
        }
    }
}
