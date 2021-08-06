<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GagalLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim Bt_Wrong As Bunifu.Framework.UI.BunifuFlatButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GagalLogin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PanelLoginSalah = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Close2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Bt_Wrong = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelLoginSalah.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.Close2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bt_Wrong
        '
        Bt_Wrong.Activecolor = System.Drawing.Color.White
        Bt_Wrong.BackColor = System.Drawing.Color.White
        Bt_Wrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Bt_Wrong.BorderRadius = 7
        Bt_Wrong.ButtonText = "OK"
        Bt_Wrong.Cursor = System.Windows.Forms.Cursors.Hand
        Bt_Wrong.DisabledColor = System.Drawing.Color.White
        Bt_Wrong.ForeColor = System.Drawing.Color.White
        Bt_Wrong.Iconcolor = System.Drawing.Color.Transparent
        Bt_Wrong.Iconimage = Nothing
        Bt_Wrong.Iconimage_right = Nothing
        Bt_Wrong.Iconimage_right_Selected = Nothing
        Bt_Wrong.Iconimage_Selected = Nothing
        Bt_Wrong.IconMarginLeft = 0
        Bt_Wrong.IconMarginRight = 0
        Bt_Wrong.IconRightVisible = True
        Bt_Wrong.IconRightZoom = 0R
        Bt_Wrong.IconVisible = True
        Bt_Wrong.IconZoom = 0R
        Bt_Wrong.IsTab = False
        Bt_Wrong.Location = New System.Drawing.Point(94, 71)
        Bt_Wrong.Name = "Bt_Wrong"
        Bt_Wrong.Normalcolor = System.Drawing.Color.White
        Bt_Wrong.OnHovercolor = System.Drawing.Color.White
        Bt_Wrong.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(252, Byte), Integer))
        Bt_Wrong.selected = False
        Bt_Wrong.Size = New System.Drawing.Size(116, 29)
        Bt_Wrong.TabIndex = 9
        Bt_Wrong.Text = "OK"
        Bt_Wrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Bt_Wrong.Textcolor = System.Drawing.Color.Black
        Bt_Wrong.TextFont = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler Bt_Wrong.Click, AddressOf Me.Bt_Wrong_Click
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PanelLoginSalah
        '
        Me.PanelLoginSalah.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelLoginSalah.BackgroundImage = CType(resources.GetObject("PanelLoginSalah.BackgroundImage"), System.Drawing.Image)
        Me.PanelLoginSalah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLoginSalah.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelLoginSalah.Controls.Add(Me.BunifuCustomLabel3)
        Me.PanelLoginSalah.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelLoginSalah.Controls.Add(Me.Close2)
        Me.PanelLoginSalah.Controls.Add(Me.PictureBox1)
        Me.PanelLoginSalah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLoginSalah.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLoginSalah.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLoginSalah.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLoginSalah.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLoginSalah.Location = New System.Drawing.Point(0, 0)
        Me.PanelLoginSalah.Name = "PanelLoginSalah"
        Me.PanelLoginSalah.Quality = 10
        Me.PanelLoginSalah.Size = New System.Drawing.Size(380, 158)
        Me.PanelLoginSalah.TabIndex = 1
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Bt_Wrong)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(158, 44)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(215, 103)
        Me.BunifuGradientPanel1.TabIndex = 13
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(3, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(215, 37)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Password Salah"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe Script", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(13, 24)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(146, 17)
        Me.BunifuCustomLabel3.TabIndex = 12
        Me.BunifuCustomLabel3.Text = "Inspection Check wrong"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 3)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(87, 25)
        Me.BunifuCustomLabel2.TabIndex = 10
        Me.BunifuCustomLabel2.Text = "L'ORЀAL"
        '
        'Close2
        '
        Me.Close2.BackColor = System.Drawing.Color.Transparent
        Me.Close2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close2.Image = Global.Program.My.Resources.Resources.cross
        Me.Close2.ImageActive = Nothing
        Me.Close2.Location = New System.Drawing.Point(355, 12)
        Me.Close2.Name = "Close2"
        Me.Close2.Size = New System.Drawing.Size(18, 17)
        Me.Close2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Close2.TabIndex = 8
        Me.Close2.TabStop = False
        Me.Close2.Zoom = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Program.My.Resources.Resources.wrong_password
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.BunifuGradientPanel1
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.PictureBox1
        '
        'GagalLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 158)
        Me.Controls.Add(Me.PanelLoginSalah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GagalLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GagalLogin"
        Me.PanelLoginSalah.ResumeLayout(False)
        Me.PanelLoginSalah.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.Close2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLoginSalah As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Close2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
End Class
