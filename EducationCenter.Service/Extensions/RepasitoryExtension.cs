using EducationCenter.Data.IRepasitories;
using EducationCenter.Data.Repasitories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCenter.Service.Extensions
{
    public static class RepasitoryExtension
    {
        public static void ConfigureRepasitories(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepasitory, EmployeeRepasitory>();
        }
    }
}
