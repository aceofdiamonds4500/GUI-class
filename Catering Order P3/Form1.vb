''' <summary>
''' Author: Nicholas Cieplensky
''' Project: Catering Order Application
''' Description:
'''		This project creates an order for a platter which can be paid for in-store or before arrival.
'''		The user can also add loyalty points - 10 points gets 5% of the meal's total price off.
''' </summary>
Public Class Form1
	'costs for each item
	Private Const PERCENT_OFF = 0.05
	Private Const GOURMET = 49.99
	Private Const PINWHEEL = 59.99
	Private Const VEGGIE = 29.99
	Private Const SAUS_CHEESE = 49.99
	Private Const FRUIT = 29.99

	'globals
	Private payStr = ""
	Private foodPrice = 0.00
	Private foodName = ""

	'On start up, radio buttons are wiped, txtLoyaltyInp is set to "0", and final output is wiped
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnClear.PerformClick()
		'TODO: figure out another solution to weird on-startup veggie button
		rdoVeggie.Checked = False
	End Sub

	'Returns the total price of a platter after loyalty points are added
	Private Function calcPrice(itemPrice As Double, loyaltyCt As Integer)
		Dim discountAmt = Convert.ToInt32(loyaltyCt / 10) 'only every 10 points grants 5% off
		Dim totalPrice = itemPrice - ((PERCENT_OFF * discountAmt) * itemPrice)

		Return totalPrice
	End Function

	'Converts the text field of lblTotal to output the total price along with pay type and how many loyalty points they used
	Private Sub outputPrice(totalPrice As Double, loyalty As Integer, payType As String)
		Dim strLoyalty = loyalty.ToString()

		Dim strTotal = totalPrice.ToString("#.##")

		lblTotal.Text = "Your order " + foodName + " costs $" + strTotal + " using " + payType + " after a discount of " + strLoyalty + " loyalty points."
	End Sub

	'Returns False when an item isn't selected yet
	Private Function checkMealSelection()
		If rdoGourmet.Checked Then
			foodPrice = GOURMET
			foodName = "Gourmet Platter"
		ElseIf rdoPinwheel.Checked Then
			foodPrice = PINWHEEL
			foodName = "Pinwheel Wraps Platter"
		ElseIf rdoVeggie.Checked Then
			foodPrice = VEGGIE
			foodName = "Veggie Platter"
		ElseIf rdoSausCheese.Checked Then
			foodPrice = SAUS_CHEESE
			foodName = "Sausage and Cheese Platter"
		ElseIf rdoFruit.Checked Then
			foodPrice = FRUIT
			foodName = "Fruit Platter"
		Else
			'none selected
			MessageBox.Show("Please select a meal.", "Selection Required")
			Return False
		End If
		Return True
	End Function

	'Returns False when an item isn't selected yet
	Private Function checkPaySelection()
		If rdoPayPre.Checked Then
			payStr = "Pre-Pay"
		ElseIf rdoPayPickup.Checked Then
			payStr = "Pay upon Pickup"
		Else
			'none selected
			MessageBox.Show("Please select a payment option.", "Selection Required")
			Return False
		End If
		Return True
	End Function

	'Controls whether the user's radio buttons and their loyalty point amount are valid
	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		If Not IsNumeric(txtLoyaltyInp.Text) Then
			'input not a number
			MessageBox.Show("Input must be a numerical value.", "Invalid Input")
		Else
			'valid input
			Dim input As Integer = txtLoyaltyInp.Text

			If checkMealSelection() And checkPaySelection() Then
				Dim totalPrice = calcPrice(foodPrice, input)
				'Total price cannot be zeroed out
				If totalPrice <= 0 Then
					MessageBox.Show("Too many loyalty points! Enter less to complete order.", "Loyalty Point Limit Exceeded")
				Else
					outputPrice(totalPrice, input, payStr)
				End If
			End If
		End If
	End Sub

	'User can reset all fields at any given moment
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtLoyaltyInp.Text = "0"    'zero is a good, readable constant to set and I don't have to go out of my way to assume any blank input
		txtLoyaltyInp.Focus()
		lblTotal.Text = ""
		'Panel1 radio buttons made False
		For Each ctrl As Control In Panel1.Controls
			If TypeOf ctrl Is RadioButton Then
				DirectCast(ctrl, RadioButton).Checked = False
			End If
		Next
		'Panel2 radio buttons made False
		For Each ctrl As Control In Panel2.Controls
			If TypeOf ctrl Is RadioButton Then
				DirectCast(ctrl, RadioButton).Checked = False
			End If
		Next
	End Sub

End Class
