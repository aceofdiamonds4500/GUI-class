Imports System.IO.Enumeration

'''<summary>
''' Author: Nicholas Cieplensky
''' Project: Smart Home Electric Savings Application
''' Description:
'''		This application reads from a file specifically formatted to display a month then the savings of that month in the next line.
'''		It calculates the average of all savings, the savings of a selected month, and the year's best month of savings.
'''</summary>
Public Class Form1
	'Replace this filename with "D:\savings.txt"
	Const filename = "C:\Users\tacop\source\repos\GUI-class\Smart Home Savings A7\Resources\savings.txt"

	'Global month and prices for simplicity
	Const upperBound As Integer = 12    'ALWAYS expects 12 months.
	Dim _strMonth(upperBound) As String
	Dim _strPrice(upperBound) As String

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblMonthStat.Text = ""
		lblAvgStat.Text = ""
		lblMostSavedStat.Text = ""

		readFile(filename)

		'Always starts on January, text input is disabled
		boxMonths.SelectedIndex = 0
	End Sub

	'Always reads file and fills combobox, closes app if file isn't found.
	Private Sub readFile(filename As String)
		Dim objReader As IO.StreamReader
		Dim counter As Integer = 0

		If IO.File.Exists(filename) = True Then
			objReader = IO.File.OpenText(filename)
		Else
			MsgBox("File not available (did you do absolute file path?)",, "Error")
			Me.Close()
		End If

		'counter < upperBound is ESSENTIAL. Prevents user from inputting more lines than they should
		Do While objReader.Peek <> -1 And counter < upperBound
			_strMonth(counter) = objReader.ReadLine()
			boxMonths.Items.Add(_strMonth(counter))
			_strPrice(counter) = objReader.ReadLine()   'Admittedly this relies on the user putting the right text on each line
			counter += 1
		Loop

		objReader.Close()
	End Sub

	'Sorts through the array of prices and determines the largest number, returns the index of said number
	Private Function bestSavings()
		Dim cmpTemp As Double = _strPrice(0)
		Dim biggest As Integer = 0
		Dim counter As Integer = 0

		Do While counter < upperBound - 1
			If cmpTemp < _strPrice(counter + 1) Then
				cmpTemp = _strPrice(counter + 1)
				biggest = counter + 1
			End If
			counter += 1
		Loop

		Return biggest
	End Function

	'Returns the average of each item in the _strPrice() array
	Private Function avgSavings()
		Dim total As Double = 0.0
		Dim counter As Integer = 0

		Do While counter < upperBound
			total += _strPrice(counter)
			counter += 1
		Loop

		Return total / upperBound
	End Function

	'On-click action to control when the math is done and the text is displayed
	Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
		Dim monthSelect As Integer = boxMonths.SelectedIndex
		Dim average As Double = avgSavings()

		lblMonthStat.Text = "The electric savings for " + _strMonth(monthSelect) + " is $" + _strPrice(monthSelect)
		lblAvgStat.Text = "The average montly savings: $" + average.ToString("#.##")
		lblMostSavedStat.Text = _strMonth(bestSavings()) + " had the most significant monthly savings"
	End Sub
End Class
