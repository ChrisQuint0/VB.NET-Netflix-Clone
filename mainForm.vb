Imports System.Net.NetworkInformation
Imports AxWMPLib

Public Class mainForm


    Private WithEvents timerSuccessLogIn As New Timer()
    Private WithEvents mouseCheckTimer As Timer

    Dim strangerThingsSelected As Boolean = False
    Dim emilySelected As Boolean = False
    Dim peakySelected As Boolean = False
    Dim behindSelected As Boolean = False
    Dim orangeSelected As Boolean = False
    Dim breakingSelected As Boolean = False


    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim labelCoordinates As Point = placeholder.Location
        'Dim message As String = "X: " & labelCoordinates.X & " Y: " & labelCoordinates.Y
        'MsgBox(message)

        videoPlayer.uiMode = "none"
        btnStopStranger.Visible = False

        mouseCheckTimer = New Timer()
        mouseCheckTimer.Interval = 100 ' Check every 100 milliseconds
        AddHandler mouseCheckTimer.Tick, AddressOf MouseCheckTimer_Tick
        mouseCheckTimer.Start()
    End Sub

    Private Sub MouseCheckTimer_Tick(sender As Object, e As EventArgs)
        Dim mousePos As Point = videoPlayer.PointToClient(Cursor.Position)

        If videoPlayer.ClientRectangle.Contains(mousePos) Then
            videoPlayer.uiMode = "full"
        Else
            videoPlayer.uiMode = "none"
        End If
    End Sub


    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click

        Dim logInForm As New logIn(Me)

        logInForm.ShowDialog()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim signUpForm As New signUp()

        signUpForm.ShowDialog()
    End Sub

    Private Sub btnEmily_Click(sender As Object, e As EventArgs) Handles btnEmily.Click
        emilySelected = True
        picEmilySelected.Visible = True
        btnPlayStranger.Visible = True

        btnPlayStranger.Location = New Point(690, 225)
        btnStopStranger.Location = New Point(840, 225)


        picEmilySelected.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
        btnPlayStranger.BringToFront()
        btnStopStranger.BringToFront()
    End Sub

    Private Sub btnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        orangeSelected = True
        picOrangeSelected.Visible = True
        btnPlayStranger.Visible = True

        btnPlayStranger.Location = New Point(756, 269)
        btnStopStranger.Location = New Point(906, 269)


        picOrangeSelected.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
        btnPlayStranger.BringToFront()
        btnStopStranger.BringToFront()
    End Sub

    Private Sub btnBehind_Click(sender As Object, e As EventArgs) Handles btnBehind.Click
        behindSelected = True
        picBehindSelected.Visible = True
        btnPlayStranger.Visible = True

        btnPlayStranger.Location = New Point(682, 200)
        btnStopStranger.Location = New Point(832, 199)


        picBehindSelected.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
        btnPlayStranger.BringToFront()
        btnStopStranger.BringToFront()
    End Sub

    Private Sub btnStrangerThings_Click(sender As Object, e As EventArgs) Handles btnStrangerThings.Click
        strangerThingsSelected = True
        picStrangerSelected.Visible = True
        btnPlayStranger.Visible = True

        btnPlayStranger.Location = New Point(682, 209)
        btnStopStranger.Location = New Point(836, 208)


        picStrangerSelected.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
        btnPlayStranger.BringToFront()
        btnStopStranger.BringToFront()
    End Sub

    Private Sub btnBreaking_Click(sender As Object, e As EventArgs) Handles btnBreaking.Click
        breakingSelected = True
        picBreakingSelected.Visible = True
        btnPlayStranger.Visible = True

        btnPlayStranger.Location = New Point(672, 271)
        btnStopStranger.Location = New Point(827, 271)


        picBreakingSelected.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
        btnPlayStranger.BringToFront()
        btnStopStranger.BringToFront()
    End Sub

    Private Sub btnPeaky_Click(sender As Object, e As EventArgs) Handles btnPeaky.Click
        peakySelected = True
        picPeakySelected.Visible = True
        btnPlayStranger.Visible = True

        btnPlayStranger.Location = New Point(672, 229)
        btnStopStranger.Location = New Point(823, 228)


        picPeakySelected.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
        btnPlayStranger.BringToFront()
        btnStopStranger.BringToFront()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        videoPlayer.Ctlcontrols.stop()
        strangerThingsSelected = False
        emilySelected = False
        peakySelected = False
        behindSelected = False
        orangeSelected = False
        breakingSelected = False



        btnEmily.Visible = True
        btnOrange.Visible = True
        btnBehind.Visible = True
        btnStrangerThings.Visible = True
        btnBreaking.Visible = True
        btnPeaky.Visible = True
        btnHome.Visible = True
        btnLogOut.Visible = True
        btnDropDown.Visible = True
        picHome.Visible = True

        picHome.BringToFront()
        btnEmily.BringToFront()
        btnOrange.BringToFront()
        btnBehind.BringToFront()
        btnStrangerThings.BringToFront()
        btnBreaking.BringToFront()
        btnPeaky.BringToFront()
        btnHome.BringToFront()
        btnLogOut.BringToFront()
        btnDropDown.BringToFront()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        picMain.BringToFront()
        btnGetStarted.BringToFront()
        btnSignUp.BringToFront()

        videoPlayer.Ctlcontrols.stop()

    End Sub

    Private Sub btnDropDown_Click(sender As Object, e As EventArgs) Handles btnDropDown.Click
        btnDropUp.Visible = True
        btnDropUp.BringToFront()
        lblUserName.BringToFront()

        lblUserName.Location = New Point(1009 - lblUserName.Width, 57)
        lblUserName.Visible = True
    End Sub

    Private Sub btnDropUp_Click(sender As Object, e As EventArgs) Handles btnDropUp.Click
        btnDropDown.BringToFront()

        lblUserName.Visible = False
    End Sub

    Private Sub btnStopStranger_Click(sender As Object, e As EventArgs) Handles btnStopStranger.Click
        videoPlayer.Ctlcontrols.stop()
        btnStopStranger.Visible = False
    End Sub

    Private Sub btnPlayStranger_Click(sender As Object, e As EventArgs) Handles btnPlayStranger.Click

        If strangerThingsSelected Then
            videoPlayer.URL = "resources/trailers/strangerThings.mp4"
        ElseIf emilySelected Then
            videoPlayer.URL = "resources/trailers/emilyInParis.mp4"
        ElseIf peakySelected Then
            videoPlayer.URL = "resources/trailers/peakyBlinders.mp4"
        ElseIf behindSelected Then
            videoPlayer.URL = "resources/trailers/behindHerEyes.mp4"
        ElseIf orangeSelected Then
            videoPlayer.URL = "resources/trailers/orangeIsTheNewBlack.mp4"
        ElseIf breakingSelected Then
            videoPlayer.URL = "resources/trailers/breakingBad.mp4"
        End If


        videoPlayer.settings.volume = 100

        videoPlayer.BringToFront()
        btnStopStranger.Visible = True
    End Sub

    Private Sub videoPlayer_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles videoPlayer.PlayStateChange
        ' Check if the playback state is stopped (video has ended)
        If e.newState = WMPLib.WMPPlayState.wmppsStopped Then
            ' Bring the Windows Media Player control to the back
            videoPlayer.SendToBack()
            btnStopStranger.Visible = False
        End If
    End Sub




    Private Sub picEmilySeleted_Click(sender As Object, e As EventArgs) Handles picEmilySelected.Click

    End Sub



End Class
