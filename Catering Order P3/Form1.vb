Public Class Form1
	'costs for each item
	Private Const PERCENT_OFF = 0.05
	Private Const GOURMET = 49.99
	Private Const PINWHEEL = 59.99
	Private Const VEGGIE = 29.99
	Private Const SAUS_CHEESE = 49.99
	Private Const FRUIT = 29.99

	'variables for various strings
	'Private totalPay = 0.0
	Private payStr = ""
	Private foodPrice = 0.00
	Private foodName = ""

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		btnClear.PerformClick()

	End Sub

	Private Function calcPrice(itemPrice As Double, loyaltyCt As Integer)
		Dim pointSub = Convert.ToInt32(loyaltyCt / 10)
		Dim totalPrice = itemPrice - ((PERCENT_OFF * pointSub) * itemPrice)

		If totalPrice < 0.0 Then
			totalPrice = 0.00
		End If

		Return totalPrice
	End Function

	Private Sub outputPrice(totalPrice As Double, loyalty As Integer, payType As String)
		Dim strLoyalty = loyalty.ToString()

		Dim strTotal = totalPrice.ToString("#.##")

		lblTotal.Text = "Your order " + foodName + " costs $" + strTotal + " using " + payType + " after a discount of " + strLoyalty + " loyalty points."
	End Sub

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

	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		If Not IsNumeric(txtLoyaltyInp.Text) Then
			'input not a number
			MessageBox.Show("Input must be a numerical value.", "Invalid Input")
		Else
			'valid input
			Dim input As Integer = txtLoyaltyInp.Text

			If checkMealSelection() And checkPaySelection() Then
				Dim totalPrice = calcPrice(foodPrice, input)
				outputPrice(totalPrice, input, payStr)
			End If
		End If
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		txtLoyaltyInp.Text = "0"
		txtLoyaltyInp.Focus()
		lblTotal.Text = ""
		For Each ctrl As Control In Panel1.Controls
			If TypeOf ctrl Is RadioButton Then
				DirectCast(ctrl, RadioButton).Checked = False
			End If
		Next
		For Each ctrl As Control In Panel2.Controls
			If TypeOf ctrl Is RadioButton Then
				DirectCast(ctrl, RadioButton).Checked = False
			End If
		Next
	End Sub
End Class
