<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        TextBox4 = New TextBox()
        Button6 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(594, 125)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(781, 125)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 5
        Button2.Text = "REMOVE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.Location = New Point(974, 125)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 6
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.Location = New Point(1150, 125)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 7
        Button4.Text = "CLEAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button5.Location = New Point(888, 209)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 11
        Button5.Text = "BACK"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(760, 327)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 12
        Label1.Text = "ORDER ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(760, 379)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 20)
        Label2.TabIndex = 13
        Label2.Text = "CUSTOMER NAME "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(760, 437)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 14
        Label3.Text = "PRODUCT NAME "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(760, 498)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 15
        Label4.Text = "QUANTITY "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(760, 548)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 20)
        Label5.TabIndex = 16
        Label5.Text = "TOTAL PRICE"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(760, 605)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 20)
        Label6.TabIndex = 17
        Label6.Text = "ORDER DATE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(760, 681)
        Label7.Name = "Label7"
        Label7.Size = New Size(121, 20)
        Label7.TabIndex = 18
        Label7.Text = "ORDER STATUS "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(760, 744)
        Label8.Name = "Label8"
        Label8.Size = New Size(141, 20)
        Label8.TabIndex = 19
        Label8.Text = "PAYMENT STATUS "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(933, 327)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 20
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(933, 495)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 21
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(933, 548)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 22
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(933, 376)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 23
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(933, 437)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 24
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(933, 678)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 25
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(933, 736)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(151, 28)
        ComboBox4.TabIndex = 26
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(933, 600)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 27)
        DateTimePicker1.TabIndex = 27
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(1262, 376)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 28
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(750, 789)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 29
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button6.Location = New Point(933, 789)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 30
        Button6.Text = "SEARCH "
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(-252, -204)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(893, 808)
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(518, -779)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1090, 958)
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1838, 858)
        Controls.Add(Button6)
        Controls.Add(TextBox4)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Name = "Form4"
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
