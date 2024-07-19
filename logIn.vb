Public Class logIn
    Private WithEvents timerSuccessLogIn As New Timer()
    Private mainFormInstance As mainForm
    Public Sub New(mainFormRef As mainForm)

        ' This call is required by the designer.
        InitializeComponent()

        mainFormInstance = mainFormRef
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub logIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picLogInSuccess.Visible = False
        lblUserNameLogIn.Visible = False
        btnGoBack.BringToFront()

        timerSuccessLogIn.Interval = 5000
        AddHandler timerSuccessLogIn.Tick, AddressOf TimerSuccessLogIn_Tick
    End Sub

    Private Sub TimerSuccessLogIn_Tick(sender As Object, e As EventArgs)

        timerSuccessLogIn.Stop()
        picLogInSuccess.Visible = False
        lblUserNameLogIn.Visible = False
        Hide()
        mainFormInstance.lblUserName.Text = "User: " & txtUserNameLogIn.Text.ToLower

        txtUserNameLogIn.Clear()
        txtPasswordLogIn.Clear()


        mainFormInstance.btnEmily.Visible = True
        mainFormInstance.btnOrange.Visible = True
        mainFormInstance.btnBehind.Visible = True
        mainFormInstance.btnStrangerThings.Visible = True
        mainFormInstance.btnBreaking.Visible = True
        mainFormInstance.btnPeaky.Visible = True
        mainFormInstance.btnHome.Visible = True
        mainFormInstance.btnLogOut.Visible = True
        mainFormInstance.btnDropDown.Visible = True
        mainFormInstance.picHome.Visible = True

        mainFormInstance.picHome.BringToFront()
        mainFormInstance.btnEmily.BringToFront()
        mainFormInstance.btnOrange.BringToFront()
        mainFormInstance.btnBehind.BringToFront()
        mainFormInstance.btnStrangerThings.BringToFront()
        mainFormInstance.btnBreaking.BringToFront()
        mainFormInstance.btnPeaky.BringToFront()
        mainFormInstance.btnHome.BringToFront()
        mainFormInstance.btnLogOut.BringToFront()
        mainFormInstance.btnDropDown.BringToFront()


    End Sub
    Private Sub btnLogInSubmit_Click(sender As Object, e As EventArgs) Handles btnLogInSubmit.Click
        Dim username As String = txtUserNameLogIn.Text
        Dim password As String = txtPasswordLogIn.Text

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MsgBox("Please Enter Both Username and Password")
        End If


        Dim filePath As String = "resources/users.txt"
        Dim validUser As Boolean = False

        If System.IO.File.Exists(filePath) Then
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)
            For Each line In lines
                Dim parts() As String = line.Split(","c)
                If parts(0).ToLower = username.ToLower And parts(1) = password Then
                    validUser = True
                ElseIf parts(0) = username And Not parts(1) = password Then
                    MsgBox("Password is not correct")
                    Exit Sub
                End If
            Next
        End If

        If validUser Then
            btnGoBack.Visible = False
            picLogInSuccess.Visible = True

            lblUserNameLogIn.Text = txtUserNameLogIn.Text.ToLower
            lblUserNameLogIn.Location = New Point(530 - lblUserNameLogIn.Width / 2, lblUserNameLogIn.Location.Y)
            lblUserNameLogIn.Visible = True

            timerSuccessLogIn.Start()
        Else
            MsgBox("User is not in the database.")
        End If




    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Hide()
    End Sub
End Class