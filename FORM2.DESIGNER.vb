<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumPurple
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(837, 430)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 29)
        Button2.TabIndex = 1
        Button2.Text = "MANAGE PRODUCTS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.MediumPurple
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(1263, 430)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 29)
        Button3.TabIndex = 2
        Button3.Text = "NEW ORDERS"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.MediumPurple
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(1077, 430)
        Button4.Name = "Button4"
        Button4.Size = New Size(159, 29)
        Button4.TabIndex = 3
        Button4.Text = "CUSTOMERS"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.MediumPurple
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(1263, 508)
        Button5.Name = "Button5"
        Button5.Size = New Size(139, 29)
        Button5.TabIndex = 4
        Button5.Text = "SUPPLIERS"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.MediumPurple
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button6.ForeColor = SystemColors.Control
        Button6.Location = New Point(1077, 508)
        Button6.Name = "Button6"
        Button6.Size = New Size(159, 29)
        Button6.TabIndex = 5
        Button6.Text = "SALES REPORT"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AliceBlue
        Label2.Font = New Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1176, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 31)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.AliceBlue
        Label3.Font = New Font("Showcard Gothic", 14F)
        Label3.Location = New Point(837, 350)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 30)
        Label3.TabIndex = 8
        Label3.Text = "Label3"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MediumPurple
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(837, 508)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 29)
        Button1.TabIndex = 9
        Button1.Text = "PAYMENT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(-41, -33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(732, 413)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.GhostWhite
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(1077, 533)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(666, 359)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1741, 864)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox2)
        Name = "form2"
        Text = "HOME PAGE"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
