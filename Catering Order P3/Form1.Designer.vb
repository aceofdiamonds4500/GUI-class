<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		BannerImg = New PictureBox()
		lblHeader = New Label()
		lblSubHeader = New Label()
		rdoGourmet = New RadioButton()
		rdoPinwheel = New RadioButton()
		Panel1 = New Panel()
		rdoFruit = New RadioButton()
		rdoSausCheese = New RadioButton()
		rdoVeggie = New RadioButton()
		Panel2 = New Panel()
		rdoPayPre = New RadioButton()
		rdoPayPickup = New RadioButton()
		lblTotal = New Label()
		lblLoyalty = New Label()
		txtLoyaltyInp = New TextBox()
		btnCalculate = New Button()
		btnClear = New Button()
		CType(BannerImg, ComponentModel.ISupportInitialize).BeginInit()
		Panel1.SuspendLayout()
		Panel2.SuspendLayout()
		SuspendLayout()
		' 
		' BannerImg
		' 
		BannerImg.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		BannerImg.Image = My.Resources.Resources.platter
		BannerImg.Location = New Point(450, 19)
		BannerImg.Name = "BannerImg"
		BannerImg.Size = New Size(323, 230)
		BannerImg.SizeMode = PictureBoxSizeMode.StretchImage
		BannerImg.TabIndex = 0
		BannerImg.TabStop = False
		' 
		' lblHeader
		' 
		lblHeader.AutoSize = True
		lblHeader.Font = New Font("Century Schoolbook", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblHeader.Location = New Point(69, 19)
		lblHeader.Name = "lblHeader"
		lblHeader.Size = New Size(165, 37)
		lblHeader.TabIndex = 1
		lblHeader.Text = "Catering"
		' 
		' lblSubHeader
		' 
		lblSubHeader.AutoSize = True
		lblSubHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblSubHeader.Location = New Point(69, 56)
		lblSubHeader.Name = "lblSubHeader"
		lblSubHeader.Size = New Size(106, 25)
		lblSubHeader.TabIndex = 2
		lblSubHeader.Text = "Star Market"
		' 
		' rdoGourmet
		' 
		rdoGourmet.AutoSize = True
		rdoGourmet.FlatStyle = FlatStyle.System
		rdoGourmet.Font = New Font("Courier New", 9.75F)
		rdoGourmet.Location = New Point(13, 14)
		rdoGourmet.Name = "rdoGourmet"
		rdoGourmet.Size = New Size(247, 21)
		rdoGourmet.TabIndex = 3
		rdoGourmet.TabStop = True
		rdoGourmet.Text = "Gourmet Cheese       $49.99"
		rdoGourmet.UseVisualStyleBackColor = True
		' 
		' rdoPinwheel
		' 
		rdoPinwheel.AutoSize = True
		rdoPinwheel.Font = New Font("Courier New", 9.75F)
		rdoPinwheel.Location = New Point(13, 39)
		rdoPinwheel.Name = "rdoPinwheel"
		rdoPinwheel.Size = New Size(241, 20)
		rdoPinwheel.TabIndex = 4
		rdoPinwheel.TabStop = True
		rdoPinwheel.Text = "Pinwheel Wraps       $59.99"
		rdoPinwheel.UseVisualStyleBackColor = True
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Panel1.Controls.Add(rdoFruit)
		Panel1.Controls.Add(rdoSausCheese)
		Panel1.Controls.Add(rdoVeggie)
		Panel1.Controls.Add(rdoGourmet)
		Panel1.Controls.Add(rdoPinwheel)
		Panel1.Location = New Point(34, 94)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(273, 146)
		Panel1.TabIndex = 5
		' 
		' rdoFruit
		' 
		rdoFruit.AutoSize = True
		rdoFruit.Font = New Font("Courier New", 9.75F)
		rdoFruit.Location = New Point(13, 114)
		rdoFruit.Name = "rdoFruit"
		rdoFruit.Size = New Size(241, 20)
		rdoFruit.TabIndex = 5
		rdoFruit.TabStop = True
		rdoFruit.Text = "Fruit                $29.99"
		rdoFruit.UseVisualStyleBackColor = True
		' 
		' rdoSausCheese
		' 
		rdoSausCheese.AutoSize = True
		rdoSausCheese.Font = New Font("Courier New", 9.75F)
		rdoSausCheese.Location = New Point(13, 89)
		rdoSausCheese.Name = "rdoSausCheese"
		rdoSausCheese.Size = New Size(241, 20)
		rdoSausCheese.TabIndex = 4
		rdoSausCheese.TabStop = True
		rdoSausCheese.Text = "Sausage and Cheese   $49.99"
		rdoSausCheese.UseVisualStyleBackColor = True
		' 
		' rdoVeggie
		' 
		rdoVeggie.AutoSize = True
		rdoVeggie.Font = New Font("Courier New", 9.75F)
		rdoVeggie.Location = New Point(13, 64)
		rdoVeggie.Name = "rdoVeggie"
		rdoVeggie.Size = New Size(241, 20)
		rdoVeggie.TabIndex = 3
		rdoVeggie.TabStop = True
		rdoVeggie.Text = "Veggie               $29.99"
		rdoVeggie.UseVisualStyleBackColor = True
		' 
		' Panel2
		' 
		Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
		Panel2.Controls.Add(rdoPayPre)
		Panel2.Controls.Add(rdoPayPickup)
		Panel2.Location = New Point(79, 267)
		Panel2.Name = "Panel2"
		Panel2.Size = New Size(187, 72)
		Panel2.TabIndex = 6
		' 
		' rdoPayPre
		' 
		rdoPayPre.AutoSize = True
		rdoPayPre.Font = New Font("Courier New", 9.75F)
		rdoPayPre.Location = New Point(12, 12)
		rdoPayPre.Name = "rdoPayPre"
		rdoPayPre.Size = New Size(81, 20)
		rdoPayPre.TabIndex = 6
		rdoPayPre.TabStop = True
		rdoPayPre.Text = "Pre-Pay"
		rdoPayPre.UseVisualStyleBackColor = True
		' 
		' rdoPayPickup
		' 
		rdoPayPickup.AutoSize = True
		rdoPayPickup.Font = New Font("Courier New", 9.75F)
		rdoPayPickup.Location = New Point(12, 37)
		rdoPayPickup.Name = "rdoPayPickup"
		rdoPayPickup.Size = New Size(145, 20)
		rdoPayPickup.TabIndex = 7
		rdoPayPickup.TabStop = True
		rdoPayPickup.Text = "Pay upon Pickup"
		rdoPayPickup.UseVisualStyleBackColor = True
		' 
		' lblTotal
		' 
		lblTotal.Anchor = AnchorStyles.Top
		lblTotal.AutoSize = True
		lblTotal.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTotal.Location = New Point(69, 373)
		lblTotal.Name = "lblTotal"
		lblTotal.Size = New Size(86, 20)
		lblTotal.TabIndex = 7
		lblTotal.Text = "Please Pay:"
		lblTotal.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblLoyalty
		' 
		lblLoyalty.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		lblLoyalty.AutoSize = True
		lblLoyalty.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
		lblLoyalty.Location = New Point(507, 274)
		lblLoyalty.Name = "lblLoyalty"
		lblLoyalty.Size = New Size(136, 25)
		lblLoyalty.TabIndex = 8
		lblLoyalty.Text = "Loyalty Points"
		' 
		' txtLoyaltyInp
		' 
		txtLoyaltyInp.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		txtLoyaltyInp.Location = New Point(649, 276)
		txtLoyaltyInp.Name = "txtLoyaltyInp"
		txtLoyaltyInp.Size = New Size(63, 23)
		txtLoyaltyInp.TabIndex = 9
		txtLoyaltyInp.TextAlign = HorizontalAlignment.Center
		' 
		' btnCalculate
		' 
		btnCalculate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		btnCalculate.FlatStyle = FlatStyle.Flat
		btnCalculate.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
		btnCalculate.Location = New Point(450, 326)
		btnCalculate.Name = "btnCalculate"
		btnCalculate.Size = New Size(113, 46)
		btnCalculate.TabIndex = 10
		btnCalculate.Text = "Calculate"
		btnCalculate.UseVisualStyleBackColor = True
		' 
		' btnClear
		' 
		btnClear.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		btnClear.FlatStyle = FlatStyle.Flat
		btnClear.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
		btnClear.Location = New Point(660, 326)
		btnClear.Name = "btnClear"
		btnClear.Size = New Size(113, 45)
		btnClear.TabIndex = 11
		btnClear.Text = "Clear"
		btnClear.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
		ClientSize = New Size(800, 450)
		Controls.Add(btnClear)
		Controls.Add(btnCalculate)
		Controls.Add(txtLoyaltyInp)
		Controls.Add(lblLoyalty)
		Controls.Add(lblTotal)
		Controls.Add(Panel2)
		Controls.Add(Panel1)
		Controls.Add(lblSubHeader)
		Controls.Add(lblHeader)
		Controls.Add(BannerImg)
		Name = "Form1"
		Text = "Catering"
		CType(BannerImg, ComponentModel.ISupportInitialize).EndInit()
		Panel1.ResumeLayout(False)
		Panel1.PerformLayout()
		Panel2.ResumeLayout(False)
		Panel2.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents BannerImg As PictureBox
	Friend WithEvents lblHeader As Label
	Friend WithEvents lblSubHeader As Label
	Friend WithEvents rdoGourmet As RadioButton
	Friend WithEvents rdoPinwheel As RadioButton
	Friend WithEvents Panel1 As Panel
	Friend WithEvents rdoVeggie As RadioButton
	Friend WithEvents Panel2 As Panel
	Friend WithEvents rdoSausCheese As RadioButton
	Friend WithEvents rdoFruit As RadioButton
	Friend WithEvents rdoPayPre As RadioButton
	Friend WithEvents rdoPayPickup As RadioButton
	Friend WithEvents lblTotal As Label
	Friend WithEvents lblLoyalty As Label
	Friend WithEvents txtLoyaltyInp As TextBox
	Friend WithEvents btnCalculate As Button
	Friend WithEvents btnClear As Button

End Class
