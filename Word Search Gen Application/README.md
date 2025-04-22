# Word Search Generator Application
## Author
> Nicholas Cieplensky

## Design Tools Used
- Visual Basic
- C++
- Dynamic-Link Library

## Organization of Files
"wordsearch.txt" will always write out to wherever the application is stored, so it's in `bin\Debug\net8.0-windows\`

`WordDLL.dll` is stored in the uppermost layer of the project folder. Feel free to stick it in the application folder, but you'll have to rewrite the wrapper so the file path is different.
## Issues Encountered
*Where should I start: the DLL, the word search, the constant recompiling or the wrapper file?*
- DLL

	Getting into it, I didn't know I had to convert my C++ to C so that VB.NET can read it from the DLLExport file, so I spent hours troubleshooting that alone. I had to recompile it numerous times because I simply wasn't getting pointers right and kept overflowing where I shouldn't be..

- VB Net Wrapper

	More pointer issues, many times I caught a buffer overflow. Had to research more into function tags so I could actually protect them properly. Wouldn't have been so bad if I didn't have to write out a DLL invocation every time I needed to call a function.
