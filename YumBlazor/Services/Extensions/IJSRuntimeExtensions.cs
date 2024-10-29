using Microsoft.JSInterop;

namespace YumBlazor.Services.Extensions
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime js,string msg)
        {
            await js.InvokeVoidAsync("ShowToastr","success",msg);
        }
        public static async Task ToastrError(this IJSRuntime js, string msg)
        {
            await js.InvokeVoidAsync("ShowToastr", "error", msg);
        }
    }
}
