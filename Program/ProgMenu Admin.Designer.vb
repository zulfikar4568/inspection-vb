<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgMenu_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgMenu_Admin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Bt_AddIc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Bt_Grafik = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse4 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Bt_Historical = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse5 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Bt_DataKondisi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse6 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Closemenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Minimazemenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Logout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PanelMenu.SuspendLayout()
        CType(Me.Closemenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimazemenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 15
        Me.BunifuElipse2.TargetControl = Me.Bt_AddIc
        '
        'Bt_AddIc
        '
        Me.Bt_AddIc.Activecolor = System.Drawing.Color.White
        Me.Bt_AddIc.BackColor = System.Drawing.Color.White
        Me.Bt_AddIc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bt_AddIc.BorderRadius = 0
        Me.Bt_AddIc.ButtonText = "Tambahkan Jenis Inspeksi"
        Me.Bt_AddIc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_AddIc.DisabledColor = System.Drawing.Color.Gray
        Me.Bt_AddIc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_AddIc.Iconcolor = System.Drawing.Color.Transparent
        Me.Bt_AddIc.Iconimage = Global.Program.My.Resources.Resources._1263914
        Me.Bt_AddIc.Iconimage_right = Nothing
        Me.Bt_AddIc.Iconimage_right_Selected = Nothing
        Me.Bt_AddIc.Iconimage_Selected = Nothing
        Me.Bt_AddIc.IconMarginLeft = 0
        Me.Bt_AddIc.IconMarginRight = 0
        Me.Bt_AddIc.IconRightVisible = True
        Me.Bt_AddIc.IconRightZoom = 0R
        Me.Bt_AddIc.IconVisible = True
        Me.Bt_AddIc.IconZoom = 90.0R
        Me.Bt_AddIc.IsTab = False
        Me.Bt_AddIc.Location = New System.Drawing.Point(6, 42)
        Me.Bt_AddIc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bt_AddIc.Name = "Bt_AddIc"
        Me.Bt_AddIc.Normalcolor = System.Drawing.Color.White
        Me.Bt_AddIc.OnHovercolor = System.Drawing.Color.White
        Me.Bt_AddIc.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Bt_AddIc.selected = False
        Me.Bt_AddIc.Size = New System.Drawing.Size(280, 100)
        Me.Bt_AddIc.TabIndex = 15
        Me.Bt_AddIc.Text = "Tambahkan Jenis Inspeksi"
        Me.Bt_AddIc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Bt_AddIc.Textcolor = System.Drawing.Color.Black
        Me.Bt_AddIc.TextFont = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 15
        Me.BunifuElipse3.TargetControl = Me.Bt_Grafik
        '
        'Bt_Grafik
        '
        Me.Bt_Grafik.Activecolor = System.Drawing.Color.White
        Me.Bt_Grafik.BackColor = System.Drawing.Color.White
        Me.Bt_Grafik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bt_Grafik.BorderRadius = 0
        Me.Bt_Grafik.ButtonText = "Grafik"
        Me.Bt_Grafik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Grafik.DisabledColor = System.Drawing.Color.Gray
        Me.Bt_Grafik.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Grafik.Iconcolor = System.Drawing.Color.Transparent
        Me.Bt_Grafik.Iconimage = Global.Program.My.Resources.Resources.icon_grafik_417x330
        Me.Bt_Grafik.Iconimage_right = Nothing
        Me.Bt_Grafik.Iconimage_right_Selected = Nothing
        Me.Bt_Grafik.Iconimage_Selected = Nothing
        Me.Bt_Grafik.IconMarginLeft = 0
        Me.Bt_Grafik.IconMarginRight = 0
        Me.Bt_Grafik.IconRightVisible = True
        Me.Bt_Grafik.IconRightZoom = 0R
        Me.Bt_Grafik.IconVisible = True
        Me.Bt_Grafik.IconZoom = 90.0R
        Me.Bt_Grafik.IsTab = False
        Me.Bt_Grafik.Location = New System.Drawing.Point(294, 150)
        Me.Bt_Grafik.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bt_Grafik.Name = "Bt_Grafik"
        Me.Bt_Grafik.Normalcolor = System.Drawing.Color.White
        Me.Bt_Grafik.OnHovercolor = System.Drawing.Color.White
        Me.Bt_Grafik.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Bt_Grafik.selected = False
        Me.Bt_Grafik.Size = New System.Drawing.Size(280, 100)
        Me.Bt_Grafik.TabIndex = 17
        Me.Bt_Grafik.Text = "Grafik"
        Me.Bt_Grafik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Bt_Grafik.Textcolor = System.Drawing.Color.Black
        Me.Bt_Grafik.TextFont = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse4
        '
        Me.BunifuElipse4.ElipseRadius = 15
        Me.BunifuElipse4.TargetControl = Me.Bt_Historical
        '
        'Bt_Historical
        '
        Me.Bt_Historical.Activecolor = System.Drawing.Color.White
        Me.Bt_Historical.BackColor = System.Drawing.Color.White
        Me.Bt_Historical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bt_Historical.BorderRadius = 0
        Me.Bt_Historical.ButtonText = "Historical Data"
        Me.Bt_Historical.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Historical.DisabledColor = System.Drawing.Color.Gray
        Me.Bt_Historical.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Historical.Iconcolor = System.Drawing.Color.Transparent
        Me.Bt_Historical.Iconimage = Global.Program.My.Resources.Resources.order_history_icon_export_csv_blue_icon_11553511776dpkqdrksk8
        Me.Bt_Historical.Iconimage_right = Nothing
        Me.Bt_Historical.Iconimage_right_Selected = Nothing
        Me.Bt_Historical.Iconimage_Selected = Nothing
        Me.Bt_Historical.IconMarginLeft = 0
        Me.Bt_Historical.IconMarginRight = 0
        Me.Bt_Historical.IconRightVisible = True
        Me.Bt_Historical.IconRightZoom = 0R
        Me.Bt_Historical.IconVisible = True
        Me.Bt_Historical.IconZoom = 90.0R
        Me.Bt_Historical.IsTab = False
        Me.Bt_Historical.Location = New System.Drawing.Point(6, 150)
        Me.Bt_Historical.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bt_Historical.Name = "Bt_Historical"
        Me.Bt_Historical.Normalcolor = System.Drawing.Color.White
        Me.Bt_Historical.OnHovercolor = System.Drawing.Color.White
        Me.Bt_Historical.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Bt_Historical.selected = False
        Me.Bt_Historical.Size = New System.Drawing.Size(280, 100)
        Me.Bt_Historical.TabIndex = 16
        Me.Bt_Historical.Text = "Historical Data"
        Me.Bt_Historical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Bt_Historical.Textcolor = System.Drawing.Color.Black
        Me.Bt_Historical.TextFont = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse5
        '
        Me.BunifuElipse5.ElipseRadius = 15
        Me.BunifuElipse5.TargetControl = Me.Bt_DataKondisi
        '
        'Bt_DataKondisi
        '
        Me.Bt_DataKondisi.Activecolor = System.Drawing.Color.White
        Me.Bt_DataKondisi.BackColor = System.Drawing.Color.White
        Me.Bt_DataKondisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bt_DataKondisi.BorderRadius = 0
        Me.Bt_DataKondisi.ButtonText = "Ubah Data Kondisi"
        Me.Bt_DataKondisi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_DataKondisi.DisabledColor = System.Drawing.Color.Gray
        Me.Bt_DataKondisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_DataKondisi.Iconcolor = System.Drawing.Color.Transparent
        Me.Bt_DataKondisi.Iconimage = Global.Program.My.Resources.Resources.Working_Schedule
        Me.Bt_DataKondisi.Iconimage_right = Nothing
        Me.Bt_DataKondisi.Iconimage_right_Selected = Nothing
        Me.Bt_DataKondisi.Iconimage_Selected = Nothing
        Me.Bt_DataKondisi.IconMarginLeft = 0
        Me.Bt_DataKondisi.IconMarginRight = 0
        Me.Bt_DataKondisi.IconRightVisible = True
        Me.Bt_DataKondisi.IconRightZoom = 0R
        Me.Bt_DataKondisi.IconVisible = True
        Me.Bt_DataKondisi.IconZoom = 90.0R
        Me.Bt_DataKondisi.IsTab = False
        Me.Bt_DataKondisi.Location = New System.Drawing.Point(294, 42)
        Me.Bt_DataKondisi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Bt_DataKondisi.Name = "Bt_DataKondisi"
        Me.Bt_DataKondisi.Normalcolor = System.Drawing.Color.White
        Me.Bt_DataKondisi.OnHovercolor = System.Drawing.Color.White
        Me.Bt_DataKondisi.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Bt_DataKondisi.selected = False
        Me.Bt_DataKondisi.Size = New System.Drawing.Size(280, 100)
        Me.Bt_DataKondisi.TabIndex = 18
        Me.Bt_DataKondisi.Text = "Ubah Data Kondisi"
        Me.Bt_DataKondisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Bt_DataKondisi.Textcolor = System.Drawing.Color.Black
        Me.Bt_DataKondisi.TextFont = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse6
        '
        Me.BunifuElipse6.ElipseRadius = 15
        Me.BunifuElipse6.TargetControl = Me
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelMenu.BackgroundImage = CType(resources.GetObject("PanelMenu.BackgroundImage"), System.Drawing.Image)
        Me.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelMenu.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelMenu.Controls.Add(Me.Closemenu)
        Me.PanelMenu.Controls.Add(Me.Bt_DataKondisi)
        Me.PanelMenu.Controls.Add(Me.Bt_Historical)
        Me.PanelMenu.Controls.Add(Me.Minimazemenu)
        Me.PanelMenu.Controls.Add(Me.Logout)
        Me.PanelMenu.Controls.Add(Me.Bt_Grafik)
        Me.PanelMenu.Controls.Add(Me.Bt_AddIc)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMenu.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelMenu.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelMenu.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Quality = 10
        Me.PanelMenu.Size = New System.Drawing.Size(580, 280)
        Me.PanelMenu.TabIndex = 4
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe Script", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 11)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(206, 20)
        Me.BunifuCustomLabel2.TabIndex = 26
        Me.BunifuCustomLabel2.Text = "Inspection Check Menu Admin"
        '
        'Closemenu
        '
        Me.Closemenu.BackColor = System.Drawing.Color.Transparent
        Me.Closemenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closemenu.Image = Global.Program.My.Resources.Resources.cross
        Me.Closemenu.ImageActive = Nothing
        Me.Closemenu.Location = New System.Drawing.Point(554, 11)
        Me.Closemenu.Name = "Closemenu"
        Me.Closemenu.Size = New System.Drawing.Size(18, 17)
        Me.Closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Closemenu.TabIndex = 13
        Me.Closemenu.TabStop = False
        Me.Closemenu.Zoom = 20
        '
        'Minimazemenu
        '
        Me.Minimazemenu.BackColor = System.Drawing.Color.Transparent
        Me.Minimazemenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimazemenu.Image = Global.Program.My.Resources.Resources.multi_tab
        Me.Minimazemenu.ImageActive = Nothing
        Me.Minimazemenu.Location = New System.Drawing.Point(530, 11)
        Me.Minimazemenu.Name = "Minimazemenu"
        Me.Minimazemenu.Size = New System.Drawing.Size(18, 17)
        Me.Minimazemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Minimazemenu.TabIndex = 14
        Me.Minimazemenu.TabStop = False
        Me.Minimazemenu.Zoom = 20
        '
        'Logout
        '
        Me.Logout.BackColor = System.Drawing.Color.Transparent
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Image = Global.Program.My.Resources.Resources.logout
        Me.Logout.ImageActive = Nothing
        Me.Logout.Location = New System.Drawing.Point(509, 11)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(18, 17)
        Me.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logout.TabIndex = 15
        Me.Logout.TabStop = False
        Me.Logout.Zoom = 20
        '
        'ProgMenu_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 280)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProgMenu_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProgMenu_Admin"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.Closemenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimazemenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents PanelMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Closemenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Bt_DataKondisi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bt_Historical As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Minimazemenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Logout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Bt_Grafik As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Bt_AddIc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse4 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse5 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse6 As Bunifu.Framework.UI.BunifuElipse
End Class
