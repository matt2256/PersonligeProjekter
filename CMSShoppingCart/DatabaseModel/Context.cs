using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModel
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>  options) : base(options)
        {
        }


    }
}
