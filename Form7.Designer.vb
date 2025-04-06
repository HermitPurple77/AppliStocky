<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(828, 233)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 35)
        Label1.TabIndex = 0
        Label1.Text = "Sales Report Overview"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(669, 439)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "GENERATE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(933, 439)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 2
        Button2.Text = "EXPORT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(1161, 439)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 3
        Button3.Text = "BACK"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.LightGray
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(12, 22)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(641, 680)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1838, 862)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form7"
        Text = "Form7"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
