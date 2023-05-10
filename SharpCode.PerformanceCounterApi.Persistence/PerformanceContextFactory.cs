using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCode.PerformanceCounterApi.Persistence
{
    internal class PerformanceContextFactory : IDbContextFactory<PerformanceContext>
    {
        public PerformanceContext CreateDbContext()
        {
            throw new NotImplementedException();
        }
    }
}
