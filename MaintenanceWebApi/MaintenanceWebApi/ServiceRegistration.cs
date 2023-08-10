
using Application.Validators.Department;
using Application.Validators.Equipment;
using Application.Validators.User;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MaintenanceWebApi
{
    public static class ServiceRegistration
    {
        public static void AddValidationService(this IServiceCollection services)
        {
            services.AddControllers().AddFluentValidation(option =>
            {
                option.RegisterValidatorsFromAssemblyContaining<EquipmenCreatetValidator>();
                option.RegisterValidatorsFromAssemblyContaining<DepartmentCreateValidator>();
                option.RegisterValidatorsFromAssemblyContaining<UserLoginDtoValidator>();
                option.RegisterValidatorsFromAssemblyContaining<UserRegisterDtoValidator>();
            });


            //string imageSavePath = Path.Combine(_webHostEnvironment.ContentRootPath, "images");
            //services.AddSingleton<IWebHostEnvironment>(_ => _env);
            //services.AddSingleton(new ImageSaveConfig(imageSavePath));
        }
    }
}
