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
    }
}
