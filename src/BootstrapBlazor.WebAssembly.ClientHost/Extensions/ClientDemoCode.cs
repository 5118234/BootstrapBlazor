using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BootstrapBlazor.WebAssembly.ClientHost.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientDemoCode : IDemoCode
    {
        /// <summary>
        /// 
        /// </summary>
        protected HttpClient HttpClient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        public ClientDemoCode(HttpClient client)
        {
            HttpClient = client;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Task<string> ReadCode(string fileName)
        {
            var content = "client code";
            //content = await HttpClient.GetStringAsync($"/code/{fileName}");
            return Task.FromResult(content);
        }
    }
}
