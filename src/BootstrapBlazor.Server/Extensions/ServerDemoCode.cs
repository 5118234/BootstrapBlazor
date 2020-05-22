using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Threading.Tasks;

namespace BootstrapBlazor.Server.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class ServerDemoCode : IDemoCode
    {
        /// <summary>
        /// 
        /// </summary>
        protected IWebHostEnvironment Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="env"></param>
        public ServerDemoCode(IWebHostEnvironment env)
        {
            Environment = env;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public async Task<string> ReadCode(string fileName)
        {
            var content = "";
            if (!string.IsNullOrEmpty(fileName) && Environment != null)
            {
                // 拼接实例文件路径
                var filePath = Environment.WebRootPath;
                var codeFile = Path.Combine(filePath, $"code{Path.DirectorySeparatorChar}{fileName}");
                if (File.Exists(codeFile))
                {
                    content = await File.ReadAllTextAsync(codeFile);
                }
            }
            return content;
        }
    }
}
