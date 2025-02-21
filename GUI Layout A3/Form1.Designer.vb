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
		PictureBox1 = New PictureBox()
		PictureBox2 = New PictureBox()
		Button1 = New Button()
		Button2 = New Button()
		Label1 = New Label()
		Label2 = New Label()
		Button3 = New Button()
		Button4 = New Button()
		Label3 = New Label()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' PictureBox1
		' 
		PictureBox1.Anchor = AnchorStyles.Top
		PictureBox1.Location = New Point(61, 86)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(279, 298)
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' PictureBox2
		' 
		PictureBox2.Anchor = AnchorStyles.Top
		PictureBox2.Location = New Point(454, 86)
		PictureBox2.Name = "PictureBox2"
		PictureBox2.Size = New Size(279, 298)
		PictureBox2.TabIndex = 1
		PictureBox2.TabStop = False
		' 
		' Button1
		' 
		Button1.Anchor = AnchorStyles.Top
		Button1.Location = New Point(166, 390)
		Button1.Name = "Button1"
		Button1.Size = New Size(75, 33)
		Button1.TabIndex = 2
		Button1.Text = "Prime Beef"
		Button1.UseVisualStyleBackColor = True
		' 
		' Button2
		' 
		Button2.Anchor = AnchorStyles.Top
		Button2.Location = New Point(559, 390)
		Button2.Name = "Button2"
		Button2.Size = New Size(75, 33)
		Button2.TabIndex = 3
		Button2.Text = "Veggie"
		Button2.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.Anchor = AnchorStyles.Top
		Label1.AutoSize = True
		Label1.Font = New Font("Tahoma", 9F)
		Label1.Location = New Point(261, 450)
		Label1.Name = "Label1"
		Label1.Size = New Size(312, 14)
		Label1.TabIndex = 4
		Label1.Text = "Choose a burger and then click the Select Meal button."
		' 
		' Label2
		' 
		Label2.Anchor = AnchorStyles.Top
		Label2.AutoSize = True
		Label2.Font = New Font("Tahoma", 9F)
		Label2.Location = New Point(326, 474)
		Label2.Name = "Label2"
		Label2.Size = New Size(148, 14)
		Label2.TabIndex = 5
		Label2.Text = "Enjoy your burger special."
		' 
		' Button3
		' 
		Button3.Anchor = AnchorStyles.Top
		Button3.Location = New Point(362, 390)
		Button3.Name = "Button3"
		Button3.Size = New Size(76, 33)
		Button3.TabIndex = 6
		Button3.Text = "Select Meal"
		Button3.UseVisualStyleBackColor = True
		' 
		' Button4
		' 
		Button4.Anchor = AnchorStyles.Top
		Button4.Location = New Point(351, 516)
		Button4.Name = "Button4"
		Button4.Size = New Size(97, 28)
		Button4.TabIndex = 7
		Button4.Text = "Exit Window"
		Button4.UseVisualStyleBackColor = True
		' 
		' Label3
		' 
		Label3.Anchor = AnchorStyles.Top
		Label3.AutoSize = True
		Label3.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label3.Location = New Point(284, 27)
		Label3.Name = "Label3"
		Label3.Size = New Size(233, 25)
		Label3.TabIndex = 8
		Label3.Text = "Farm Burger Specials"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 576)
		Controls.Add(Label3)
		Controls.Add(Button4)
		Controls.Add(Button3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(Button2)
		Controls.Add(Button1)
		Controls.Add(PictureBox2)
		Controls.Add(PictureBox1)
		Name = "Form1"
		Text = "Burger Specials"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Label3 As Label

End Class
