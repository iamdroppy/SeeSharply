using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace SeeSharply
{
    public static class FileUtil
    {
        public static async Task SaveAs(IJSRuntime js, string filename, byte[] data)
        {
            await js.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
        }
    }
}