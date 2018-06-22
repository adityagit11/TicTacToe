# TicTacToe
Simple TicTacToe

# To start a process
To execute any process (SomeFileName.exe)

```Csharp
using System.Diagnostics;

Process process = new Process();
// Set the file name of the application to start.
process.StartInfo.FileName = "C:\\Workstation\\SomeFile.exe";
process.StartInfo.FileName = "https://github.com/adityagit11";
process.StartInfo.Arguments = "-n";
process.Start();
process.WaitForExit();
```
