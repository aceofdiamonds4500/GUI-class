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
		LblHeader = New Label()
		LblPrompt = New Label()
		TxtInput = New TextBox()
		GrpRadios = New GroupBox()
		RadMToIn = New RadioButton()
		RadInToM = New RadioButton()
		PicBuilding = New PictureBox()
		BtnConvert = New Button()
		BtnClear = New Button()
		BtnExit = New Button()
		LblOutput = New Label()
		GrpRadios.SuspendLayout()
		CType(PicBuilding, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' LblHeader
		' 
		LblHeader.Anchor = AnchorStyles.Top
		LblHeader.AutoSize = True
		LblHeader.Location = New Point(368, 44)
		LblHeader.Name = "LblHeader"
		LblHeader.Size = New Size(61, 15)
		LblHeader.TabIndex = 0
		LblHeader.Text = "LblHeader"
		' 
		' LblPrompt
		' 
		LblPrompt.Anchor = AnchorStyles.Top
		LblPrompt.AutoSize = True
		LblPrompt.Location = New Point(333, 111)
		LblPrompt.Name = "LblPrompt"
		LblPrompt.Size = New Size(63, 15)
		LblPrompt.TabIndex = 1
		LblPrompt.Text = "LblPrompt"
		' 
		' TxtInput
		' 
		TxtInput.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		TxtInput.BackColor = Color.Blue
		TxtInput.ForeColor = Color.White
		TxtInput.Location = New Point(496, 111)
		TxtInput.Name = "TxtInput"
		TxtInput.Size = New Size(100, 23)
		TxtInput.TabIndex = 2
		' 
		' GrpRadios
		' 
		GrpRadios.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		GrpRadios.BackColor = Color.Blue
		GrpRadios.Controls.Add(RadMToIn)
		GrpRadios.Controls.Add(RadInToM)
		GrpRadios.ForeColor = Color.White
		GrpRadios.Location = New Point(368, 189)
		GrpRadios.Name = "GrpRadios"
		GrpRadios.Size = New Size(200, 100)
		GrpRadios.TabIndex = 3
		GrpRadios.TabStop = False
		GrpRadios.Text = "GrpRadios"
		' 
		' RadMToIn
		' 
		RadMToIn.AutoSize = True
		RadMToIn.Location = New Point(17, 55)
		RadMToIn.Name = "RadMToIn"
		RadMToIn.Size = New Size(78, 19)
		RadMToIn.TabIndex = 1
		RadMToIn.TabStop = True
		RadMToIn.Text = "RadMToIn"
		RadMToIn.UseVisualStyleBackColor = True
		' 
		' RadInToM
		' 
		RadInToM.AutoSize = True
		RadInToM.Location = New Point(17, 30)
		RadInToM.Name = "RadInToM"
		RadInToM.Size = New Size(78, 19)
		RadInToM.TabIndex = 0
		RadInToM.TabStop = True
		RadInToM.Text = "RadInToM"
		RadInToM.UseVisualStyleBackColor = True
		' 
		' PicBuilding
		' 
		PicBuilding.Image = My.Resources.Resources.building
		PicBuilding.Location = New Point(3, 12)
		PicBuilding.Name = "PicBuilding"
		PicBuilding.Size = New Size(274, 211)
		PicBuilding.SizeMode = PictureBoxSizeMode.AutoSize
		PicBuilding.TabIndex = 4
		PicBuilding.TabStop = False
		' 
		' BtnConvert
		' 
		BtnConvert.Location = New Point(12, 375)
		BtnConvert.Name = "BtnConvert"
		BtnConvert.Size = New Size(185, 62)
		BtnConvert.TabIndex = 5
		BtnConvert.Text = "BtnConvert"
		BtnConvert.UseVisualStyleBackColor = True
		' 
		' BtnClear
		' 
		BtnClear.Location = New Point(248, 376)
		BtnClear.Name = "BtnClear"
		BtnClear.Size = New Size(185, 62)
		BtnClear.TabIndex = 6
		BtnClear.Text = "BtnClear"
		BtnClear.UseVisualStyleBackColor = True
		' 
		' BtnExit
		' 
		BtnExit.Location = New Point(496, 376)
		BtnExit.Name = "BtnExit"
		BtnExit.Size = New Size(185, 63)
		BtnExit.TabIndex = 7
		BtnExit.Text = "BtnExit"
		BtnExit.UseVisualStyleBackColor = True
		' 
		' LblOutput
		' 
		LblOutput.AutoSize = True
		LblOutput.Location = New Point(368, 323)
		LblOutput.Name = "LblOutput"
		LblOutput.Size = New Size(61, 15)
		LblOutput.TabIndex = 8
		LblOutput.Text = "LblOutput"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
		ClientSize = New Size(695, 450)
		Controls.Add(LblOutput)
		Controls.Add(BtnExit)
		Controls.Add(BtnClear)
		Controls.Add(BtnConvert)
		Controls.Add(PicBuilding)
		Controls.Add(GrpRadios)
		Controls.Add(TxtInput)
		Controls.Add(LblPrompt)
		Controls.Add(LblHeader)
		Name = "Form1"
		Text = "Form1"
		GrpRadios.ResumeLayout(False)
		GrpRadios.PerformLayout()
		CType(PicBuilding, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents LblHeader As Label
	Friend WithEvents LblPrompt As Label
	Friend WithEvents TxtInput As TextBox
	Friend WithEvents GrpRadios As GroupBox
	Friend WithEvents PicBuilding As PictureBox
	Friend WithEvents RadMToIn As RadioButton
	Friend WithEvents RadInToM As RadioButton
	Friend WithEvents BtnConvert As Button
	Friend WithEvents BtnClear As Button
	Friend WithEvents BtnExit As Button
	Friend WithEvents LblOutput As Label

End Class
