using Blog.Bussiness.Repositories.Implement;
using Blog.Bussiness.Repositories.Interfaces;
using Blog.Bussiness.Services.İmplement;
using Blog.Bussiness.Services.İnterfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Bussiness
{
    public static class ServicRegistration
    {
        public static IServiceCollection AddRepostory(this IServiceCollection servce)
        {
            servce.AddScoped<IPostRepostory, PostRepostory>();
            return servce;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            return services;
        }   
    }
  
}
