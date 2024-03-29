﻿
using Microsoft.EntityFrameworkCore;
using SurveyApp.Dal;

namespace SurveyApp.Api.Registrars
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {

            var cs = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<AppDatabaseContext>(options => options.UseSqlServer(cs));

            
        }
    }
}
