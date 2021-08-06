<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim Bt_Login As Bunifu.Framework.UI.BunifuFlatButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelLogin = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Tb_Pwd = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Tb_Usr = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Minimaze = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Bt_Login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelLogin.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimaze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bt_Login
        '
        Bt_Login.Activecolor = System.Drawing.Color.White
        Bt_Login.BackColor = System.Drawing.Color.White
        Bt_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Bt_Login.BorderRadius = 7
        Bt_Login.ButtonText = "Login"
        Bt_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Bt_Login.DisabledColor = System.Drawing.Color.Black
        Bt_Login.ForeColor = System.Drawing.Color.White
        Bt_Login.Iconcolor = System.Drawing.Color.Transparent
        Bt_Login.Iconimage = Nothing
        Bt_Login.Iconimage_right = Nothing
        Bt_Login.Iconimage_right_Selected = Nothing
        Bt_Login.Iconimage_Selected = Nothing
        Bt_Login.IconMarginLeft = 0
        Bt_Login.IconMarginRight = 0
        Bt_Login.IconRightVisible = True
        Bt_Login.IconRightZoom = 0R
        Bt_Login.IconVisible = True
        Bt_Login.IconZoom = 0R
        Bt_Login.IsTab = False
        Bt_Login.Location = New System.Drawing.Point(7, 127)
        Bt_Login.Name = "Bt_Login"
        Bt_Login.Normalcolor = System.Drawing.Color.White
        Bt_Login.OnHovercolor = System.Drawing.Color.White
        Bt_Login.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(252, Byte), Integer))
        Bt_Login.selected = False
        Bt_Login.Size = New System.Drawing.Size(197, 26)
        Bt_Login.TabIndex = 3
        Bt_Login.Text = "Login"
        Bt_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Bt_Login.Textcolor = System.Drawing.Color.Black
        Bt_Login.TextFont = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddHandler Bt_Login.Click, AddressOf Me.Bt_Login_Click
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelLogin.BackgroundImage = CType(resources.GetObject("PanelLogin.BackgroundImage"), System.Drawing.Image)
        Me.PanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogin.Controls.Add(Me.BunifuGradientPanel2)
        Me.PanelLogin.Controls.Add(Me.BunifuGradientPanel1)
        Me.PanelLogin.Controls.Add(Me.Minimaze)
        Me.PanelLogin.Controls.Add(Me.Close)
        Me.PanelLogin.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelLogin.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogin.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLogin.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLogin.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLogin.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Quality = 10
        Me.PanelLogin.Size = New System.Drawing.Size(400, 280)
        Me.PanelLogin.TabIndex = 0
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel2.Controls.Add(Me.Tb_Pwd)
        Me.BunifuGradientPanel2.Controls.Add(Bt_Login)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel2.Controls.Add(Me.Tb_Usr)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(184, 89)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(207, 159)
        Me.BunifuGradientPanel2.TabIndex = 14
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.White
        Me.BunifuImageButton1.Image = Global.Program.My.Resources.Resources.user__1_
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(7, 16)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(35, 26)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 9
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 0
        '
        'Tb_Pwd
        '
        Me.Tb_Pwd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb_Pwd.BackColor = System.Drawing.Color.White
        Me.Tb_Pwd.BorderColor = System.Drawing.Color.Transparent
        Me.Tb_Pwd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_Pwd.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Pwd.ForeColor = System.Drawing.Color.Black
        Me.Tb_Pwd.Location = New System.Drawing.Point(42, 48)
        Me.Tb_Pwd.Name = "Tb_Pwd"
        Me.Tb_Pwd.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Pwd.TabIndex = 2
        Me.Tb_Pwd.Text = "Password"
        Me.Tb_Pwd.UseSystemPasswordChar = True
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.White
        Me.BunifuImageButton2.Image = Global.Program.My.Resources.Resources.padlock
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(7, 48)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(35, 26)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 11
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 0
        '
        'Tb_Usr
        '
        Me.Tb_Usr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb_Usr.BackColor = System.Drawing.Color.White
        Me.Tb_Usr.BorderColor = System.Drawing.Color.Transparent
        Me.Tb_Usr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tb_Usr.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Usr.ForeColor = System.Drawing.Color.Black
        Me.Tb_Usr.Location = New System.Drawing.Point(42, 16)
        Me.Tb_Usr.Name = "Tb_Usr"
        Me.Tb_Usr.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Usr.TabIndex = 1
        Me.Tb_Usr.Text = "Username"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(12, 89)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(166, 159)
        Me.BunifuGradientPanel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Program.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(9, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Minimaze
        '
        Me.Minimaze.BackColor = System.Drawing.Color.Transparent
        Me.Minimaze.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Minimaze.Image = Global.Program.My.Resources.Resources.multi_tab
        Me.Minimaze.ImageActive = Nothing
        Me.Minimaze.Location = New System.Drawing.Point(355, 3)
        Me.Minimaze.Name = "Minimaze"
        Me.Minimaze.Size = New System.Drawing.Size(15, 15)
        Me.Minimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Minimaze.TabIndex = 12
        Me.Minimaze.TabStop = False
        Me.Minimaze.Zoom = 20
        '
        'Close
        '
        Me.Close.BackColor = System.Drawing.Color.Transparent
        Me.Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close.Image = Global.Program.My.Resources.Resources.cross
        Me.Close.ImageActive = Nothing
        Me.Close.Location = New System.Drawing.Point(376, 3)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(15, 15)
        Me.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Close.TabIndex = 7
        Me.Close.TabStop = False
        Me.Close.Zoom = 20
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe Script", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(12, 53)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(157, 20)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Inspection Check Login"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(7, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(176, 54)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "L'ORЀAL"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 10
        Me.BunifuElipse2.TargetControl = Me.BunifuGradientPanel1
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 10
        Me.BunifuElipse3.TargetControl = Me.BunifuGradientPanel2
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 280)
        Me.Controls.Add(Me.PanelLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(900, 70)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimaze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelLogin As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Tb_Usr As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Tb_Pwd As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Minimaze As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
End Class
