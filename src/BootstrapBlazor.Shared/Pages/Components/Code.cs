using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;

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
            JSRuntime.InvokeVoidAsync("$.highlight", CodeElement, CodeFile);
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
            builder.CloseElement();
        }
    }
}
