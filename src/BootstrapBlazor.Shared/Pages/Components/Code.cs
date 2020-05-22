using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BootstrapBlazor.Shared.Pages.Components
{
    /// <summary>
    /// 
    /// </summary>
    public class Code : ComponentBase
    {
        /// <summary>
        /// 
        /// </summary>
        private ElementReference CodeElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Inject]
        private IDemoCode? DemoCodeService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Parameter]
        public string? CodeFile { get; set; }

        /// <summary>
        /// 获得/设置 IJSRuntime 实例
        /// </summary>
        [Inject]
        private IJSRuntime? JSRuntime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstRender"></param>
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);

            JSRuntime.InvokeVoidAsync("$.highlight", CodeElement);
        }

        /// <summary>
        /// BuildRenderTree 方法
        /// </summary>
        /// <param name="builder"></param>
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            // <code @ref="CodeElement">
            var index = 0;
            builder.OpenElement(index++, "code");
            builder.AddElementReferenceCapture(index, el => CodeElement = el);
            if (string.IsNullOrEmpty(CodeFile)) builder.AddContent(index++, ChildContent);
            else builder.AddContent(index++, Content());
            builder.CloseElement();
        }

        private string Content()
        {
            var ret = "";
            if (!string.IsNullOrEmpty(CodeFile) && DemoCodeService != null)
            {
                ret = DemoCodeService.ReadCode(CodeFile).GetAwaiter().GetResult();
            }
            return ret;
        }
    }
}
