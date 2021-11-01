# SharpCompiler

Simple C# parser and compiler developed for university classes.

**Overview**
* Custom ANTLR grammar is used to parse C# (only subset of features, not actual C#) and generate a syntax tree.
* ANTLR syntax tree is converted into an Abstract Syntax Tree, semantic analysis is executed
* If semantic analysis passed, bytecode is generated for the target backend platform
    * IL for .NET (using in-built .NET's IL generator)
    * Java bytecode for Java (using Jasmin - Java assembler)

## Supported features
1. Static classes, static fields and static methods
2. For, while, if
3. int, bool, char and arrays.

See [Input.cs](Input.cs) example file to find examples and supported features.
For instance, you can implement a [quick-sort alghoritm](https://github.com/Frazi1/SharpCompiler/blob/59b90ed0b21a9057c9c11bb48b547963faf3ec9e/Input.cs#L72-L80) using this compiler.


## Usage example
1. Checkout latest release: https://github.com/Frazi1/SharpCompiler/releases
2. Create a <fileName>.cs file with program source code
3. ```
   NJC.exe <fileName>.cs --target=net //To generate a native Windows executable that runs under .NET
   NJC.exe <fileName>.cs --target=jasmin //To generate a Java bytecode file that runs under JVM
   ```
