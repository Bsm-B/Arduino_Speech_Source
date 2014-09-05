Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Speech
Public Class Form2
    Dim myPort As Array
    Dim synth As New Synthesis.SpeechSynthesizer
    Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox2.Items.AddRange(myPort)


    End Sub

    Private Sub OriginTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginTheme1.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged
        OriginButton1.Enabled = True
    End Sub

    Private Sub OriginButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OriginButton1.Click
        Form1.SerialPort1.PortName = ComboBox2.Text
        Form1.SerialPort1.BaudRate = ComboBox1.Text
        Form1.SerialPort1.Open()
        SecondOriginButton1.Enabled = True
        OriginButton1.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub SecondOriginButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondOriginButton1.Click

        Form1.SerialPort1.Close()
        SecondOriginButton1.Enabled = False
        OriginButton1.Enabled = True
    End Sub

    Private Sub SecondOriginButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondOriginButton2.Click
        Form1.AxWindowsMediaPlayer1.Ctlcontrols.play()
        synth.SpeakAsync("Arduino System Configuration, Close")
        Me.Close()
    End Sub
End Class