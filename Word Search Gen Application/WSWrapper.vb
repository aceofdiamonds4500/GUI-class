Imports System
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Word
    Private wordPtr As IntPtr

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function CreateWord(inputWord As String) As IntPtr
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub DestroyWord(wordPtr As IntPtr)
    End Sub

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordToString(wordPtr As IntPtr) As IntPtr
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordGetLength(wordPtr As IntPtr) As Integer
    End Function

    Public Sub New(word As String)
        wordPtr = CreateWord(word)
        If wordPtr = IntPtr.Zero Then
            Throw New Exception("Failed to create Word object")
        End If
    End Sub
    Friend Sub New(existingPtr As IntPtr)
        wordPtr = existingPtr
        If wordPtr = IntPtr.Zero Then
            Throw New Exception("Invalid Word pointer")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If wordPtr <> IntPtr.Zero Then
            DestroyWord(wordPtr)
            wordPtr = IntPtr.Zero
        End If
        MyBase.Finalize()
    End Sub

    Public Function GetLength() As Integer
        Return WordGetLength(wordPtr)
    End Function

    Public Overrides Function ToString() As String
        Dim strPtr As IntPtr = WordToString(wordPtr)
        Dim result As String = Marshal.PtrToStringAnsi(strPtr)
        Return result
    End Function

    Friend ReadOnly Property Pointer() As IntPtr
        Get
            Return wordPtr
        End Get
    End Property
End Class

Public Class WordList
    Private wordListPtr As IntPtr

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function CreateWordList() As IntPtr
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub DestroyWordList(wordListPtr As IntPtr)
    End Sub

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub WordListAddWord(wordListPtr As IntPtr, wordPtr As IntPtr)
    End Sub

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListRemoveWord(wordListPtr As IntPtr, wordPtr As IntPtr) As Boolean
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListGetCount(wordListPtr As IntPtr) As Integer
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordListGetWordAt(wordListPtr As IntPtr, index As Integer) As IntPtr
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
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

    Public Sub AddWord(word As Word)
        WordListAddWord(wordListPtr, word.Pointer)
    End Sub

    Public Function RemoveWord(word As Word) As Boolean
        Return WordListRemoveWord(wordListPtr, word.Pointer)
    End Function
    Public ReadOnly Property Count As Integer
        Get
            Return WordListGetCount(wordListPtr)
        End Get
    End Property

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

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function CreateWordSearch(ySize As Integer, xSize As Integer) As IntPtr
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub DestroyWordSearch(wordSearchPtr As IntPtr)
    End Sub

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchAddWord(wordSearchPtr As IntPtr, word As String) As Boolean
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchToString(wordSearchPtr As IntPtr) As IntPtr
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Sub WordSearchWriteToFile(wordSearchPtr As IntPtr, wordListPtr As IntPtr, filename As String)
    End Sub

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchGetYSize(wordSearchPtr As IntPtr) As Integer
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchGetXSize(wordSearchPtr As IntPtr) As Integer
    End Function

    <DllImport("C:\Users\tacop\source\repos\GUI-class\Word Search Gen Application\WordDLL.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function WordSearchGetChar(wordSearchPtr As IntPtr, col As Integer, row As Integer) As Char
    End Function

    Public Sub New(ySize As Integer, xSize As Integer)
        wordSearchPtr = CreateWordSearch(ySize, xSize)
        If wordSearchPtr = IntPtr.Zero Then
            Throw New Exception("Failed to create WordSearch object")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If wordSearchPtr <> IntPtr.Zero Then
            DestroyWordSearch(wordSearchPtr)
            wordSearchPtr = IntPtr.Zero
        End If
        MyBase.Finalize()
    End Sub

    Public Function AddWord(word As String) As Boolean
        Return WordSearchAddWord(wordSearchPtr, word)
    End Function

    Public Overrides Function ToString() As String
        Dim strPtr As IntPtr = WordSearchToString(wordSearchPtr)
        Dim result As String = Marshal.PtrToStringAnsi(strPtr)
        Return result
    End Function

    Public Sub WriteToFile(wordList As WordList, filename As String)
        WordSearchWriteToFile(wordSearchPtr, wordList.Pointer, filename)
    End Sub

    Public Function GetYSize() As Integer
        Return WordSearchGetYSize(wordSearchPtr)
    End Function

    Public Function GetXSize() As Integer
        Return WordSearchGetXSize(wordSearchPtr)
    End Function

    Public Function GetChar(col As Integer, row As Integer) As Char
        Return WordSearchGetChar(wordSearchPtr, col, row)
    End Function
End Class