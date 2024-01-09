using Blog.Bussiness.DTOs.PostDto;
using Blog.Bussiness.ExternalServices.Implements;
using Blog.Bussiness.ExternalServices.Interfaces;
using Blog.Bussiness.Profiles;
using Blog.Bussiness.Repositories.Implement;
using Blog.Bussiness.Repositories.Interfaces;
using Blog.Bussiness.Services.İmplement;
using Blog.Bussiness.Services.İnterfaces;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


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
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IEmailServices, EmailServices>();
            services.AddScoped<IAuthServices, AuthService>();
            services.AddScoped<ITokenServices, TokenService>();
            return services;
        }

        [Obsolete]
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<PostCreateDTOValidator>());
            services.AddAutoMapper(typeof(PostMappingProfile).Assembly);
            return services;
        }
    }
  
}
