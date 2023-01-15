﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.Models
{
    internal class MyContext : DbContext
    {
        public MyContext() 
        {

        }

        public virtual DbSet<البضاعه> البضاعه { get; set; }
        public virtual DbSet<الحسابات> الحسابات { get; set; }
        public virtual DbSet<الخزنه> الخزنه { get; set; }
        public virtual DbSet<الفواتير> الفواتير { get; set; }
        public virtual  DbSet<بيع> بيع { get; set; }
        public virtual DbSet<شراء> شراء { get; set; }
        public virtual DbSet<مرتجع_بيع> مرتجع_بيع { get; set; }
        public virtual DbSet<مرتجع_شراء> مرتجع_شراء { get; set; }



    }
}
