<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signUp))
        Me.picSignUp = New System.Windows.Forms.PictureBox()
        Me.txtUsernameSignUp = New System.Windows.Forms.TextBox()
        Me.txtPasswordSignUp = New System.Windows.Forms.TextBox()
        Me.btnSignUpSubmit = New System.Windows.Forms.Button()
        Me.picSignUpSuccess = New System.Windows.Forms.PictureBox()
        Me.lblNewSignUpUser = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Label()
        CType(Me.picSignUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignUpSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSignUp
        '
        Me.picSignUp.BackgroundImage = CType(resources.GetObject("picSignUp.BackgroundImage"), System.Drawing.Image)
        Me.picSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSignUp.Location = New System.Drawing.Point(-9, -31)
        Me.picSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.picSignUp.Name = "picSignUp"
        Me.picSignUp.Size = New System.Drawing.Size(1080, 566)
        Me.picSignUp.TabIndex = 0
        Me.picSignUp.TabStop = False
        '
        'txtUsernameSignUp
        '
        Me.txtUsernameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameSignUp.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameSignUp.Location = New System.Drawing.Point(405, 201)
        Me.txtUsernameSignUp.MaxLength = 12
        Me.txtUsernameSignUp.Name = "txtUsernameSignUp"
        Me.txtUsernameSignUp.Size = New System.Drawing.Size(268, 25)
        Me.txtUsernameSignUp.TabIndex = 1
        '
        'txtPasswordSignUp
        '
        Me.txtPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordSignUp.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordSignUp.Location = New System.Drawing.Point(405, 300)
        Me.txtPasswordSignUp.MaxLength = 12
        Me.txtPasswordSignUp.Name = "txtPasswordSignUp"
        Me.txtPasswordSignUp.Size = New System.Drawing.Size(268, 25)
        Me.txtPasswordSignUp.TabIndex = 2
        '
        'btnSignUpSubmit
        '
        Me.btnSignUpSubmit.BackgroundImage = CType(resources.GetObject("btnSignUpSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSignUpSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignUpSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUpSubmit.FlatAppearance.BorderSize = 0
        Me.btnSignUpSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUpSubmit.Location = New System.Drawing.Point(442, 359)
        Me.btnSignUpSubmit.Name = "btnSignUpSubmit"
        Me.btnSignUpSubmit.Size = New System.Drawing.Size(183, 49)
        Me.btnSignUpSubmit.TabIndex = 3
        Me.btnSignUpSubmit.UseVisualStyleBackColor = True
        '
        'picSignUpSuccess
        '
        Me.picSignUpSuccess.BackgroundImage = CType(resources.GetObject("picSignUpSuccess.BackgroundImage"), System.Drawing.Image)
        Me.picSignUpSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSignUpSuccess.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.picSignUpSuccess.Location = New System.Drawing.Point(-9, -31)
        Me.picSignUpSuccess.Name = "picSignUpSuccess"
        Me.picSignUpSuccess.Size = New System.Drawing.Size(1080, 566)
        Me.picSignUpSuccess.TabIndex = 4
        Me.picSignUpSuccess.TabStop = False
        '
        'lblNewSignUpUser
        '
        Me.lblNewSignUpUser.AutoSize = True
        Me.lblNewSignUpUser.BackColor = System.Drawing.Color.Transparent
        Me.lblNewSignUpUser.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewSignUpUser.ForeColor = System.Drawing.Color.White
        Me.lblNewSignUpUser.Location = New System.Drawing.Point(373, 390)
        Me.lblNewSignUpUser.Name = "lblNewSignUpUser"
        Me.lblNewSignUpUser.Size = New System.Drawing.Size(315, 37)
        Me.lblNewSignUpUser.TabIndex = 5
        Me.lblNewSignUpUser.Text = "User: ChrisQuintoC"
        '
        'btnGoBack
        '
        Me.btnGoBack.AutoSize = True
        Me.btnGoBack.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBack.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.ForeColor = System.Drawing.Color.White
        Me.btnGoBack.Location = New System.Drawing.Point(152, 26)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(96, 24)
        Me.btnGoBack.TabIndex = 6
        Me.btnGoBack.Text = "Go Back"
        '
        'signUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 527)
        Me.Controls.Add(Me.lblNewSignUpUser)
        Me.Controls.Add(Me.picSignUpSuccess)
        Me.Controls.Add(Me.btnSignUpSubmit)
        Me.Controls.Add(Me.txtPasswordSignUp)
        Me.Controls.Add(Me.txtUsernameSignUp)
        Me.Controls.Add(Me.picSignUp)
        Me.Controls.Add(Me.btnGoBack)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "signUp"
        Me.Text = "Sign Up"
        CType(Me.picSignUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignUpSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSignUp As PictureBox
    Friend WithEvents txtUsernameSignUp As TextBox
    Friend WithEvents txtPasswordSignUp As TextBox
    Friend WithEvents btnSignUpSubmit As Button
    Friend WithEvents picSignUpSuccess As PictureBox
    Friend WithEvents lblNewSignUpUser As Label
    Friend WithEvents btnGoBack As Label
End Class
