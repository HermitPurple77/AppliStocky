<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        BtnAdd = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        BtnBack = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtPrice = New TextBox()
        TxtStock = New TextBox()
        TxtProductID = New TextBox()
        TxtProductName = New TextBox()
        Label6 = New Label()
        CmbCategory = New ComboBox()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.Transparent
        BtnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnAdd.ForeColor = SystemColors.ControlText
        BtnAdd.Location = New Point(478, 431)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(94, 29)
        BtnAdd.TabIndex = 2
        BtnAdd.Text = "Add"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.BackColor = Color.Transparent
        BtnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnUpdate.Location = New Point(710, 419)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "Update"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnDelete.Location = New Point(933, 410)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 4
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnBack.Location = New Point(1124, 410)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(94, 29)
        BtnBack.TabIndex = 5
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(642, 581)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 7
        Label2.Text = "PRODUCT ID "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(625, 521)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 8
        Label3.Text = "PRODUCT NAME "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(648, 710)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 9
        Label4.Text = "PRICE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(642, 646)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 10
        Label5.Text = "STOCK"
        ' 
        ' TxtPrice
        ' 
        TxtPrice.Location = New Point(826, 707)
        TxtPrice.Name = "TxtPrice"
        TxtPrice.Size = New Size(125, 27)
        TxtPrice.TabIndex = 11
        ' 
        ' TxtStock
        ' 
        TxtStock.Location = New Point(826, 643)
        TxtStock.Name = "TxtStock"
        TxtStock.Size = New Size(125, 27)
        TxtStock.TabIndex = 12
        ' 
        ' TxtProductID
        ' 
        TxtProductID.Location = New Point(826, 574)
        TxtProductID.Name = "TxtProductID"
        TxtProductID.Size = New Size(125, 27)
        TxtProductID.TabIndex = 13
        ' 
        ' TxtProductName
        ' 
        TxtProductName.BackColor = Color.FloralWhite
        TxtProductName.Location = New Point(826, 518)
        TxtProductName.Name = "TxtProductName"
        TxtProductName.Size = New Size(125, 27)
        TxtProductName.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(648, 778)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 15
        Label6.Text = "CATEGORY"
        ' 
        ' CmbCategory
        ' 
        CmbCategory.FormattingEnabled = True
        CmbCategory.Location = New Point(826, 770)
        CmbCategory.Name = "CmbCategory"
        CmbCategory.Size = New Size(151, 28)
        CmbCategory.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(1092, 525)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 17
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(-2, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1858, 288)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1839, 855)
        Controls.Add(PictureBox1)
        Controls.Add(DataGridView1)
        Controls.Add(CmbCategory)
        Controls.Add(Label6)
        Controls.Add(TxtProductName)
        Controls.Add(TxtProductID)
        Controls.Add(TxtStock)
        Controls.Add(TxtPrice)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnBack)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnAdd)
        DoubleBuffered = True
        Name = "Form3"
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtProductID As TextBox
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbCategory As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
