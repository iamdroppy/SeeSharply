using System;
using System.IO;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Mono.Cecil;

namespace SeeSharply
{
    [Obsolete]
    public class SharedData
    {
        private readonly IJSRuntime _jsRuntime;

        [Parameter] public AssemblyDefinition AssemblyDefinition { get; set; }

        #region AssemblyDefinition AssemblyDefinitionChanged

        [Parameter] public EventCallback<AssemblyDefinition> AssemblyDefinitionChanged { get; set; }

        public async Task<AssemblyDefinition> ChangeAssemblyDefinitionNotifyAsync(AssemblyDefinition assemblyDefinition)
        {
            AssemblyDefinition = assemblyDefinition;
            await AssemblyDefinitionChanged.InvokeAsync(assemblyDefinition);
            return assemblyDefinition;
        }

        #endregion

        [Parameter] public IFileListEntry FileEntry { get; set; }

        #region IFileListEntry FileEntryChanged

        [Parameter] public EventCallback<IFileListEntry> FileEntryChanged { get; set; }

        public async Task<IFileListEntry> ChangeFileEntryNotifyAsync(IFileListEntry fileEntry)
        {
            FileEntry = fileEntry;
            await FileEntryChanged.InvokeAsync(fileEntry);
            return fileEntry;
        }

        #endregion

        public SharedData(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task DownloadChangesAsync()
        {
            await using MemoryStream memoryStream = new MemoryStream();
            AssemblyDefinition.Write(memoryStream);
            await FileUtil.SaveAs(_jsRuntime, FileEntry.Name, memoryStream.ToArray());
        }
    }
}