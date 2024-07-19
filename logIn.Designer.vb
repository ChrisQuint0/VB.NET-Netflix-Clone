<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logIn))
        Me.picLogIn = New System.Windows.Forms.PictureBox()
        Me.txtUserNameLogIn = New System.Windows.Forms.TextBox()
        Me.txtPasswordLogIn = New System.Windows.Forms.TextBox()
        Me.btnLogInSubmit = New System.Windows.Forms.Button()
        Me.picLogInSuccess = New System.Windows.Forms.PictureBox()
        Me.lblUserNameLogIn = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Label()
        CType(Me.picLogIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogInSuccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogIn
        '
        Me.picLogIn.BackgroundImage = CType(resources.GetObject("picLogIn.BackgroundImage"), System.Drawing.Image)
        Me.picLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogIn.Location = New System.Drawing.Point(-9, -31)
        Me.picLogIn.Name = "picLogIn"
        Me.picLogIn.Size = New System.Drawing.Size(1080, 566)
        Me.picLogIn.TabIndex = 0
        Me.picLogIn.TabStop = False
        '
        'txtUserNameLogIn
        '
        Me.txtUserNameLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserNameLogIn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserNameLogIn.Location = New System.Drawing.Point(410, 204)
        Me.txtUserNameLogIn.MaxLength = 12
        Me.txtUserNameLogIn.Name = "txtUserNameLogIn"
        Me.txtUserNameLogIn.Size = New System.Drawing.Size(259, 25)
        Me.txtUserNameLogIn.TabIndex = 1
        '
        'txtPasswordLogIn
        '
        Me.txtPasswordLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordLogIn.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordLogIn.Location = New System.Drawing.Point(410, 300)
        Me.txtPasswordLogIn.MaxLength = 12
        Me.txtPasswordLogIn.Name = "txtPasswordLogIn"
        Me.txtPasswordLogIn.Size = New System.Drawing.Size(259, 25)
        Me.txtPasswordLogIn.TabIndex = 2
        '
        'btnLogInSubmit
        '
        Me.btnLogInSubmit.BackgroundImage = CType(resources.GetObject("btnLogInSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnLogInSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogInSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogInSubmit.FlatAppearance.BorderSize = 0
        Me.btnLogInSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogInSubmit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogInSubmit.Location = New System.Drawing.Point(443, 360)
        Me.btnLogInSubmit.Name = "btnLogInSubmit"
        Me.btnLogInSubmit.Size = New System.Drawing.Size(182, 46)
        Me.btnLogInSubmit.TabIndex = 3
        Me.btnLogInSubmit.UseVisualStyleBackColor = True
        '
        'picLogInSuccess
        '
        Me.picLogInSuccess.BackgroundImage = CType(resources.GetObject("picLogInSuccess.BackgroundImage"), System.Drawing.Image)
        Me.picLogInSuccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogInSuccess.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.picLogInSuccess.Location = New System.Drawing.Point(-9, -31)
        Me.picLogInSuccess.Name = "picLogInSuccess"
        Me.picLogInSuccess.Size = New System.Drawing.Size(1080, 566)
        Me.picLogInSuccess.TabIndex = 4
        Me.picLogInSuccess.TabStop = False
        '
        'lblUserNameLogIn
        '
        Me.lblUserNameLogIn.AutoSize = True
        Me.lblUserNameLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lblUserNameLogIn.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNameLogIn.ForeColor = System.Drawing.Color.White
        Me.lblUserNameLogIn.Location = New System.Drawing.Point(418, 343)
        Me.lblUserNameLogIn.Name = "lblUserNameLogIn"
        Me.lblUserNameLogIn.Size = New System.Drawing.Size(225, 37)
        Me.lblUserNameLogIn.TabIndex = 5
        Me.lblUserNameLogIn.Text = "ChrisQuintoC"
        '
        'btnGoBack
        '
        Me.btnGoBack.AutoSize = True
        Me.btnGoBack.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBack.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoBack.ForeColor = System.Drawing.Color.White
        Me.btnGoBack.Location = New System.Drawing.Point(152, 28)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(96, 24)
        Me.btnGoBack.TabIndex = 7
        Me.btnGoBack.Text = "Go Back"
        '
        'logIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 527)
        Me.Controls.Add(Me.lblUserNameLogIn)
        Me.Controls.Add(Me.picLogInSuccess)
        Me.Controls.Add(Me.btnLogInSubmit)
        Me.Controls.Add(Me.txtPasswordLogIn)
        Me.Controls.Add(Me.txtUserNameLogIn)
        Me.Controls.Add(Me.picLogIn)
        Me.Controls.Add(Me.btnGoBack)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "logIn"
        Me.Text = "Log In"
        CType(Me.picLogIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogInSuccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogIn As PictureBox
    Friend WithEvents txtUserNameLogIn As TextBox
    Friend WithEvents txtPasswordLogIn As TextBox
    Friend WithEvents btnLogInSubmit As Button
    Friend WithEvents picLogInSuccess As PictureBox
    Friend WithEvents lblUserNameLogIn As Label
    Friend WithEvents btnGoBack As Label
End Class
