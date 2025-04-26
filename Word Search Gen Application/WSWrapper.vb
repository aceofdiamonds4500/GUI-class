Imports System
Imports System.Runtime.InteropServices
Imports System.Text

''' <summary>
''' Author: Nicholas Cieplensky
''' Description:
'''     This is a VB.NET Wrapper for all the C/C++ code I wrote. It calls functions from WordDLL.dll and creates Create, Destroy, ToString, and
'''     other various functions in order to complete the last interoperability step. With this, I can create Word, WordList, and WordSearch objects
'''     with the ease of VB.NET and the speed of C++. The decompiled code for the WordSearch can be found at my GitHub repo:
'''     https://github.com/aceofdiamonds4500/Word-Search-Generator
''' </summary>
Public Class Word
    'IntPtr just stores a signed int with the same bit-width as a pointer 
    'you use this for marshalling and also getting C pointers to function as intended in VB.NET 
    Private wordPtr As IntPtr

    'oh my god you have to import every single function
    'remind me to never do this again
    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function CreateWord(inputWord As String) As IntPtr
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub DestroyWord(wordPtr As IntPtr)
    End Sub

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordToString(wordPtr As IntPtr) As IntPtr
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordGetLength(wordPtr As IntPtr) As Integer
    End Function

    'needs to be created for Word, WordList, and WordSearch objects equally
    Public Sub New(word As String)
        wordPtr = CreateWord(word)
        If wordPtr = IntPtr.Zero Then
            Throw New Exception("Failed to create Word object")
        End If
    End Sub

    'This was important for WordList to call a Word object from inside itself, prevents overflow
    Friend Sub New(existingPtr As IntPtr)
        wordPtr = existingPtr
        If wordPtr = IntPtr.Zero Then
            Throw New Exception("Invalid Word pointer")
        End If
    End Sub

    'Objects always need to be destroyed in C. Otherwise, memory leak
    Protected Overrides Sub Finalize()
        If wordPtr <> IntPtr.Zero Then
            DestroyWord(wordPtr)
            wordPtr = IntPtr.Zero
        End If
        MyBase.Finalize()
    End Sub

    'length of word, returns Int
    Public Function GetLength() As Integer
        Return WordGetLength(wordPtr)
    End Function

    Public Overrides Function ToString() As String
        Dim strPtr As IntPtr = WordToString(wordPtr)
        Dim result As String = Marshal.PtrToStringAnsi(strPtr)
        Return result
    End Function

    'can call and return word.Pointer with this, only inside this file (friend tag) 
    Friend ReadOnly Property Pointer() As IntPtr
        Get
            Return wordPtr
        End Get
    End Property
End Class

Public Class WordList
    Private wordListPtr As IntPtr

    'imports
    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function CreateWordList() As IntPtr
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub DestroyWordList(wordListPtr As IntPtr)
    End Sub

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub WordListAddWord(wordListPtr As IntPtr, wordPtr As IntPtr)
    End Sub

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListRemoveWord(wordListPtr As IntPtr, wordPtr As IntPtr) As Boolean
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListGetCount(wordListPtr As IntPtr) As Integer
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListGetWordAt(wordListPtr As IntPtr, index As Integer) As IntPtr
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListToString(wordListPtr As IntPtr) As IntPtr
    End Function

    Public Sub New()
        wordListPtr = CreateWordList()
        If wordListPtr = IntPtr.Zero Then
            Throw New Exception("Failed to create WordList object")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If wordListPtr <> IntPtr.Zero Then
            DestroyWordList(wordListPtr)
            wordListPtr = IntPtr.Zero
        End If
        MyBase.Finalize()
    End Sub

    'Adds a word to the list of words
    'I choose to solely add words from the list to the wordsearch because I store them in the list as such:
    '"ALLCAPSNOSPACE"
    'To avoid mishaps
    Public Sub AddWord(word As Word)
        WordListAddWord(wordListPtr, word.Pointer)
    End Sub

    'Words are stored in a vector so the item is removed dynamically and the vector is resized automatically
    Public Function RemoveWord(word As Word) As Boolean
        Return WordListRemoveWord(wordListPtr, word.Pointer)
    End Function

    'Technically returns size of vector
    Public ReadOnly Property Count As Integer
        Get
            Return WordListGetCount(wordListPtr)
        End Get
    End Property

    'Will almost never fail with my Form1 class
    'New word object needs to be made in order to return a Word
    Public Function GetWordAt(index As Integer) As Word
        Dim ptr As IntPtr = WordListGetWordAt(wordListPtr, index)
        If ptr = IntPtr.Zero Then
            Throw New IndexOutOfRangeException("Invalid word index")
        End If
        Return New Word(ptr)
    End Function

    Public Overrides Function ToString() As String
        Dim strPtr As IntPtr = WordListToString(wordListPtr)
        Dim result As String = Marshal.PtrToStringAnsi(strPtr)
        Return result
    End Function

    Friend ReadOnly Property Pointer() As IntPtr
        Get
            Return wordListPtr
        End Get
    End Property
