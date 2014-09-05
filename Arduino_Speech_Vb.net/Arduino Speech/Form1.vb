Imports System
Imports System.Speech
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel


Public Class Form1
    '      ///////////////////////////////////
    '     //       Bessem Bousselmi        //
    '    //     bassouma2100@gmail.com    //
    '   //        www.bassouma.eu        //
    '  //   Creative Commons CC-BY-NC   //
    ' ///////////////////////////////////                             

    Dim synth As New Synthesis.SpeechSynthesizer
    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim z As Integer = 0
    Dim t As Integer = 0
  

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        synth.SpeakAsync("Hi , I'am Arduino")
        AxWindowsMediaPlayer1.URL = "...\Arduino Speech\Arduino Speech\Rer\ardunio.mp4" 'Edit URL Video !  
        reco.SetInputToDefaultAudioDevice()
        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim ardRule As New Recognition.SrgsGrammar.SrgsRule("Arduino")

        Dim SpeechList As New Recognition.SrgsGrammar.SrgsOneOf("arduino configuration", "hi how are you arduino", "thanks arduino", "identify yourself", "good-bye", "open led yellow", "open led green", "open led blue", "open led red", "close led yellow", "close led green", "close led blue", "close led red")

        ardRule.Add(SpeechList)

        gram.Rules.Add(ardRule)

        gram.Root = ardRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Select Case e.Result.Text
            'Presentation
            Case "hi how are you arduino"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                synth.SpeakAsync("I'am fine my sir , " + Form2.TextBox1.Text)
                'Configuration
            Case "arduino configuration"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                synth.SpeakAsync("Arduino System Configuration, Open")
                Form2.ShowDialog()
                'Exit
            Case "good-bye"
                SerialPort1.Close()
                Me.Close()

            Case "thanks arduino"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                synth.SpeakAsync("You are welcome !")
                '///////////////////////////////////////////
                'Open 
                '//////////////////////////////////////////

            Case "open led yellow"
                If y = 0 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED yellow Open successfully")
                    y = 1
                    'serial Port Open LED Yellow
                    SerialPort1.Write(1)
                ElseIf y <> 0 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED yellow is in the case of Open")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If

            Case "open led green"
                If x = 0 And SerialPort1.IsOpen = True Then
                    synth.SpeakAsync("Arduino System control, LED green Open successfully")
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    x = 1
                    SerialPort1.Write(3)
                    'serial Port Open LED Green
                ElseIf x <> 0 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED green is in the case of Open")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If

            Case "open led blue"
                If z = 0 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED blue Open successfully")
                    z = 1
                    'serial Port Open LED Blue
                    SerialPort1.Write(5)
                ElseIf z <> 0 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED Blue is in the case of Open")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If
            Case "open led red"
                If t = 0 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED red Open successfully")
                    t = 1
                    'serial Port Open LED Red
                    SerialPort1.Write(7)
                ElseIf t <> 0 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED red is in the case of Open")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If
                '//////////////////////////////////////////
                'Close 
                '/////////////////////////////////////////
            Case "close led yellow"
                If y = 1 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED yellow Close successfully")
                    y = 0
                    'serial Port Close LED Yellow
                    SerialPort1.Write(2)
                ElseIf y <> 1 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED Yellow is in the case of Close")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If

            Case "close led green"
                If x = 1 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED green Close successfully")
                    x = 0
                    'serial Port Close LED Green
                    SerialPort1.Write(4)
                ElseIf x <> 1 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED Green is in the case of Close")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If

            Case "close led blue"
                If z = 1 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED blue Close successfully")
                    z = 0
                    'serial Port Close LED Blue
                    SerialPort1.Write(6)
                ElseIf z <> 1 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED blue is in the case of Close")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If

            Case "close led red"
                If t = 1 And SerialPort1.IsOpen = True Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED red Close successfully")
                    t = 0
                    'serial Port Close LED Red
                    SerialPort1.Write(8)
                ElseIf t <> 1 Then
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, LED red is in the case of Close")
                Else
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                    synth.SpeakAsync("Arduino System control, Arduino Board is not Connected")
                End If
                '
            Case "identify yourself"
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                synth.SpeakAsync(" I'am a Control system specialist in Arduino, through speech with computer Programming by Mister Bessem Bousselmi . For more information you can visit bassouma.eu  ")

        End Select


    End Sub
    Private Sub SecondOriginButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub SecondOriginButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub OriginButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub OriginButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginButton1.Click
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
            End
        Else
            End
        End If


    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class