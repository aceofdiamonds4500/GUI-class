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
		LblHeader.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		LblHeader.Location = New Point(328, 35)
		LblHeader.Name = "LblHeader"
		LblHeader.Size = New Size(208, 40)
		LblHeader.TabIndex = 0
		LblHeader.Text = "Converter App"
		' 
		' LblPrompt
		' 
		LblPrompt.Anchor = AnchorStyles.Top
		LblPrompt.AutoSize = True
		LblPrompt.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		LblPrompt.Location = New Point(306, 93)
		LblPrompt.Name = "LblPrompt"
		LblPrompt.Size = New Size(182, 50)
		LblPrompt.TabIndex = 1
		LblPrompt.Text = "Enter a value and" & vbCrLf & "choose conversion:"
		' 
		' TxtInput
		' 
		TxtInput.Anchor = AnchorStyles.Top
		TxtInput.BackColor = Color.Blue
		TxtInput.ForeColor = Color.White
		TxtInput.Location = New Point(506, 107)
		TxtInput.Name = "TxtInput"
		TxtInput.Size = New Size(100, 23)
		TxtInput.TabIndex = 2
		' 
		' GrpRadios
		' 
		GrpRadios.Anchor = AnchorStyles.Top
		GrpRadios.BackColor = Color.Blue
		GrpRadios.Controls.Add(RadMToIn)
		GrpRadios.Controls.Add(RadInToM)
		GrpRadios.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		GrpRadios.ForeColor = Color.White
		GrpRadios.Location = New Point(358, 187)
		GrpRadios.Name = "GrpRadios"
		GrpRadios.Size = New Size(206, 92)
		GrpRadios.TabIndex = 3
		GrpRadios.TabStop = False
		GrpRadios.Text = "Convert Measurements"
		' 
		' RadMToIn
		' 
		RadMToIn.AutoSize = True
		RadMToIn.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		RadMToIn.Location = New Point(17, 55)
		RadMToIn.Name = "RadMToIn"
		RadMToIn.Size = New Size(151, 25)
		RadMToIn.TabIndex = 1
		RadMToIn.TabStop = True
		RadMToIn.Text = "Meters to Inches"
		RadMToIn.UseVisualStyleBackColor = True
		' 
		' RadInToM
		' 
		RadInToM.AutoSize = True
		RadInToM.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		RadInToM.Location = New Point(17, 28)
		RadInToM.Name = "RadInToM"
		RadInToM.Size = New Size(151, 25)
		RadInToM.TabIndex = 0
		RadInToM.TabStop = True
		RadInToM.Text = "Inches to Meters"
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
		BtnConvert.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
		BtnConvert.Location = New Point(12, 375)
		BtnConvert.Name = "BtnConvert"
		BtnConvert.Size = New Size(185, 62)
		BtnConvert.TabIndex = 5
		BtnConvert.Text = "Convert"
		BtnConvert.UseVisualStyleBackColor = True
		' 
		' BtnClear
		' 
		BtnClear.Anchor = AnchorStyles.Bottom
		BtnClear.Location = New Point(216, 377)
		BtnClear.Name = "BtnClear"
		BtnClear.Size = New Size(185, 62)
		BtnClear.TabIndex = 6
		BtnClear.Text = "Clear"
		BtnClear.UseVisualStyleBackColor = True
		' 
		' BtnExit
		' 
		BtnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
		BtnExit.Location = New Point(425, 374)
		BtnExit.Name = "BtnExit"
		BtnExit.Size = New Size(185, 63)
		BtnExit.TabIndex = 7
		BtnExit.Text = "Exit"
		BtnExit.UseVisualStyleBackColor = True
		' 
		' LblOutput
		' 
		LblOutput.Anchor = AnchorStyles.Top
		LblOutput.AutoSize = True
		LblOutput.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		LblOutput.Location = New Point(358, 301)
		LblOutput.Name = "LblOutput"
		LblOutput.Size = New Size(202, 30)
		LblOutput.TabIndex = 8
		LblOutput.Text = "x Meters is x inches."
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
		ClientSize = New Size(630, 450)
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
