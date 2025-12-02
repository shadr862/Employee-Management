using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection DomainDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
