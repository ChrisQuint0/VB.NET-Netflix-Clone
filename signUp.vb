Public Class signUp

    Private WithEvents timerSuccessSignUp As New Timer()

    Private Sub signUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picSignUpSuccess.Visible = False
        lblNewSignUpUser.Visible = False
        btnGoBack.BringToFront()
        timerSuccessSignUp.Interval = 5000 ' Set timer interval to 3 seconds
        AddHandler timerSuccessSignUp.Tick, AddressOf TimerSuccessSignUp_Tick

        'Dim labelCoordinates As Point = Label1.Location
        'Dim message As String = "X: " & labelCoordinates.X & " Y: " & labelCoordinates.Y
        'MsgBox(message)
    End Sub

    Private Sub TimerSuccessSignUp_Tick(sender As Object, e As EventArgs)
        timerSuccessSignUp.Stop()
        picSignUpSuccess.Visible = False
        lblNewSignUpUser.Visible = False
        Hide()
        txtUsernameSignUp.Clear()
        txtPasswordSignUp.Clear()
    End Sub

    Private Sub btnSignUpSubmit_Click(sender As Object, e As EventArgs) Handles btnSignUpSubmit.Click
        Dim username As String = txtUsernameSignUp.Text.ToLower
        Dim password As String = txtPasswordSignUp.Text

        If String.IsNullOrWhiteSpace(username) Or String.IsNullOrWhiteSpace(password) Then
            MsgBox("Please enter both username and password.")
            Return
        End If



        Dim filePath As String = "resources/users.txt"
        Dim credentials As String = username.ToLower & "," & password

        If System.IO.File.Exists(filePath) Then
            Dim lines() As String = System.IO.File.ReadAllLines(filePath)
            For Each line In lines
                Dim parts() As String = line.Split(","c)
                If parts(0) = username Then
                    MsgBox("Username already exists")
                    Exit Sub
                End If
            Next
        End If

        Using writer As New System.IO.StreamWriter(filePath, True)
            writer.WriteLine(credentials)
        End Using





        btnGoBack.Visible = False
        picSignUpSuccess.Visible = True

        lblNewSignUpUser.Text = "User: " & txtUsernameSignUp.Text.ToLower
        lblNewSignUpUser.Location = New Point(526 - lblNewSignUpUser.Width / 2, lblNewSignUpUser.Location.Y)
        lblNewSignUpUser.Visible = True

        timerSuccessSignUp.Start()

    End Sub

    Private Sub txtPasswordSignUp_TextChanged(sender As Object, e As EventArgs) Handles txtPasswordSignUp.TextChanged

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Hide()
    End Sub


End Class