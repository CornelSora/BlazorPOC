using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace POC.ComponentsLibrary.Vue
{
    public partial class VueMessage
    {
        [Parameter]
        public int Value { get; set; }
        [InjectAttribute]private IJSRuntime JSRuntime { get; set; }

        public async void IncrementText(int value)
        {
            await JSRuntime.InvokeVoidAsync(
                "vueMethods.vueInstance.incrementText",
                value
            );
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync(
                "vueMethods.init"
            );
            //base.OnAfterRenderAsync(firstRender);
        }
    }
}
