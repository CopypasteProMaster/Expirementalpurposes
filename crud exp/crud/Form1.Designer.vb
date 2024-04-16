<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        prono = New TextBox()
        proname = New TextBox()
        price = New TextBox()
        progroup = New ComboBox()
        expd = New DateTimePicker()
        stat = New CheckBox()
        btn_save = New Button()
        update = New Button()
        delete = New Button()
        clear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewCheckBoxColumn()
        Label6 = New Label()
        search = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' prono
        ' 
        prono.Location = New Point(41, 29)
        prono.Name = "prono"
        prono.Size = New Size(206, 23)
        prono.TabIndex = 0
        ' 
        ' proname
        ' 
        proname.Location = New Point(41, 90)
        proname.Name = "proname"
        proname.Size = New Size(206, 23)
        proname.TabIndex = 1
        ' 
        ' price
        ' 
        price.Location = New Point(41, 160)
        price.Name = "price"
        price.Size = New Size(206, 23)
        price.TabIndex = 2
        ' 
        ' progroup
        ' 
        progroup.FormattingEnabled = True
        progroup.Items.AddRange(New Object() {"Sweets", "Junk foods", "softdrinks"})
        progroup.Location = New Point(41, 214)
        progroup.Name = "progroup"
        progroup.Size = New Size(206, 23)
        progroup.TabIndex = 3
        ' 
        ' expd
        ' 
        expd.Location = New Point(41, 273)
        expd.Name = "expd"
        expd.Size = New Size(206, 23)
        expd.TabIndex = 4
        ' 
        ' stat
        ' 
        stat.AutoSize = True
        stat.Location = New Point(47, 336)
        stat.Name = "stat"
        stat.Size = New Size(72, 19)
        stat.TabIndex = 5
        stat.Text = "available"
        stat.UseVisualStyleBackColor = True
        ' 
        ' btn_save
        ' 
        btn_save.Location = New Point(47, 374)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(75, 23)
        btn_save.TabIndex = 6
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = True
        ' 
        ' update
        ' 
        update.Location = New Point(159, 374)
        update.Name = "update"
        update.Size = New Size(75, 23)
        update.TabIndex = 7
        update.Text = "Update"
        update.UseVisualStyleBackColor = True
        ' 
        ' delete
        ' 
        delete.Location = New Point(47, 415)
        delete.Name = "delete"
        delete.Size = New Size(75, 23)
        delete.TabIndex = 8
        delete.Text = "Delete"
        delete.UseVisualStyleBackColor = True
        ' 
        ' clear
        ' 
        clear.Location = New Point(159, 415)
        clear.Name = "clear"
        clear.Size = New Size(75, 23)
        clear.TabIndex = 9
        clear.Text = "Clear"
        clear.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 10
        Label1.Text = "Product No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 11
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 12
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(41, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 15)
        Label4.TabIndex = 13
        Label4.Text = "Product Group"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 255)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 14
        Label5.Text = "Expired date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
        DataGridView1.Location = New Point(291, 124)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(497, 303)
        DataGridView1.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "product no"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 91
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "product name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "price"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 58
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "product group"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "expire date"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 83
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "status"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 44
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(291, 63)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 15)
        Label6.TabIndex = 17
        Label6.Text = "Search"
        ' 
        ' search
        ' 
        search.AcceptsReturn = True
        search.Location = New Point(291, 81)
        search.Name = "search"
        search.Size = New Size(206, 23)
        search.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(search)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(clear)
        Controls.Add(delete)
        Controls.Add(update)
        Controls.Add(btn_save)
        Controls.Add(stat)
        Controls.Add(expd)
        Controls.Add(progroup)
        Controls.Add(price)
        Controls.Add(proname)
        Controls.Add(prono)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents prono As TextBox
    Friend WithEvents proname As TextBox
    Friend WithEvents price As TextBox
    Friend WithEvents progroup As ComboBox
    Friend WithEvents expd As DateTimePicker
    Friend WithEvents stat As CheckBox
    Friend WithEvents btn_save As Button
    Friend WithEvents update As Button
    Friend WithEvents delete As Button
    Friend WithEvents clear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents search As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewCheckBoxColumn

End Class
