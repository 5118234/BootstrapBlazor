using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDemoCode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<string> ReadCode(string fileName);
    }
}
