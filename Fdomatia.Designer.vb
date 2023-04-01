<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fdomatia
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.D1 = New System.Windows.Forms.DateTimePicker
        Me.D2 = New System.Windows.Forms.DateTimePicker
        Me.domatio = New System.Windows.Forms.TextBox
        Me.kreb = New System.Windows.Forms.ComboBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.cat = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DIAGRAFI = New System.Windows.Forms.Button
        Me.DIORTOSI = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Νέο Δωμάτιο"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'D1
        '
        Me.D1.Location = New System.Drawing.Point(219, 39)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(108, 20)
        Me.D1.TabIndex = 1
        '
        'D2
        '
        Me.D2.Location = New System.Drawing.Point(333, 39)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(129, 20)
        Me.D2.TabIndex = 2
        '
        'domatio
        '
        Me.domatio.Location = New System.Drawing.Point(132, 38)
        Me.domatio.Name = "domatio"
        Me.domatio.Size = New System.Drawing.Size(81, 20)
        Me.domatio.TabIndex = 3
        '
        'kreb
        '
        Me.kreb.FormattingEnabled = True
        Me.kreb.Location = New System.Drawing.Point(478, 38)
        Me.kreb.Name = "kreb"
        Me.kreb.Size = New System.Drawing.Size(98, 21)
        Me.kreb.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(132, 107)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(443, 343)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'cat
        '
        Me.cat.FormattingEnabled = True
        Me.cat.Location = New System.Drawing.Point(596, 38)
        Me.cat.Name = "cat"
        Me.cat.Size = New System.Drawing.Size(98, 21)
        Me.cat.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(483, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Αρ.Κρεβ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(593, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Κατηγορία"
        '
        'DIAGRAFI
        '
        Me.DIAGRAFI.Location = New System.Drawing.Point(596, 107)
        Me.DIAGRAFI.Name = "DIAGRAFI"
        Me.DIAGRAFI.Size = New System.Drawing.Size(132, 22)
        Me.DIAGRAFI.TabIndex = 9
        Me.DIAGRAFI.Text = "Διαγραφή Δωματίου"
        Me.DIAGRAFI.UseVisualStyleBackColor = True
        '
        'DIORTOSI
        '
        Me.DIORTOSI.Location = New System.Drawing.Point(596, 163)
        Me.DIORTOSI.Name = "DIORTOSI"
        Me.DIORTOSI.Size = New System.Drawing.Size(132, 22)
        Me.DIORTOSI.TabIndex = 10
        Me.DIORTOSI.Text = "Διόρθωση Δωματίου"
        Me.DIORTOSI.UseVisualStyleBackColor = True
        '
        'Fdomatia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 480)
        Me.Controls.Add(Me.DIORTOSI)
        Me.Controls.Add(Me.DIAGRAFI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cat)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.kreb)
        Me.Controls.Add(Me.domatio)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.D1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Fdomatia"
        Me.Text = "Δωμάτια"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents D1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents D2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents domatio As System.Windows.Forms.TextBox
    Friend WithEvents kreb As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents cat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DIAGRAFI As System.Windows.Forms.Button
    Friend WithEvents DIORTOSI As System.Windows.Forms.Button
End Class
