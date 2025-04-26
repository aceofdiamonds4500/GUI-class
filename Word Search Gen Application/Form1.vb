Imports System.DirectoryServices
Imports System.Runtime.Intrinsics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

''' <summary>
''' Project: Word Search Generator Application
''' Author: Nicholas Cieplensky
''' Description:
'''		This is my magnum opus: interoperability of C/C++ code into Visual Basic using a Dynamic-Link Library. It has many functionalities:
'''		- Buttons to remake, generate, and add words to a word search
'''		- Native functions to access, remove, and add words to a word list
'''		- Labels, a TextBox for adding words (and input validation), a ComboBox for viewing unadded words
'''		- Button greying to avoid bad input
'''		- Generating a word search writes it to a file in a readable/copy-able format
'''		I had to do heaps of research into invoking methods, translating C++ code to C code, and even having to re-learn pointers 
'''		for this specific project.
'''		
''' Quick Note: I had to change to this idea from the original capstone proposal I once did, because I figured this would be much easier
''' than designing all the windows necessary for the first project idea.
''' </summary>
Public Class Form1
	Inherits Form

	Private filename As String = "wordsearch.txt"

	Private wordSearch As WordSearch
	Private wordList As WordList
	'this stores words that are already added to the word search
	Private addedWords As New List(Of String)
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Makes a new Word Search, disables all buttons
		NewWSGen()
	End Sub

	'Waits until user changes text in box to allow input
	Private Sub txtWordToList_TextChanged(sender As Object, e As EventArgs) Handles txtWordToList.TextChanged
		btnWordAdd.Enabled = True
	End Sub

	'Enables the add/remove buttons when a new combobox item is selected
	Private Sub cbxWordList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxWordList.SelectedIndexChanged
		btnAddToWS.Enabled = True
		btnWordRemove.Enabled = True
	End Sub

	Private Sub btnWordAdd_Click(sender As Object, e As EventArgs) Handles btnWordAdd.Click
		Dim inpWord As String = txtWordToList.Text

		If InputValidate(inpWord) = False Then
			Return
		End If

		cbxWordList.Items.Add(inpWord)
		cbxWordList.SelectedIndex = 0

		txtWordToList.Text = ""
		txtWordToList.Focus()

		'Button management
		btnWordAdd.Enabled = False
		btnAddToWS.Enabled = True
		btnWordRemove.Enabled = True
	End Sub

	Private Sub btnNewWS_Click(sender As Object, e As EventArgs) Handles btnNewWS.Click
		Dim result As Boolean = NewWSChoice()

		If result = True Then
			NewWSGen()
			MessageBox.Show("Word search has been deleted.", "New Word Search")
		ElseIf False Then
			Return
		End If

	End Sub

	Private Sub btnAddToWS_Click(sender As Object, e As EventArgs) Handles btnAddToWS.Click
		Dim wordSelect As Integer = cbxWordList.SelectedIndex
		Dim wordOnList As String = wordList.GetWordAt(wordSelect).ToString
		'debug
		'lblHeader.Text = wordList.GetWordAt(wordSelect).ToString()

		'Makes sure the user can't click the same button twice to add duplicates
		For Each word As String In addedWords
			If wordOnList = word Then
				MessageBox.Show("You cannot add the same word twice!", "Invalid Input")
				Return
			End If
		Next

		If wordSearch.AddWord(wordOnList) = True Then
			MessageBox.Show("Word successfully written to word search!", "Word Written Succesfully")

			'adds a word to the list of already added words
			addedWords.Add(wordOnList)

			If cbxWordList.Text = "" Then
				'if the selected index suddenly becomes blank, this catches that
				btnAddToWS.Enabled = False
				btnWordRemove.Enabled = False
			End If

			btnNewWS.Enabled = True
			btnGenerate.Enabled = True
		Else
			MessageBox.Show("Word failed to write to word search! (Try two or three more times)", "Failed to Write")
		End If
	End Sub

	Private Sub btnWordRemove_Click(sender As Object, e As EventArgs) Handles btnWordRemove.Click
		Dim wordSelect As Integer = cbxWordList.SelectedIndex
		Dim wordOnList As Word = wordList.GetWordAt(wordSelect)

		wordList.RemoveWord(wordOnList)
		cbxWordList.Items.RemoveAt(wordSelect)

		btnAddToWS.Enabled = False
		btnWordRemove.Enabled = False
	End Sub

	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
		wordSearch.WriteToFile(wordList, filename)
		MessageBox.Show("Word Search written to wordsearch.txt!", "Success")

		NewWSGen()
	End Sub

	'Will return False if an input is invalid, but will create a Word object and return True if valid
	'valid input: must have a letter, must be < 15 letters (apostrophes and other characters don't count
	Private Function InputValidate(inpWord As String)
		Dim word As Word
		Dim wordFilter As String = ""
		Dim counter As Integer = 0

		If inpWord.Length > 15 Then
			MessageBox.Show("Word length is too long for the word search.", "Invalid Input")
			Return False
		ElseIf inpWord = "" Then
			'will probably never reach this
			'^ leaving this here because LMAO i figured out how to break it
			MessageBox.Show("Please enter a value.", "Invalid Input")
			Return False
		End If

		Do While counter < inpWord.Length
			If Char.IsLetter(GetChar(inpWord, counter + 1)) Then
				wordFilter += UCase(GetChar(inpWord, counter + 1))
			End If
			counter += 1
		Loop

		'This will be the actual word that gets inserted into a WordList. If someone enters "1111" this will be checked
		'Because all characters from inpWord go from "1test word" to "TESTWORD"
		If wordFilter = "" Then
			MessageBox.Show("Word failed to validate! (Must contain any letters)", "Word Failed")
			Return False
		End If

		For i = 0 To cbxWordList.Items.Count - 1
			If wordFilter = wordList.GetWordAt(i).ToString Then
				MessageBox.Show("No duplicate words allowed!", "Invalid Input")
				Return False
			End If
		Next i

		word = New Word(wordFilter)
		wordList.AddWord(word)

		Return True
	End Function

	Private Function NewWSChoice()
		Dim result As DialogResult = MessageBox.Show("Write a new Word Search?", "Confirm Choice", MessageBoxButtons.YesNo)

		If result = DialogResult.Yes Then
			Return True
		ElseIf result = DialogResult.No Then
			Return False
		End If

		Return False
	End Function

	Private Sub NewWSGen()
		wordSearch = New WordSearch(15, 15)
		wordList = New WordList()

		For i = 0 To cbxWordList.Items.Count - 1
			cbxWordList.Items.RemoveAt(0)
		Next i
		addedWords.Clear()

		'All buttons disabled until a word is typed/added to list/inserted to word search
		btnNewWS.Enabled = False
		btnGenerate.Enabled = False
		btnAddToWS.Enabled = False
		btnWordRemove.Enabled = False
		btnWordAdd.Enabled = False
	End Sub

End Class
