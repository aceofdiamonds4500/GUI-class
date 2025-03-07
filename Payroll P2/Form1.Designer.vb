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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		PictureBox1 = New PictureBox()
		LabelHead = New Label()
		LabelSubHead = New Label()
		LabelText = New Label()
		TextField = New TextBox()
		BttnCompute = New Button()
		BttnClear = New Button()
		BttnExit = New Button()
		LabelFica = New Label()
		LabelFed = New Label()
		LabelState = New Label()
		LabelNetIncome = New Label()
		FICAText = New Label()
		FederalText = New Label()
		StateText = New Label()
		NetIncomeText = New Label()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.Anchor = AnchorStyles.Top
		PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
		PictureBox1.Location = New Point(-14, 0)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(420, 262)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 2
		PictureBox1.TabStop = False
		' 
		' LabelHead
		' 
		LabelHead.Anchor = AnchorStyles.Top
		LabelHead.AutoSize = True
		LabelHead.Font = New Font("Elephant", 28.0F)
		LabelHead.Location = New Point(417, 50)
		LabelHead.Name = "LabelHead"
		LabelHead.Size = New Size(371, 49)
		LabelHead.TabIndex = 1
		LabelHead.Text = "Payroll Calculator"
		' 
		' LabelSubHead
		' 
		LabelSubHead.Anchor = AnchorStyles.Top
		LabelSubHead.AutoSize = True
		LabelSubHead.Font = New Font("Elephant", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		LabelSubHead.Location = New Point(517, 139)
		LabelSubHead.Name = "LabelSubHead"
		LabelSubHead.Size = New Size(186, 76)
		LabelSubHead.TabIndex = 4
		LabelSubHead.Text = "Paycheck" & vbCrLf & "Calculation"
		LabelSubHead.TextAlign = ContentAlignment.TopCenter
		' 
		' LabelText
		' 
		LabelText.Anchor = AnchorStyles.Top
		LabelText.AutoSize = True
		LabelText.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		LabelText.Location = New Point(328, 275)
		LabelText.Name = "LabelText"
		LabelText.Size = New Size(170, 30)
		LabelText.TabIndex = 5
		LabelText.Text = "Enter Gross Pay:"
		' 
		' TextField
		' 
		TextField.Anchor = AnchorStyles.Top
		TextField.Location = New Point(360, 317)
		TextField.Name = "TextField"
		TextField.Size = New Size(100, 23)
		TextField.TabIndex = 6
		TextField.TextAlign = HorizontalAlignment.Center
		' 
		' BttnCompute
		' 
		BttnCompute.Anchor = AnchorStyles.Top
		BttnCompute.BackColor = SystemColors.MenuHighlight
		BttnCompute.FlatStyle = FlatStyle.Popup
		BttnCompute.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
		BttnCompute.ForeColor = SystemColors.Control
		BttnCompute.Location = New Point(149, 357)
		BttnCompute.Name = "BttnCompute"
		BttnCompute.Size = New Size(130, 44)
		BttnCompute.TabIndex = 7
		BttnCompute.Text = "Compute Taxes"
		BttnCompute.UseVisualStyleBackColor = False
		' 
		' BttnClear
		' 
		BttnClear.Anchor = AnchorStyles.Top
		BttnClear.BackColor = SystemColors.MenuHighlight
		BttnClear.FlatStyle = FlatStyle.Popup
		BttnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
		BttnClear.ForeColor = SystemColors.Control
		BttnClear.Location = New Point(344, 357)
		BttnClear.Name = "BttnClear"
		BttnClear.Size = New Size(135, 44)
		BttnClear.TabIndex = 8
		BttnClear.Text = "Clear"
		BttnClear.TextImageRelation = TextImageRelation.ImageBeforeText
		BttnClear.UseVisualStyleBackColor = False
		' 
		' BttnExit
		' 
		BttnExit.Anchor = AnchorStyles.Top
		BttnExit.BackColor = SystemColors.MenuHighlight
		BttnExit.FlatStyle = FlatStyle.Popup
		BttnExit.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
		BttnExit.ForeColor = SystemColors.Control
		BttnExit.Location = New Point(542, 357)
		BttnExit.Name = "BttnExit"
		BttnExit.Size = New Size(135, 44)
		BttnExit.TabIndex = 9
		BttnExit.Text = "Exit"
		BttnExit.UseVisualStyleBackColor = False
		' 
		' LabelFica
		' 
		LabelFica.AutoSize = True
		LabelFica.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		LabelFica.Location = New Point(149, 425)
		LabelFica.Name = "LabelFica"
		LabelFica.Size = New Size(52, 21)
		LabelFica.TabIndex = 10
		LabelFica.Text = "FICA: "
		' 
		' LabelFed
		' 
		LabelFed.AutoSize = True
		LabelFed.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		LabelFed.Location = New Point(344, 425)
		LabelFed.Name = "LabelFed"
		LabelFed.Size = New Size(104, 21)
		LabelFed.TabIndex = 11
		LabelFed.Text = "Federal Tax: "
		' 
		' LabelState
		' 
		LabelState.AutoSize = True
		LabelState.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		LabelState.Location = New Point(542, 425)
		LabelState.Name = "LabelState"
		LabelState.Size = New Size(83, 21)
		LabelState.TabIndex = 12
		LabelState.Text = "State Tax:"
		' 
		' LabelNetIncome
		' 
		LabelNetIncome.AutoSize = True
		LabelNetIncome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		LabelNetIncome.Location = New Point(218, 475)
		LabelNetIncome.Name = "LabelNetIncome"
		LabelNetIncome.Size = New Size(230, 30)
		LabelNetIncome.TabIndex = 13
		LabelNetIncome.Text = "Net Paycheck Income:"
		' 
		' FICAText
		' 
		FICAText.AutoSize = True
		FICAText.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		FICAText.Location = New Point(229, 425)
		FICAText.Name = "FICAText"
		FICAText.Size = New Size(50, 21)
		FICAText.TabIndex = 14
		FICAText.Text = "$0.00"
		' 
		' FederalText
		' 
		FederalText.AutoSize = True
		FederalText.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		FederalText.Location = New Point(448, 425)
		FederalText.Name = "FederalText"
		FederalText.Size = New Size(50, 21)
		FederalText.TabIndex = 15
		FederalText.Text = "$0.00"
		' 
		' StateText
		' 
		StateText.AutoSize = True
		StateText.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
		StateText.Location = New Point(635, 425)
		StateText.Name = "StateText"
		StateText.Size = New Size(50, 21)
		StateText.TabIndex = 16
		StateText.Text = "$0.00"
		' 
		' NetIncomeText
		' 
		NetIncomeText.AutoSize = True
		NetIncomeText.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
		NetIncomeText.Location = New Point(465, 475)
		NetIncomeText.Name = "NetIncomeText"
		NetIncomeText.Size = New Size(67, 30)
		NetIncomeText.TabIndex = 17
		NetIncomeText.Text = "$0.00"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.Control
		ClientSize = New Size(800, 531)
		Controls.Add(NetIncomeText)
		Controls.Add(StateText)
		Controls.Add(FederalText)
		Controls.Add(FICAText)
		Controls.Add(LabelNetIncome)
		Controls.Add(LabelState)
		Controls.Add(LabelFed)
		Controls.Add(LabelFica)
		Controls.Add(BttnExit)
		Controls.Add(BttnClear)
		Controls.Add(BttnCompute)
		Controls.Add(TextField)
		Controls.Add(LabelText)
		Controls.Add(LabelSubHead)
		Controls.Add(PictureBox1)
		Controls.Add(LabelHead)
		Name = "Form1"
		Text = "Payroll Every Two Weeks"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents ColorDialog1 As ColorDialog
	Friend WithEvents Label1 As Label
	Friend WithEvents LabelHead As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents LabelSubHead As Label
	Friend WithEvents LabelText As Label
	Friend WithEvents TextField As TextBox
	Friend WithEvents BttnCompute As Button
	Friend WithEvents BttnClear As Button
	Friend WithEvents BttnExit As Button
	Friend WithEvents LabelFica As Label
	Friend WithEvents LabelFed As Label
	Friend WithEvents LabelState As Label
	Friend WithEvents LabelNetIncome As Label
	Friend WithEvents FICAText As Label
	Friend WithEvents FederalText As Label
	Friend WithEvents StateText As Label
	Friend WithEvents NetIncomeText As Label

End Class
