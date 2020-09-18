using BlazorInputFile;
using Mono.Cecil;

namespace SeeSharply
{
    public interface IAssemblyData
    {
        AssemblyDefinition AssemblyDefinition { get; }
        IFileListEntry FileEntry { get; }
    }
}