End Class

Public Class WordSearch
    Private wordSearchPtr As IntPtr

    'imports
    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function CreateWordSearch(ySize As Integer, xSize As Integer) As IntPtr
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub DestroyWordSearch(wordSearchPtr As IntPtr)
    End Sub

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchAddWord(wordSearchPtr As IntPtr, word As String) As Boolean
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchToString(wordSearchPtr As IntPtr) As IntPtr
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub WordSearchWriteToFile(wordSearchPtr As IntPtr, wordListPtr As IntPtr, filename As String)
    End Sub

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchGetYSize(wordSearchPtr As IntPtr) As Integer
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchGetXSize(wordSearchPtr As IntPtr) As Integer
    End Function

    <DllImport("WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchGetChar(wordSearchPtr As IntPtr, col As Integer, row As Integer) As Char
    End Function

    'The word search itself is a 2D vector with random characters inserted into each index, which will be overwritten later by wordList
    Public Sub New(ySize As Integer, xSize As Integer)
        wordSearchPtr = CreateWordSearch(ySize, xSize)
        If wordSearchPtr = IntPtr.Zero Then
            Throw New Exception("Failed to create WordSearch object...")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If wordSearchPtr <> IntPtr.Zero Then
            DestroyWordSearch(wordSearchPtr)
            wordSearchPtr = IntPtr.Zero
        End If
        MyBase.Finalize()
    End Sub

    'I want you to personally go to my github and find WordSearch::AddWord just to see what it actually took to put words in the word search
    'Returns a true or false in order to avoid placing words that don't work
    Public Function AddWord(word As String) As Boolean
        Return WordSearchAddWord(wordSearchPtr, word)
    End Function

    Public Overrides Function ToString() As String
        Dim strPtr As IntPtr = WordSearchToString(wordSearchPtr)
        Dim result As String = Marshal.PtrToStringAnsi(strPtr)
        Return result
    End Function

    'Writes to a file in nice, clean, C++ code (in the DLL, I mean). Writes with an ofstream object and will send a cerr if file opening is unsuccessful
    Public Sub WriteToFile(wordList As WordList, filename As String)
        WordSearchWriteToFile(wordSearchPtr, wordList.Pointer, filename)
    End Sub

    'This gets the ysize and the other gets the xsize.
    'If I wanted to I can make the Word Search bigger and add an easy, medium, and hard mode, but I'm strapped for time.
    Public Function GetYSize() As Integer
        Return WordSearchGetYSize(wordSearchPtr)
    End Function

    Public Function GetXSize() As Integer
        Return WordSearchGetXSize(wordSearchPtr)
    End Function

    'returns a specific character in the 2d vector (columns are y axis, rows are x axis)
    Public Function GetChar(col As Integer, row As Integer) As Char
        Return WordSearchGetChar(wordSearchPtr, col, row)
    End Function
End Class