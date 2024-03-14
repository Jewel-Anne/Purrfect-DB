<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clientname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.petname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.breed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.species = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coltime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.services = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(373, 113)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(97, 90)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(485, 138)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(1084, 53)
        Me.txtSearch.TabIndex = 41
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(476, 134)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1105, 60)
        Me.PictureBox5.TabIndex = 40
        Me.PictureBox5.TabStop = False
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblX.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblX.Font = New System.Drawing.Font("Rockwell", 26.25!)
        Me.lblX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblX.Location = New System.Drawing.Point(1701, 13)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(51, 49)
        Me.lblX.TabIndex = 39
        Me.lblX.Text = "X"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 26.25!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(578, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(725, 49)
        Me.lblTitle.TabIndex = 38
        Me.lblTitle.Text = "P   A   T   I   E   N   T   '  S     L   I   S   T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(281, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1413, 58)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Rockwell", 26.25!)
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAdd.Location = New System.Drawing.Point(379, 870)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(1191, 58)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "c r e a t e  n e w  r e c o r d"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvTable
        '
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.AllowUserToDeleteRows = False
        Me.dgvTable.AllowUserToResizeColumns = False
        Me.dgvTable.AllowUserToResizeRows = False
        Me.dgvTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.clientname, Me.contactno, Me.address, Me.petname, Me.age, Me.breed, Me.color, Me.sex, Me.species, Me.coldate, Me.coltime, Me.services, Me.total})
        Me.dgvTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.dgvTable.Location = New System.Drawing.Point(45, 219)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.ReadOnly = True
        Me.dgvTable.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvTable.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTable.RowTemplate.Height = 25
        Me.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTable.Size = New System.Drawing.Size(1691, 618)
        Me.dgvTable.TabIndex = 44
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(495, 38)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(72, 58)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 48
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(1358, 38)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(72, 58)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 49
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(199, 191)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 57
        Me.PictureBox8.TabStop = False
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.HeaderText = "Transaction No."
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Width = 205
        '
        'clientname
        '
        Me.clientname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clientname.HeaderText = "Client's Name"
        Me.clientname.Name = "clientname"
        Me.clientname.ReadOnly = True
        Me.clientname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clientname.Width = 130
        '
        'contactno
        '
        Me.contactno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.contactno.HeaderText = "Contact No."
        Me.contactno.Name = "contactno"
        Me.contactno.ReadOnly = True
        Me.contactno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.contactno.Width = 117
        '
        'address
        '
        Me.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.address.Width = 116
        '
        'petname
        '
        Me.petname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.petname.HeaderText = "Pet's Name"
        Me.petname.Name = "petname"
        Me.petname.ReadOnly = True
        Me.petname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.petname.Width = 92
        '
        'age
        '
        Me.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.age.Width = 60
        '
        'breed
        '
        Me.breed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.breed.HeaderText = "Breed"
        Me.breed.Name = "breed"
        Me.breed.ReadOnly = True
        Me.breed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.breed.Width = 88
        '
        'color
        '
        Me.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.color.HeaderText = "Color"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        Me.color.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.color.Width = 88
        '
        'sex
        '
        Me.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.sex.HeaderText = "Sex"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sex.Width = 60
        '
        'species
        '
        Me.species.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.species.HeaderText = "Species"
        Me.species.Name = "species"
        Me.species.ReadOnly = True
        Me.species.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.species.Width = 116
        '
        'coldate
        '
        Me.coldate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldate.HeaderText = "Date"
        Me.coldate.Name = "coldate"
        Me.coldate.ReadOnly = True
        Me.coldate.Width = 97
        '
        'coltime
        '
        Me.coltime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coltime.HeaderText = "Time"
        Me.coltime.Name = "coltime"
        Me.coltime.ReadOnly = True
        Me.coltime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coltime.Width = 74
        '
        'services
        '
        Me.services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.services.HeaderText = "Services"
        Me.services.Name = "services"
        Me.services.ReadOnly = True
        Me.services.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.services.Width = 130
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.Width = 88
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1769, 955)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblX As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents clientname As DataGridViewTextBoxColumn
    Friend WithEvents contactno As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents petname As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents breed As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents sex As DataGridViewTextBoxColumn
    Friend WithEvents species As DataGridViewTextBoxColumn
    Friend WithEvents coldate As DataGridViewTextBoxColumn
    Friend WithEvents coltime As DataGridViewTextBoxColumn
    Friend WithEvents services As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
