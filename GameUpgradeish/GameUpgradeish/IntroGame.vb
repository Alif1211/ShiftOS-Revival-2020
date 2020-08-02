Public Class IntroGame
    Dim HowMuchPause As Integer = 0
    Dim WhichText As Integer = 0
    Dim Timer As Integer = 0
    Dim ShouldIntroCodeStart As Boolean = True
    Dim ShouldInstallShiftOSStart As Boolean = True
    Dim ConversationLast As Boolean = False
    Dim InstallationLast As Boolean = False
    Dim StatTextBox1 As String

    Private Sub Startup(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Hide()
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Text = TextBox1.Text & "Connected to <null>"
        TextBox1.ForeColor = Color.LightGreen
        My.Computer.Audio.Play(My.Resources.snd, AudioPlayMode.WaitToComplete)
        TextBox1.ScrollToCaret()
        IntroCode.Start()
    End Sub

#Region "Intro of the Game"
    Private Sub IntroCode_Tick(sender As Object, e As EventArgs) Handles IntroCode.Tick
        If ShouldIntroCodeStart = True Then
            Select Case WhichText
                Case 0
                    HowMuchPause = 100
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 1
                    HowMuchPause = 50
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : Welcome to Gudish a.k.a ShiftOS Visual Basic Revival"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 2
                    HowMuchPause = 75
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : If you use ShiftOS for a long time, you may know exactly who i am"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 2
                    HowMuchPause = 110
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : And i say Congratulations! you have been selected for ShiftOS Experimental voulenteer"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 3
                    HowMuchPause = 130
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : In case you don't know what ShiftOS is. ShiftOS is an operating system that will make revolution to the world of computing"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 4
                    HowMuchPause = 85
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : Later, ShiftOS will can be run on various devices such as TV, fridge, phone, etc."
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 5
                    HowMuchPause = 130
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : For now, i need a computer and a person to try out ShiftOS from now till at one point in time that ShiftOS is really stable"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 6
                    HowMuchPause = 60
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : But, for many times, i have lack of time to develop this OS."
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 7
                    HowMuchPause = 40
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : And this OS became unstable."
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 8
                    HowMuchPause = 65
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : But now, for temporarily, i can manage to develop this OS again"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 9
                    HowMuchPause = 100
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> : OK, let's install ShiftOS to this computer. I will tell you more later while i work... on something else"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 10
                    HowMuchPause = 30
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "<null> Disconnected"
                    IntroText.Start()
                    ShouldIntroCodeStart = False
                Case 11
                    HowMuchPause = 100
                    TextBox1.Text = TextBox1.Text & Environment.NewLine & "Preparing Installation of ShiftOS..."
                    ConversationLast = True
                    IntroText.Start()
                    ShouldIntroCodeStart = False
            End Select
        Else
            IntroCode.Stop()
        End If
    End Sub
#End Region

#Region "Installation of ShiftOS"
    Private Sub InstallShiftOS_Tick(sender As Object, e As EventArgs) Handles InstallShiftOS.Tick
        If ShouldInstallShiftOSStart = True Then
            Select Case WhichText
                Case 0
                    HowMuchPause = 100
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 1
                    HowMuchPause = 50
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 0%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 2
                    HowMuchPause = 23
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 1%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 3
                    HowMuchPause = 26
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 5%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 4
                    HowMuchPause = 92
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 12%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 5
                    HowMuchPause = 21
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 14%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 6
                    HowMuchPause = 38
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 19%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 7
                    HowMuchPause = 102
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 55%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 8
                    HowMuchPause = 370
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 82%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 9
                    HowMuchPause = 5
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 89%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 10
                    HowMuchPause = 200
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... 100%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 11
                    HowMuchPause = 50
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 0%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 12
                    HowMuchPause = 70
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 5%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 13
                    HowMuchPause = 94
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 19%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 14
                    HowMuchPause = 294
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 27%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 15
                    HowMuchPause = 124
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 39%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 16
                    HowMuchPause = 289
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 49%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 17
                    HowMuchPause = 124
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 53%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 18
                    HowMuchPause = 249
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 67%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 19
                    HowMuchPause = 198
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 74%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 20
                    HowMuchPause = 117
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 92%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 21
                    HowMuchPause = 124
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... 100%"
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 22
                    HowMuchPause = 197
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 23
                    HowMuchPause = 120
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB"
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 24
                    HowMuchPause = 93
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..."
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 25
                    HowMuchPause = 133
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..." & Environment.NewLine & "(1/3) Completed"
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 26
                    HowMuchPause = 24
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..." & Environment.NewLine & "(1/3) Completed" & Environment.NewLine & "(2/3) Completed"
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 27
                    HowMuchPause = 177
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..." & Environment.NewLine & "(1/3) Completed" & Environment.NewLine & "(2/3) Completed" & Environment.NewLine & "(3/3) Completed"
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 28
                    HowMuchPause = 436
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..." & Environment.NewLine & "(1/3) Completed" & Environment.NewLine & "(2/3) Completed" & Environment.NewLine & "(3/3) Completed" & Environment.NewLine & "Fetching SRUB Boot Manager..."
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 29
                    HowMuchPause = 346
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..." & Environment.NewLine & "(1/3) Completed" & Environment.NewLine & "(2/3) Completed" & Environment.NewLine & "(3/3) Completed" & Environment.NewLine & "Fetching SRUB Boot Manager..." & Environment.NewLine & "Modifying Windows Registries for ShiftOS..."
                    StatTextBox1 = TextBox1.Text
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
                Case 30
                    HowMuchPause = 100
                    TextBox1.Text = "Downloading Package from sttps://shiftos.net/packages/beginning.spkg ... Completed" & Environment.NewLine & "Resolving Package ... Completed" & Environment.NewLine & Environment.NewLine & "Packages (3) : shiftos-temrinal, shiftos-shiftorium, shiftos-knowledge-input" & Environment.NewLine & Environment.NewLine & "Total Install Size : 10.0 MiB" & Environment.NewLine & "Total Download Size : 0.00 MiB" & Environment.NewLine & "Installing Packages..." & Environment.NewLine & "(1/3) Completed" & Environment.NewLine & "(2/3) Completed" & Environment.NewLine & "(3/3) Completed" & Environment.NewLine & "Fetching SRUB Boot Manager..." & Environment.NewLine & "Modifying Windows Registries for ShiftOS..." & Environment.NewLine & "Finishing..."
                    StatTextBox1 = TextBox1.Text
                    InstallationLast = True
                    TextInstall.Start()
                    ShouldIntroCodeStart = False
            End Select
        Else
            InstallShiftOS.Stop()
        End If
    End Sub
#End Region

    Private Sub IntroText_Tick(sender As Object, e As EventArgs) Handles IntroText.Tick
        If Timer = HowMuchPause Then
            If ConversationLast = True Then
                HowMuchPause = 0
                Timer = 0
                WhichText = 0
                TextBox1.Clear()
                TextBox1.Text = "Installing ShiftOS..."
                InstallShiftOS.Start()
                IntroText.Stop()
                TextBox1.Select(TextBox1.TextLength, 0)
                TextBox1.ScrollToCaret()
            Else
                WhichText = WhichText + 1
                ShouldIntroCodeStart = True
                HowMuchPause = 0
                Timer = 0
                My.Computer.Audio.Play(My.Resources.writesound, AudioPlayMode.Background)
                IntroCode.Start()
                IntroText.Stop()
                TextBox1.Select(TextBox1.TextLength, 0)
                TextBox1.ScrollToCaret()
            End If
        End If
        Timer = Timer + 1
    End Sub

    Private Sub TextInstall_Tick(sender As Object, e As EventArgs) Handles TextInstall.Tick
        If Timer = HowMuchPause Then
            If InstallationLast = True Then
                HowMuchPause = 0
                Timer = 0
                WhichText = 0
                TextBox1.Select(TextBox1.TextLength, 0)
                TextBox1.Clear()
                'TextBox1.Text = "Installing ShiftOS..."
                InstallShiftOS.Stop()
                IntroText.Stop()
                TextBox1.Select(TextBox1.TextLength, 0)
                TextBox1.ScrollToCaret()
                Terminal.Show()
                Me.Close()
            Else
                WhichText = WhichText + 1
                ShouldInstallShiftOSStart = True
                HowMuchPause = 0
                Timer = 0
                InstallShiftOS.Start()
                TextInstall.Stop()
                TextBox1.Select(TextBox1.TextLength, 0)
                TextBox1.ScrollToCaret()
            End If
        End If
        Timer = Timer + 1
    End Sub
End Class
