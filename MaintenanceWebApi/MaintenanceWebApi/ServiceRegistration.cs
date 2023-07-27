
using Application.Validators.Department;
using Application.Validators.Equipment;
using FluentValidation.AspNetCore;

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
            });
        }
    }
}
