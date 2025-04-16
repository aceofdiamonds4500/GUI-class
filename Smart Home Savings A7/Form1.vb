Public Class Form1
	Const filename = "C:\Users\tacop\source\repos\GUI-class\Smart Home Savings A7\Resources\savings.txt"
	Const upperBound As Integer = 12

	Private Function readFile(filename As String)
		Dim objReader As IO.StreamReader
		Dim _strMonth(upperBound) As String
		Dim _strPrice(upperBound) As String
		Dim counter As Integer = 0

		If IO.File.Exists(filename) = True Then
			objReader = IO.File.OpenText(filename)
		Else
			MsgBox("File not available",, "Error")
			Close()
		End If

		Do While objReader.Peek <> -1 And counter < upperBound
			_strMonth(counter) = objReader.ReadLine()
			_strPrice(counter) = objReader.ReadLine()
			counter += 1
		Loop


		objReader.Close()
		Return _strMonth(1)
	End Function

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
		Label1.Text = readFile(filename)
	End Sub
End Class
