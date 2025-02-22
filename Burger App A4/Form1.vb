''' <summary>
''' Author: Nicholas Cieplensky
''' Project: Farm Burger Special Application
''' Class Names: frmBurgers
''' 
''' Description:
'''	This project allows the user to select either a prime beef or veggie burger.
''' Once the user does so, they will be prompted to confirm their option and to exit the window.
''' </summary>
Public Class frmBurgers

	'Makes sure that the user can only choose a burger upon opening the app.
	Private Sub frmBurgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		picPrime.Visible = False            'Set pictures as invisible
		picVeggie.Visible = False

		btnSelectMeal.Visible = False       'Select Meal
		btnExit.Visible = False             'Exit Window

		lblConfirmation.Visible = False     '"Enjoy your burger special"
	End Sub

	'Prime Beef button event
	'shows prime.jpg, makes veggie.jpg invisible
	Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
		picPrime.Visible = True             'Prime Beef picture shows
		picVeggie.Visible = False
		btnSelectMeal.Visible = True        'if either button is pressed the user can select their meal
	End Sub

	'Veggie button event
	'opposite of prime beef button
	Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
		picPrime.Visible = False
		picVeggie.Visible = True            'Veggie picture shows
		btnSelectMeal.Visible = True
	End Sub

	'Select Your Meal
	'Activates once the user has made a choice
	Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
		lblConfirmation.Visible = True      '"Enjoy" message is enable
		btnPrime.Enabled = False            'user cannot choose prime/veggie anymore
		btnVeggie.Enabled = False
		btnExit.Visible = True              'Exit button can be used now
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Close()                             'exits the window
	End Sub
End Class
