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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlashButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BinaryLabel = New System.Windows.Forms.Label()
        Me.FlashtoolLabel = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.ComDevLabel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FlasherWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.FlashWarningTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Download ESPTool"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(588, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 425)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Help Panel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Documentation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FlashButton
        '
        Me.FlashButton.Enabled = False
        Me.FlashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlashButton.Location = New System.Drawing.Point(13, 415)
        Me.FlashButton.Name = "FlashButton"
        Me.FlashButton.Size = New System.Drawing.Size(257, 23)
        Me.FlashButton.TabIndex = 2
        Me.FlashButton.Text = "Flash bin"
        Me.FlashButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(13, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Binary"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'BinaryLabel
        '
        Me.BinaryLabel.Location = New System.Drawing.Point(94, 13)
        Me.BinaryLabel.Name = "BinaryLabel"
        Me.BinaryLabel.Size = New System.Drawing.Size(488, 23)
        Me.BinaryLabel.TabIndex = 4
        Me.BinaryLabel.Text = "No directory set"
        Me.BinaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlashtoolLabel
        '
        Me.FlashtoolLabel.Location = New System.Drawing.Point(94, 46)
        Me.FlashtoolLabel.Name = "FlashtoolLabel"
        Me.FlashtoolLabel.Size = New System.Drawing.Size(488, 23)
        Me.FlashtoolLabel.TabIndex = 6
        Me.FlashtoolLabel.Text = "No directory set"
        Me.FlashtoolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(13, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Flashtool"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'ComDevLabel
        '
        Me.ComDevLabel.Location = New System.Drawing.Point(93, 75)
        Me.ComDevLabel.Name = "ComDevLabel"
        Me.ComDevLabel.Size = New System.Drawing.Size(488, 23)
        Me.ComDevLabel.TabIndex = 8
        Me.ComDevLabel.Text = "No directory set"
        Me.ComDevLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(12, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Get COM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FlasherWorker
        '
        Me.FlasherWorker.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(277, 415)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(304, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 9
        '
        'WarningLabel
        '
        Me.WarningLabel.Enabled = False
        Me.WarningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLabel.Location = New System.Drawing.Point(9, 146)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(573, 266)
        Me.WarningLabel.TabIndex = 10
        Me.WarningLabel.Text = "FLASHING DO NOT EXIT APPLICATION"
        Me.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlashWarningTimer
        '
        Me.FlashWarningTimer.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ComDevLabel)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.FlashtoolLabel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BinaryLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.FlashButton)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Sapphire's ESP Flasher V0.1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents FlashButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BinaryLabel As Label
    Friend WithEvents FlashtoolLabel As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ComDevLabel As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents FlasherWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents WarningLabel As Label
    Friend WithEvents FlashWarningTimer As Timer
End Class
