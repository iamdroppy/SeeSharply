# SeeSharply
SeeSharply is a frontend for Mono.Cecil using Blazor WebAssembly targetting .NET Standard 2.1. What differs from SeeSharply from other projects is that it runs completely on the client-side and does not transmit or share any data with any WebService, but still maintaining the power from Mono.Cecil.

It is currently on alpha, and should remain like that for a while.

Demo can be found at https://iamdroppy.github.io/SeeSharply-build/ although it is not keeping up-to-date with `master` at the minute.

## Features

### Basic functionality
- [x] Assembly loading
- [x] Assembly saving
- [x] Type navigation
- [x] TypeDefinition renaming
- [ ] ModuleDefinition renaming
- [ ] MethodDefinition (and others) remaming
- [ ] ldstr assembly listing/modification
- [ ] Attribute modification

### Other functionalities
- [x] Simple name obfuscation
