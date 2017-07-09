using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepRunk.EntityFramework;

namespace GYT.EntityFramework
{
    public class GYTDbContext : KeepRunkDbContext
    {
        public GYTDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

    }
}
