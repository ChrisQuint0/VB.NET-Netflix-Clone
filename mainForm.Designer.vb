<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnGetStarted = New System.Windows.Forms.Button()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.btnStrangerThings = New System.Windows.Forms.Button()
        Me.btnEmily = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnBreaking = New System.Windows.Forms.Button()
        Me.btnBehind = New System.Windows.Forms.Button()
        Me.btnPeaky = New System.Windows.Forms.Button()
        Me.btnDropDown = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.btnDropUp = New System.Windows.Forms.Button()
        Me.picStrangerSelected = New System.Windows.Forms.PictureBox()
        Me.btnPlayStranger = New System.Windows.Forms.Button()
        Me.btnStopStranger = New System.Windows.Forms.Button()
        Me.videoPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.picEmilySelected = New System.Windows.Forms.PictureBox()
        Me.picPeakySelected = New System.Windows.Forms.PictureBox()
        Me.picBehindSelected = New System.Windows.Forms.PictureBox()
        Me.picOrangeSelected = New System.Windows.Forms.PictureBox()
        Me.picBreakingSelected = New System.Windows.Forms.PictureBox()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStrangerSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEmilySelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPeakySelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBehindSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrangeSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBreakingSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.BackgroundImage = CType(resources.GetObject("picMain.BackgroundImage"), System.Drawing.Image)
        Me.picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picMain.Location = New System.Drawing.Point(-9, -31)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(1080, 566)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackgroundImage = CType(resources.GetObject("btnSignUp.BackgroundImage"), System.Drawing.Image)
        Me.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Location = New System.Drawing.Point(952, 14)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(72, 30)
        Me.btnSignUp.TabIndex = 1
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'btnGetStarted
        '
        Me.btnGetStarted.BackgroundImage = CType(resources.GetObject("btnGetStarted.BackgroundImage"), System.Drawing.Image)
        Me.btnGetStarted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGetStarted.FlatAppearance.BorderSize = 0
        Me.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetStarted.Location = New System.Drawing.Point(443, 359)
        Me.btnGetStarted.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGetStarted.Name = "btnGetStarted"
        Me.btnGetStarted.Size = New System.Drawing.Size(183, 47)
        Me.btnGetStarted.TabIndex = 2
        Me.btnGetStarted.UseVisualStyleBackColor = True
        '
        'picHome
        '
        Me.picHome.BackgroundImage = CType(resources.GetObject("picHome.BackgroundImage"), System.Drawing.Image)
        Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHome.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHome.Location = New System.Drawing.Point(-9, -31)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(1080, 566)
        Me.picHome.TabIndex = 3
        Me.picHome.TabStop = False
        Me.picHome.Visible = False
        '
        'btnStrangerThings
        '
        Me.btnStrangerThings.BackColor = System.Drawing.Color.Transparent
        Me.btnStrangerThings.BackgroundImage = CType(resources.GetObject("btnStrangerThings.BackgroundImage"), System.Drawing.Image)
        Me.btnStrangerThings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStrangerThings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStrangerThings.FlatAppearance.BorderSize = 0
        Me.btnStrangerThings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStrangerThings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStrangerThings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStrangerThings.Location = New System.Drawing.Point(26, 337)
        Me.btnStrangerThings.Name = "btnStrangerThings"
        Me.btnStrangerThings.Size = New System.Drawing.Size(313, 179)
        Me.btnStrangerThings.TabIndex = 4
        Me.btnStrangerThings.UseVisualStyleBackColor = False
        Me.btnStrangerThings.Visible = False
        '
        'btnEmily
        '
        Me.btnEmily.BackColor = System.Drawing.Color.Transparent
        Me.btnEmily.BackgroundImage = CType(resources.GetObject("btnEmily.BackgroundImage"), System.Drawing.Image)
        Me.btnEmily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmily.FlatAppearance.BorderSize = 0
        Me.btnEmily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEmily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEmily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmily.Location = New System.Drawing.Point(27, 106)
        Me.btnEmily.Name = "btnEmily"
        Me.btnEmily.Size = New System.Drawing.Size(313, 179)
        Me.btnEmily.TabIndex = 5
        Me.btnEmily.UseVisualStyleBackColor = False
        Me.btnEmily.Visible = False
        '
        'btnOrange
        '
        Me.btnOrange.BackColor = System.Drawing.Color.Transparent
        Me.btnOrange.BackgroundImage = CType(resources.GetObject("btnOrange.BackgroundImage"), System.Drawing.Image)
        Me.btnOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrange.FlatAppearance.BorderSize = 0
        Me.btnOrange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOrange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrange.Location = New System.Drawing.Point(379, 106)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(313, 179)
        Me.btnOrange.TabIndex = 6
        Me.btnOrange.UseVisualStyleBackColor = False
        Me.btnOrange.Visible = False
        '
        'btnBreaking
        '
        Me.btnBreaking.BackColor = System.Drawing.Color.Transparent
        Me.btnBreaking.BackgroundImage = CType(resources.GetObject("btnBreaking.BackgroundImage"), System.Drawing.Image)
        Me.btnBreaking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBreaking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBreaking.FlatAppearance.BorderSize = 0
        Me.btnBreaking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBreaking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBreaking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreaking.Location = New System.Drawing.Point(374, 335)
        Me.btnBreaking.Name = "btnBreaking"
        Me.btnBreaking.Size = New System.Drawing.Size(313, 179)
        Me.btnBreaking.TabIndex = 7
        Me.btnBreaking.UseVisualStyleBackColor = False
        Me.btnBreaking.Visible = False
        '
        'btnBehind
        '
        Me.btnBehind.BackColor = System.Drawing.Color.Transparent
        Me.btnBehind.BackgroundImage = CType(resources.GetObject("btnBehind.BackgroundImage"), System.Drawing.Image)
        Me.btnBehind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBehind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBehind.FlatAppearance.BorderSize = 0
        Me.btnBehind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBehind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBehind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBehind.Location = New System.Drawing.Point(728, 106)
        Me.btnBehind.Name = "btnBehind"
        Me.btnBehind.Size = New System.Drawing.Size(313, 179)
        Me.btnBehind.TabIndex = 8
        Me.btnBehind.UseVisualStyleBackColor = False
        Me.btnBehind.Visible = False
        '
        'btnPeaky
        '
        Me.btnPeaky.BackColor = System.Drawing.Color.Transparent
        Me.btnPeaky.BackgroundImage = CType(resources.GetObject("btnPeaky.BackgroundImage"), System.Drawing.Image)
        Me.btnPeaky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPeaky.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPeaky.FlatAppearance.BorderSize = 0
        Me.btnPeaky.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPeaky.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPeaky.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPeaky.Location = New System.Drawing.Point(729, 337)
        Me.btnPeaky.Name = "btnPeaky"
        Me.btnPeaky.Size = New System.Drawing.Size(313, 179)
        Me.btnPeaky.TabIndex = 9
        Me.btnPeaky.UseVisualStyleBackColor = False
        Me.btnPeaky.Visible = False
        '
        'btnDropDown
        '
        Me.btnDropDown.BackColor = System.Drawing.Color.Transparent
        Me.btnDropDown.BackgroundImage = CType(resources.GetObject("btnDropDown.BackgroundImage"), System.Drawing.Image)
        Me.btnDropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDropDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDropDown.FlatAppearance.BorderSize = 0
        Me.btnDropDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDropDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDropDown.Location = New System.Drawing.Point(988, 10)
        Me.btnDropDown.Name = "btnDropDown"
        Me.btnDropDown.Size = New System.Drawing.Size(24, 24)
        Me.btnDropDown.TabIndex = 10
        Me.btnDropDown.UseVisualStyleBackColor = False
        Me.btnDropDown.Visible = False
        '
        'btnHome
        '
        Me.btnHome.AutoSize = True
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(159, 15)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(68, 24)
        Me.btnHome.TabIndex = 11
        Me.btnHome.Text = "Home"
        Me.btnHome.Visible = False
        '
        'btnLogOut
        '
        Me.btnLogOut.AutoSize = True
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(230, 15)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(91, 24)
        Me.btnLogOut.TabIndex = 12
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUserName.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.Location = New System.Drawing.Point(823, 57)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(189, 24)
        Me.lblUserName.TabIndex = 13
        Me.lblUserName.Text = "User: ChrisQuinto"
        Me.lblUserName.Visible = False
        '
        'btnDropUp
        '
        Me.btnDropUp.BackColor = System.Drawing.Color.Transparent
        Me.btnDropUp.BackgroundImage = CType(resources.GetObject("btnDropUp.BackgroundImage"), System.Drawing.Image)
        Me.btnDropUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDropUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDropUp.FlatAppearance.BorderSize = 0
        Me.btnDropUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDropUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDropUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDropUp.Location = New System.Drawing.Point(988, 10)
        Me.btnDropUp.Name = "btnDropUp"
        Me.btnDropUp.Size = New System.Drawing.Size(24, 24)
        Me.btnDropUp.TabIndex = 14
        Me.btnDropUp.UseVisualStyleBackColor = False
        Me.btnDropUp.Visible = False
        '
        'picStrangerSelected
        '
        Me.picStrangerSelected.BackgroundImage = CType(resources.GetObject("picStrangerSelected.BackgroundImage"), System.Drawing.Image)
        Me.picStrangerSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStrangerSelected.Location = New System.Drawing.Point(-9, -31)
        Me.picStrangerSelected.Name = "picStrangerSelected"
        Me.picStrangerSelected.Size = New System.Drawing.Size(1080, 566)
        Me.picStrangerSelected.TabIndex = 15
        Me.picStrangerSelected.TabStop = False
        Me.picStrangerSelected.Visible = False
        '
        'btnPlayStranger
        '
        Me.btnPlayStranger.BackColor = System.Drawing.Color.White
        Me.btnPlayStranger.BackgroundImage = CType(resources.GetObject("btnPlayStranger.BackgroundImage"), System.Drawing.Image)
        Me.btnPlayStranger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlayStranger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayStranger.FlatAppearance.BorderSize = 0
        Me.btnPlayStranger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayStranger.Location = New System.Drawing.Point(672, 271)
        Me.btnPlayStranger.Name = "btnPlayStranger"
        Me.btnPlayStranger.Size = New System.Drawing.Size(135, 42)
        Me.btnPlayStranger.TabIndex = 1
        Me.btnPlayStranger.UseVisualStyleBackColor = False
        Me.btnPlayStranger.Visible = False
        '
        'btnStopStranger
        '
        Me.btnStopStranger.BackColor = System.Drawing.Color.Transparent
        Me.btnStopStranger.BackgroundImage = CType(resources.GetObject("btnStopStranger.BackgroundImage"), System.Drawing.Image)
        Me.btnStopStranger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStopStranger.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopStranger.FlatAppearance.BorderSize = 0
        Me.btnStopStranger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStopStranger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStopStranger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopStranger.Location = New System.Drawing.Point(827, 271)
        Me.btnStopStranger.Name = "btnStopStranger"
        Me.btnStopStranger.Size = New System.Drawing.Size(43, 41)
        Me.btnStopStranger.TabIndex = 2
        Me.btnStopStranger.UseVisualStyleBackColor = False
        Me.btnStopStranger.Visible = False
        '
        'videoPlayer
        '
        Me.videoPlayer.Enabled = True
        Me.videoPlayer.Location = New System.Drawing.Point(27, 109)
        Me.videoPlayer.Name = "videoPlayer"
        Me.videoPlayer.OcxState = CType(resources.GetObject("videoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.videoPlayer.Size = New System.Drawing.Size(609, 354)
        Me.videoPlayer.TabIndex = 18
        '
        'picEmilySelected
        '
        Me.picEmilySelected.BackgroundImage = CType(resources.GetObject("picEmilySelected.BackgroundImage"), System.Drawing.Image)
        Me.picEmilySelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEmilySelected.Location = New System.Drawing.Point(-9, -31)
        Me.picEmilySelected.Name = "picEmilySelected"
        Me.picEmilySelected.Size = New System.Drawing.Size(1080, 566)
        Me.picEmilySelected.TabIndex = 19
        Me.picEmilySelected.TabStop = False
        Me.picEmilySelected.Visible = False
        '
        'picPeakySelected
        '
        Me.picPeakySelected.BackgroundImage = CType(resources.GetObject("picPeakySelected.BackgroundImage"), System.Drawing.Image)
        Me.picPeakySelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPeakySelected.Location = New System.Drawing.Point(-9, -31)
        Me.picPeakySelected.Name = "picPeakySelected"
        Me.picPeakySelected.Size = New System.Drawing.Size(1080, 566)
        Me.picPeakySelected.TabIndex = 23
        Me.picPeakySelected.TabStop = False
        Me.picPeakySelected.Visible = False
        '
        'picBehindSelected
        '
        Me.picBehindSelected.BackgroundImage = CType(resources.GetObject("picBehindSelected.BackgroundImage"), System.Drawing.Image)
        Me.picBehindSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBehindSelected.Location = New System.Drawing.Point(-9, -31)
        Me.picBehindSelected.Name = "picBehindSelected"
        Me.picBehindSelected.Size = New System.Drawing.Size(1080, 566)
        Me.picBehindSelected.TabIndex = 24
        Me.picBehindSelected.TabStop = False
        Me.picBehindSelected.Visible = False
        '
        'picOrangeSelected
        '
        Me.picOrangeSelected.BackgroundImage = CType(resources.GetObject("picOrangeSelected.BackgroundImage"), System.Drawing.Image)
        Me.picOrangeSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picOrangeSelected.Location = New System.Drawing.Point(-9, -31)
        Me.picOrangeSelected.Name = "picOrangeSelected"
        Me.picOrangeSelected.Size = New System.Drawing.Size(1080, 566)
        Me.picOrangeSelected.TabIndex = 25
        Me.picOrangeSelected.TabStop = False
        Me.picOrangeSelected.Visible = False
        '
        'picBreakingSelected
        '
        Me.picBreakingSelected.BackgroundImage = CType(resources.GetObject("picBreakingSelected.BackgroundImage"), System.Drawing.Image)
        Me.picBreakingSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBreakingSelected.Location = New System.Drawing.Point(-9, -31)
        Me.picBreakingSelected.Name = "picBreakingSelected"
        Me.picBreakingSelected.Size = New System.Drawing.Size(1080, 566)
        Me.picBreakingSelected.TabIndex = 26
        Me.picBreakingSelected.TabStop = False
        Me.picBreakingSelected.Visible = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1064, 527)
        Me.Controls.Add(Me.btnStopStranger)
        Me.Controls.Add(Me.btnPlayStranger)
        Me.Controls.Add(Me.picBreakingSelected)
        Me.Controls.Add(Me.picOrangeSelected)
        Me.Controls.Add(Me.picBehindSelected)
        Me.Controls.Add(Me.picPeakySelected)
        Me.Controls.Add(Me.picEmilySelected)
        Me.Controls.Add(Me.picStrangerSelected)
        Me.Controls.Add(Me.btnDropDown)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnOrange)
        Me.Controls.Add(Me.btnPeaky)
        Me.Controls.Add(Me.btnBreaking)
        Me.Controls.Add(Me.btnStrangerThings)
        Me.Controls.Add(Me.btnBehind)
        Me.Controls.Add(Me.btnEmily)
        Me.Controls.Add(Me.picHome)
        Me.Controls.Add(Me.btnGetStarted)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.btnDropUp)
        Me.Controls.Add(Me.videoPlayer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "mainForm"
        Me.Text = "Netflix Clone"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStrangerSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.videoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEmilySelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPeakySelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBehindSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrangeSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBreakingSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMain As PictureBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnGetStarted As Button
    Friend WithEvents picHome As PictureBox
    Friend WithEvents btnStrangerThings As Button
    Friend WithEvents btnEmily As Button
    Friend WithEvents btnOrange As Button
    Friend WithEvents btnBreaking As Button
    Friend WithEvents btnBehind As Button
    Friend WithEvents btnPeaky As Button
    Friend WithEvents btnDropDown As Button
    Friend WithEvents btnHome As Label
    Friend WithEvents btnLogOut As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents btnDropUp As Button
    Friend WithEvents picStrangerSelected As PictureBox
    Friend WithEvents btnPlayStranger As Button
    Friend WithEvents btnStopStranger As Button
    Friend WithEvents videoPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents picEmilySelected As PictureBox
    Friend WithEvents picPeakySelected As PictureBox
    Friend WithEvents picBehindSelected As PictureBox
    Friend WithEvents picOrangeSelected As PictureBox
    Friend WithEvents picBreakingSelected As PictureBox
End Class
