using System.Diagnostics;

namespace BootstrapBlazor.Shared.Pages
{
    /// <summary>
    /// 
    /// </summary>
    sealed partial class Install
    {
        private string? Version => "3.1.4"; //FileVersionInfo.GetVersionInfo(typeof(BootstrapBlazor.Components.Alert).Assembly.Location).ProductVersion;
    }
}
