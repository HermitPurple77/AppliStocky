<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(712, 189)
        Label1.Name = "Label1"
        Label1.Size = New Size(686, 43)
        Label1.TabIndex = 0
        Label1.Text = "APPLIANCE MANAGEMENT SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientInactiveCaption
        Label2.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(871, 343)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 24)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.GradientInactiveCaption
        Label3.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(871, 438)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 24)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(1048, 343)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(1048, 437)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Font = New Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(761, 532)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.FlatAppearance.BorderSize = 5
        Button2.Font = New Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1161, 532)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(1441, 391)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(429, 630)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1836, 853)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
