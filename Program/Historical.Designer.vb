<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Historical
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Historical))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Dt_Tahun = New System.Windows.Forms.DateTimePicker()
        Me.Cb_SKIDp = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_BulanP = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pb_Search = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Bt_Home = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Pb_Excell = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PanelMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PanelSKID = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Dg_IC = New System.Windows.Forms.DataGridView()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Bt_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Bt_minimazed = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Bt_Logout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.InspectionCheck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Standard = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Pb_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bt_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.Pb_Excell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSKID.SuspendLayout()
        CType(Me.Dg_IC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bt_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bt_minimazed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bt_Logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.BunifuGradientPanel1
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Dt_Tahun)
        Me.BunifuGradientPanel1.Controls.Add(Me.Cb_SKIDp)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel15)
        Me.BunifuGradientPanel1.Controls.Add(Me.Cb_BulanP)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel16)
        Me.BunifuGradientPanel1.Controls.Add(Me.Pb_Search)
        Me.BunifuGradientPanel1.Controls.Add(Me.Bt_Home)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(24, 30)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1164, 46)
        Me.BunifuGradientPanel1.TabIndex = 72
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(407, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(72, 17)
        Me.BunifuCustomLabel1.TabIndex = 75
        Me.BunifuCustomLabel1.Text = "Pilih SKID :"
        '
        'Dt_Tahun
        '
        Me.Dt_Tahun.CustomFormat = "yyyy"
        Me.Dt_Tahun.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dt_Tahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dt_Tahun.Location = New System.Drawing.Point(251, 9)
        Me.Dt_Tahun.Name = "Dt_Tahun"
        Me.Dt_Tahun.ShowUpDown = True
        Me.Dt_Tahun.Size = New System.Drawing.Size(147, 25)
        Me.Dt_Tahun.TabIndex = 79
        '
        'Cb_SKIDp
        '
        Me.Cb_SKIDp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_SKIDp.FormattingEnabled = True
        Me.Cb_SKIDp.Items.AddRange(New Object() {"P29", "P31", "P32", "P33"})
        Me.Cb_SKIDp.Location = New System.Drawing.Point(485, 9)
        Me.Cb_SKIDp.Name = "Cb_SKIDp"
        Me.Cb_SKIDp.Size = New System.Drawing.Size(147, 25)
        Me.Cb_SKIDp.TabIndex = 74
        Me.Cb_SKIDp.Text = "P29"
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(7, 15)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(49, 17)
        Me.BunifuCustomLabel15.TabIndex = 59
        Me.BunifuCustomLabel15.Text = "Bulan :"
        '
        'Cb_BulanP
        '
        Me.Cb_BulanP.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_BulanP.FormattingEnabled = True
        Me.Cb_BulanP.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.Cb_BulanP.Location = New System.Drawing.Point(62, 9)
        Me.Cb_BulanP.Name = "Cb_BulanP"
        Me.Cb_BulanP.Size = New System.Drawing.Size(125, 25)
        Me.Cb_BulanP.TabIndex = 14
        Me.Cb_BulanP.Text = "Januari"
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(193, 15)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(52, 17)
        Me.BunifuCustomLabel16.TabIndex = 60
        Me.BunifuCustomLabel16.Text = "Tahun :"
        '
        'Pb_Search
        '
        Me.Pb_Search.BackColor = System.Drawing.Color.Transparent
        Me.Pb_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pb_Search.Image = Global.Program.My.Resources.Resources.magnifier
        Me.Pb_Search.ImageActive = Nothing
        Me.Pb_Search.Location = New System.Drawing.Point(1083, 9)
        Me.Pb_Search.Name = "Pb_Search"
        Me.Pb_Search.Size = New System.Drawing.Size(33, 31)
        Me.Pb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Search.TabIndex = 67
        Me.Pb_Search.TabStop = False
        Me.Pb_Search.Zoom = 20
        '
        'Bt_Home
        '
        Me.Bt_Home.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Home.Image = Global.Program.My.Resources.Resources.icons8_home_150
        Me.Bt_Home.ImageActive = Nothing
        Me.Bt_Home.Location = New System.Drawing.Point(1122, 9)
        Me.Bt_Home.Name = "Bt_Home"
        Me.Bt_Home.Size = New System.Drawing.Size(33, 31)
        Me.Bt_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bt_Home.TabIndex = 28
        Me.Bt_Home.TabStop = False
        Me.Bt_Home.Zoom = 20
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.BunifuGradientPanel2
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.Pb_Excell)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(24, 651)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1164, 42)
        Me.BunifuGradientPanel2.TabIndex = 73
        '
        'Pb_Excell
        '
        Me.Pb_Excell.BackColor = System.Drawing.Color.Transparent
        Me.Pb_Excell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pb_Excell.Image = Global.Program.My.Resources.Resources.icon
        Me.Pb_Excell.ImageActive = Nothing
        Me.Pb_Excell.Location = New System.Drawing.Point(1122, 6)
        Me.Pb_Excell.Name = "Pb_Excell"
        Me.Pb_Excell.Size = New System.Drawing.Size(33, 31)
        Me.Pb_Excell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pb_Excell.TabIndex = 71
        Me.Pb_Excell.TabStop = False
        Me.Pb_Excell.Zoom = 20
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelMenu.BackgroundImage = CType(resources.GetObject("PanelMenu.BackgroundImage"), System.Drawing.Image)
        Me.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMenu.Controls.Add(Me.PanelSKID)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PanelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PanelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PanelMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Quality = 10
        Me.PanelMenu.Size = New System.Drawing.Size(1200, 700)
        Me.PanelMenu.TabIndex = 5
        '
        'PanelSKID
        '
        Me.PanelSKID.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelSKID.BackgroundImage = CType(resources.GetObject("PanelSKID.BackgroundImage"), System.Drawing.Image)
        Me.PanelSKID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelSKID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSKID.Controls.Add(Me.BunifuGradientPanel2)
        Me.PanelSKID.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelSKID.Controls.Add(Me.Dg_IC)
        Me.PanelSKID.Controls.Add(Me.BunifuCustomLabel3)
        Me.PanelSKID.Controls.Add(Me.Bt_Close)
        Me.PanelSKID.Controls.Add(Me.Bt_minimazed)
        Me.PanelSKID.Controls.Add(Me.Bt_Logout)
        Me.PanelSKID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSKID.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelSKID.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelSKID.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelSKID.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelSKID.Location = New System.Drawing.Point(0, 0)
        Me.PanelSKID.Name = "PanelSKID"
        Me.PanelSKID.Quality = 10
        Me.PanelSKID.Size = New System.Drawing.Size(1200, 700)
        Me.PanelSKID.TabIndex = 29
        '
        'Dg_IC
        '
        Me.Dg_IC.BackgroundColor = System.Drawing.Color.White
        Me.Dg_IC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dg_IC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_IC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_IC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_IC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InspectionCheck, Me.Standard, Me.Week, Me.Result, Me.Tanggal, Me.Remark, Me.PIC})
        Me.Dg_IC.EnableHeadersVisualStyles = False
        Me.Dg_IC.GridColor = System.Drawing.Color.Black
        Me.Dg_IC.Location = New System.Drawing.Point(24, 77)
        Me.Dg_IC.Name = "Dg_IC"
        Me.Dg_IC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_IC.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dg_IC.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_IC.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dg_IC.Size = New System.Drawing.Size(1164, 573)
        Me.Dg_IC.TabIndex = 30
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe Script", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(20, 3)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(220, 20)
        Me.BunifuCustomLabel3.TabIndex = 26
        Me.BunifuCustomLabel3.Text = "Inspection Check Sheet Historical"
        '
        'Bt_Close
        '
        Me.Bt_Close.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Close.Image = Global.Program.My.Resources.Resources.cross
        Me.Bt_Close.ImageActive = Nothing
        Me.Bt_Close.Location = New System.Drawing.Point(1170, 6)
        Me.Bt_Close.Name = "Bt_Close"
        Me.Bt_Close.Size = New System.Drawing.Size(18, 17)
        Me.Bt_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bt_Close.TabIndex = 13
        Me.Bt_Close.TabStop = False
        Me.Bt_Close.Zoom = 20
        '
        'Bt_minimazed
        '
        Me.Bt_minimazed.BackColor = System.Drawing.Color.Transparent
        Me.Bt_minimazed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_minimazed.Image = Global.Program.My.Resources.Resources.multi_tab
        Me.Bt_minimazed.ImageActive = Nothing
        Me.Bt_minimazed.Location = New System.Drawing.Point(1146, 6)
        Me.Bt_minimazed.Name = "Bt_minimazed"
        Me.Bt_minimazed.Size = New System.Drawing.Size(18, 17)
        Me.Bt_minimazed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bt_minimazed.TabIndex = 14
        Me.Bt_minimazed.TabStop = False
        Me.Bt_minimazed.Zoom = 20
        '
        'Bt_Logout
        '
        Me.Bt_Logout.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Logout.Image = Global.Program.My.Resources.Resources.logout
        Me.Bt_Logout.ImageActive = Nothing
        Me.Bt_Logout.Location = New System.Drawing.Point(1122, 6)
        Me.Bt_Logout.Name = "Bt_Logout"
        Me.Bt_Logout.Size = New System.Drawing.Size(18, 17)
        Me.Bt_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bt_Logout.TabIndex = 15
        Me.Bt_Logout.TabStop = False
        Me.Bt_Logout.Zoom = 20
        '
        'InspectionCheck
        '
        Me.InspectionCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.InspectionCheck.DataPropertyName = "InspectionCheck"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InspectionCheck.DefaultCellStyle = DataGridViewCellStyle2
        Me.InspectionCheck.HeaderText = "Inspection Check"
        Me.InspectionCheck.Name = "InspectionCheck"
        '
        'Standard
        '
        Me.Standard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Standard.DataPropertyName = "Standard"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Standard.DefaultCellStyle = DataGridViewCellStyle3
        Me.Standard.HeaderText = "Standard"
        Me.Standard.Name = "Standard"
        Me.Standard.Width = 102
        '
        'Week
        '
        Me.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Week.DataPropertyName = "Week"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Week.DefaultCellStyle = DataGridViewCellStyle4
        Me.Week.HeaderText = "Week"
        Me.Week.Name = "Week"
        Me.Week.Width = 76
        '
        'Result
        '
        Me.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Result.DataPropertyName = "Result"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.DefaultCellStyle = DataGridViewCellStyle5
        Me.Result.HeaderText = "Result"
        Me.Result.Name = "Result"
        Me.Result.Width = 81
        '
        'Tanggal
        '
        Me.Tanggal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tanggal.DataPropertyName = "Tanggal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.DefaultCellStyle = DataGridViewCellStyle6
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Width = 95
        '
        'Remark
        '
        Me.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Remark.DataPropertyName = "Remark"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remark.DefaultCellStyle = DataGridViewCellStyle7
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Width = 92
        '
        'PIC
        '
        Me.PIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PIC.DataPropertyName = "PIC"
        Me.PIC.HeaderText = "PIC"
        Me.PIC.Name = "PIC"
        Me.PIC.Width = 60
        '
        'Historical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Historical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historical"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Pb_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bt_Home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.Pb_Excell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSKID.ResumeLayout(False)
        Me.PanelSKID.PerformLayout()
        CType(Me.Dg_IC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bt_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bt_minimazed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bt_Logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Pb_Excell As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Dt_Tahun As DateTimePicker
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_BulanP As ComboBox
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pb_Search As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Bt_Home As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PanelSKID As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Dg_IC As DataGridView
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Bt_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Bt_minimazed As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Bt_Logout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_SKIDp As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents InspectionCheck As DataGridViewTextBoxColumn
    Friend WithEvents Standard As DataGridViewTextBoxColumn
    Friend WithEvents Week As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As DataGridViewTextBoxColumn
    Friend WithEvents Remark As DataGridViewTextBoxColumn
    Friend WithEvents PIC As DataGridViewTextBoxColumn
End Class
