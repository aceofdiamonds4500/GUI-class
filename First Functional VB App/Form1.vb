''' <summary>
''' Name:	 Nicholas Cieplensky
''' Project: Assignment P1
''' Date:	 February 13, 2025
''' Description: This Windows application is made to show what buttons can do on-click
''' and tells the user to click a button to have a label appear and show the French
''' version of the number display.
''' </summary>

'' Main Window
Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label3.Visible = False  '' french is invisible on startup
	End Sub

	'' ------------- Buttons 1-5
	Private Sub btnOne(sender As Object, e As EventArgs) Handles Button1.Click
		Label3.Text = "Un"      '' text on label is set to relevant button (1 for un, etc.)
		Label3.Visible = True   '' label box is visible after clicking box
	End Sub

	Private Sub btnTwo(sender As Object, e As EventArgs) Handles Button2.Click
		Label3.Text = "Deux"
		Label3.Visible = True
	End Sub

	Private Sub btnThree(sender As Object, e As EventArgs) Handles Button3.Click
		Label3.Text = "Trois"
		Label3.Visible = True
	End Sub

	Private Sub btnFour(sender As Object, e As EventArgs) Handles Button4.Click
		Label3.Text = "Quatre"
		Label3.Visible = True
	End Sub

	Private Sub btnFive(sender As Object, e As EventArgs) Handles Button5.Click
		Label3.Text = "Cinq"
		Label3.Visible = True
	End Sub
	'' ------------- Buttons 1-5

	'' Has one function to remove the french label on click
	Private Sub lblFrench(sender As Object, e As EventArgs) Handles Label3.Click
		Label3.Visible = False
	End Sub

	Private Sub btnExit(sender As Object, e As EventArgs) Handles Button6.Click
		Me.Close() '' closes the window
	End Sub
End Class
