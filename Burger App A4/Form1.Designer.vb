<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBurgers
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBurgers))
		picPrime = New PictureBox()
		picVeggie = New PictureBox()
		btnPrime = New Button()
		btnVeggie = New Button()
		lblInstructions = New Label()
		lblConfirmation = New Label()
		btnSelectMeal = New Button()
		btnExit = New Button()
		lblHeading = New Label()
		CType(picPrime, ComponentModel.ISupportInitialize).BeginInit()
		CType(picVeggie, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' picPrime
		' 
		picPrime.Anchor = AnchorStyles.Top
		picPrime.Image = CType(resources.GetObject("picPrime.Image"), Image)
		picPrime.Location = New Point(75, 86)
		picPrime.Name = "picPrime"
		picPrime.Size = New Size(260, 250)
		picPrime.SizeMode = PictureBoxSizeMode.Zoom
		picPrime.TabIndex = 0
		picPrime.TabStop = False
		' 
		' picVeggie
		' 
		picVeggie.Anchor = AnchorStyles.Top
		picVeggie.Image = CType(resources.GetObject("picVeggie.Image"), Image)
		picVeggie.Location = New Point(429, 86)
		picVeggie.Name = "picVeggie"
		picVeggie.Size = New Size(260, 250)
		picVeggie.SizeMode = PictureBoxSizeMode.Zoom
		picVeggie.TabIndex = 1
		picVeggie.TabStop = False
		' 
		' btnPrime
		' 
		btnPrime.Anchor = AnchorStyles.Top
		btnPrime.Location = New Point(137, 362)
		btnPrime.Name = "btnPrime"
		btnPrime.Size = New Size(128, 35)
		btnPrime.TabIndex = 2
		btnPrime.Text = "Prime Beef"
		btnPrime.UseVisualStyleBackColor = True
		' 
		' btnVeggie
		' 
		btnVeggie.Anchor = AnchorStyles.Top
		btnVeggie.Location = New Point(498, 362)
		btnVeggie.Name = "btnVeggie"
		btnVeggie.Size = New Size(128, 35)
		btnVeggie.TabIndex = 3
		btnVeggie.Text = "Veggie"
		btnVeggie.UseVisualStyleBackColor = True
		' 
		' lblInstructions
		' 
		lblInstructions.Anchor = AnchorStyles.Top
		lblInstructions.AutoSize = True
		lblInstructions.Font = New Font("Tahoma", 9.0F)
		lblInstructions.Location = New Point(230, 414)
		lblInstructions.Name = "lblInstructions"
		lblInstructions.Size = New Size(312, 14)
		lblInstructions.TabIndex = 4
		lblInstructions.Text = "Choose a burger and then click the Select Meal button."
		' 
		' lblConfirmation
		' 
		lblConfirmation.Anchor = AnchorStyles.Top
		lblConfirmation.AutoSize = True
		lblConfirmation.Font = New Font("Tahoma", 9.0F)
		lblConfirmation.Location = New Point(307, 446)
		lblConfirmation.Name = "lblConfirmation"
		lblConfirmation.Size = New Size(148, 14)
		lblConfirmation.TabIndex = 5
		lblConfirmation.Text = "Enjoy your burger special."
		' 
		' btnSelectMeal
		' 
		btnSelectMeal.Anchor = AnchorStyles.Top
		btnSelectMeal.Location = New Point(318, 362)
		btnSelectMeal.Name = "btnSelectMeal"
		btnSelectMeal.Size = New Size(128, 35)
		btnSelectMeal.TabIndex = 6
		btnSelectMeal.Text = "Select Meal"
		btnSelectMeal.UseVisualStyleBackColor = True
		' 
		' btnExit
		' 
		btnExit.Anchor = AnchorStyles.Top
		btnExit.Location = New Point(318, 487)
		btnExit.Name = "btnExit"
		btnExit.Size = New Size(128, 35)
		btnExit.TabIndex = 7
		btnExit.Text = "Exit Window"
		btnExit.UseVisualStyleBackColor = True
		' 
		' lblHeading
		' 
		lblHeading.Anchor = AnchorStyles.Top
		lblHeading.AutoSize = True
		lblHeading.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeading.Location = New Point(276, 27)
		lblHeading.Name = "lblHeading"
		lblHeading.Size = New Size(233, 25)
		lblHeading.TabIndex = 8
		lblHeading.Text = "Farm Burger Specials"
		' 
		' frmBurgers
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(784, 551)
		Controls.Add(lblHeading)
		Controls.Add(btnExit)
		Controls.Add(btnSelectMeal)
		Controls.Add(lblConfirmation)
		Controls.Add(lblInstructions)
		Controls.Add(btnVeggie)
		Controls.Add(btnPrime)
		Controls.Add(picVeggie)
		Controls.Add(picPrime)
		Name = "frmBurgers"
		Text = "Burger Specials"
		CType(picPrime, ComponentModel.ISupportInitialize).EndInit()
		CType(picVeggie, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents picPrime As PictureBox
	Friend WithEvents picVeggie As PictureBox
	Friend WithEvents btnPrime As Button
	Friend WithEvents btnVeggie As Button
	Friend WithEvents lblInstructions As Label
	Friend WithEvents lblConfirmation As Label
	Friend WithEvents btnSelectMeal As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents lblHeading As Label

End Class