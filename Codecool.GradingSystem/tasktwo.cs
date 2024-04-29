using Codecool.GradingSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

//Task2:
namespace Codecool.GradingSystem
{
    public class tasktwo
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IExamRepository, ExamRepository>();
        }
    }
}
