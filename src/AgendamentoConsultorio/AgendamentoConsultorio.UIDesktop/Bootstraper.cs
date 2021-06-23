using AgendamentoConsultorio.Domain.Models;
using AgendamentoConsultorio.Infra.Repositories;
using AgendamentoConsultorio.Services;
using AgendamentoConsultorio.Services.Interfaces;
using AgendamentoConsultorio.UIDesktop.Views;

using Microsoft.Extensions.DependencyInjection;

namespace AgendamentoConsultorio.UIDesktop
{
    static class Bootstraper
    {
        public static void AddWindows(this IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
        }

        public static void AddRepositories(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IRepository<Doctor>>(new DoctorRepository(connectionString));
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<DoctorService>();
        }
    }
}