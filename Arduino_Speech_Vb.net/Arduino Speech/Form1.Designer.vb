<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OriginTheme1 = New Arduino_Speech.OriginTheme()
        Me.OriginButton1 = New Arduino_Speech.OriginButton()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OriginTheme1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OriginTheme1
        '
        Me.OriginTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.OriginTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.OriginTheme1.Controls.Add(Me.OriginButton1)
        Me.OriginTheme1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.OriginTheme1.Customization = "JiYn//////8="
        Me.OriginTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OriginTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.OriginTheme1.Image = Nothing
        Me.OriginTheme1.Location = New System.Drawing.Point(0, 0)
        Me.OriginTheme1.Movable = True
        Me.OriginTheme1.Name = "OriginTheme1"
        Me.OriginTheme1.NoRounding = False
        Me.OriginTheme1.Sizable = True
        Me.OriginTheme1.Size = New System.Drawing.Size(201, 364)
        Me.OriginTheme1.SmartBounds = True
        Me.OriginTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.OriginTheme1.TabIndex = 3
        Me.OriginTheme1.Text = "OriginTheme1"
        Me.OriginTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme1.Transparent = False
        '
        'OriginButton1
        '
        Me.OriginButton1.Customization = "AKX/////////////"
        Me.OriginButton1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OriginButton1.Image = Nothing
        Me.OriginButton1.Location = New System.Drawing.Point(84, 317)
        Me.OriginButton1.Name = "OriginButton1"
        Me.OriginButton1.NoRounding = False
        Me.OriginButton1.Size = New System.Drawing.Size(34, 34)
        Me.OriginButton1.TabIndex = 4
        Me.OriginButton1.Text = "X"
        Me.OriginButton1.Transparent = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(-14, 26)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(231, 431)
        Me.AxWindowsMediaPlayer1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 364)
        Me.Controls.Add(Me.OriginTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arduino Speech"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OriginTheme1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents OriginButton1 As Arduino_Speech.OriginButton
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OriginTheme1 As Arduino_Speech.OriginTheme

End Class
