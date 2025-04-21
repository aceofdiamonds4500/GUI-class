Imports System.DirectoryServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
	Inherits Form

	Private filename As String = "wordsearch.txt"

	Private wordSearch As WordSearch
	Private wordList As WordList
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Create a 15x15 word search
		wordSearch = New WordSearch(15, 15)
		wordList = New WordList()

		btnNewWS.Enabled = False
		btnGenerate.Enabled = False
		btnAddToWS.Enabled = False
		btnWordRemove.Enabled = False
		btnWordAdd.Enabled = False
	End Sub

	'Waits until user changes text in box to allow input
	Private Sub txtWordToList_TextChanged(sender As Object, e As EventArgs) Handles txtWordToList.TextChanged
		btnWordAdd.Enabled = True
	End Sub

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

		If wordFilter = "" Then
			MessageBox.Show("Word failed to validate! (Must contain any letters)", "Word Failed")
			Return False
		End If

		word = New Word(wordFilter)
		wordList.AddWord(word)

		Return True
	End Function
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
		Dim result As DialogResult = MessageBox.Show("Write a new Word Search?", "Confirm Choice", MessageBoxButtons.YesNo)

		If result = DialogResult.Yes Then
			wordSearch = New WordSearch(15, 15)
			wordList = New WordList()

			For i = 0 To cbxWordList.Items.Count - 1
				cbxWordList.Items.RemoveAt(0)
			Next i
			btnAddToWS.Enabled = False
			btnWordRemove.Enabled = False
			btnGenerate.Enabled = False
			MessageBox.Show("Word search has been deleted.", "New Word Search")

		ElseIf result = DialogResult.No Then
			Return
		End If

	End Sub

	Private Sub btnAddToWS_Click(sender As Object, e As EventArgs) Handles btnAddToWS.Click
		Dim wordSelect As Integer = cbxWordList.SelectedIndex
		Dim wordOnList As String = wordList.GetWordAt(wordSelect).ToString
		'debug
		'lblHeader.Text = wordList.GetWordAt(wordSelect).ToString()

		If wordSearch.AddWord(wordOnList) = True Then
			MessageBox.Show("Word successfully written to word search!", "Word Written Succesfully")
			cbxWordList.Items.Remove(wordSelect)

			'prevents blank input
			btnAddToWS.Enabled = False
			btnWordRemove.Enabled = False

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
		btnNewWS.PerformClick()

		'copy pasted from btnNewWS_Click
		wordSearch = New WordSearch(15, 15)
		wordList = New WordList()

		For i = 0 To cbxWordList.Items.Count - 1
			cbxWordList.Items.RemoveAt(0)
		Next i
		btnAddToWS.Enabled = False
		btnWordRemove.Enabled = False
		btnGenerate.Enabled = False

		MessageBox.Show("Word Search written to '{filename}'!", "Success")
	End Sub
End Class
