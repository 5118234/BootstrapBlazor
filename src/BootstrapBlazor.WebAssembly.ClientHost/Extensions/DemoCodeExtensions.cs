﻿using BootstrapBlazor.WebAssembly.ClientHost.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class DemoCodeExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDemoCode(this IServiceCollection services)
        {
            services.AddSingleton<IDemoCode, ClientDemoCode>();
            return services;
        }
    }
}