﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddSupplier
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddSupplier))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rank = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Synodos = New System.Windows.Forms.TextBox
        Me.mAttachment = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Subject = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CH1 = New System.Windows.Forms.Label
        Me.CH2 = New System.Windows.Forms.Label
        Me.HotelRoom = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.HotelName = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.cmdcancel = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.send = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtAirAnax = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.DtAirAfixi = New System.Windows.Forms.DateTimePicker
        Me.DTCheckout = New System.Windows.Forms.DateTimePicker
        Me.DTCheckin = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DIE = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.onoProsf = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ONO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.email = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label18 = New System.Windows.Forms.Label
        Me.PTHSHC5 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "+.ico")
        Me.ImageList1.Images.SetKeyName(1, "-.ico")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PTHSHC5)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.rank)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Synodos)
        Me.GroupBox1.Controls.Add(Me.mAttachment)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Subject)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.cmdcancel)
        Me.GroupBox1.Controls.Add(Me.cmdsave)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox2)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Controls.Add(Me.txtTo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtMessage)
        Me.GroupBox1.Controls.Add(Me.send)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtAirAnax)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DtAirAfixi)
        Me.GroupBox1.Controls.Add(Me.DTCheckout)
        Me.GroupBox1.Controls.Add(Me.DTCheckin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DIE)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.onoProsf)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ONO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1090, 590)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rank
        '
        Me.rank.Location = New System.Drawing.Point(368, 92)
        Me.rank.Name = "rank"
        Me.rank.Size = New System.Drawing.Size(44, 20)
        Me.rank.TabIndex = 135
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(311, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 134
        Me.Label16.Text = "Rank1-10"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 133
        Me.Label15.Text = "Συνοδός"
        '
        'Synodos
        '
        Me.Synodos.BackColor = System.Drawing.Color.PapayaWhip
        Me.Synodos.CausesValidation = False
        Me.Synodos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Synodos.Location = New System.Drawing.Point(87, 122)
        Me.Synodos.MaxLength = 50
        Me.Synodos.Name = "Synodos"
        Me.Synodos.Size = New System.Drawing.Size(325, 21)
        Me.Synodos.TabIndex = 132
        '
        'mAttachment
        '
        Me.mAttachment.AutoSize = True
        Me.mAttachment.Location = New System.Drawing.Point(168, 451)
        Me.mAttachment.Name = "mAttachment"
        Me.mAttachment.Size = New System.Drawing.Size(0, 13)
        Me.mAttachment.TabIndex = 131
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "Συνημμένο"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Θέμα"
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(86, 270)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(325, 20)
        Me.Subject.TabIndex = 128
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 476)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Στοιχεία Κράτησης"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CH1)
        Me.Panel1.Controls.Add(Me.CH2)
        Me.Panel1.Controls.Add(Me.HotelRoom)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.HotelName)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(8, 498)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 92)
        Me.Panel1.TabIndex = 126
        '
        'CH1
        '
        Me.CH1.AutoSize = True
        Me.CH1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CH1.Location = New System.Drawing.Point(93, 62)
        Me.CH1.Name = "CH1"
        Me.CH1.Size = New System.Drawing.Size(10, 13)
        Me.CH1.TabIndex = 5
        Me.CH1.Text = " "
        '
        'CH2
        '
        Me.CH2.AutoSize = True
        Me.CH2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CH2.Location = New System.Drawing.Point(93, 19)
        Me.CH2.Name = "CH2"
        Me.CH2.Size = New System.Drawing.Size(10, 13)
        Me.CH2.TabIndex = 4
        Me.CH2.Text = " "
        '
        'HotelRoom
        '
        Me.HotelRoom.AutoSize = True
        Me.HotelRoom.Location = New System.Drawing.Point(97, 62)
        Me.HotelRoom.Name = "HotelRoom"
        Me.HotelRoom.Size = New System.Drawing.Size(0, 13)
        Me.HotelRoom.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(11, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Δωμάτιο :"
        '
        'HotelName
        '
        Me.HotelName.AutoSize = True
        Me.HotelName.Location = New System.Drawing.Point(93, 19)
        Me.HotelName.Name = "HotelName"
        Me.HotelName.Size = New System.Drawing.Size(0, 13)
        Me.HotelName.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ξενοδοχείο:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Θεσσαλονίκης", "Καβάλας", "Αλεξανδρούπολης", "Αμυγδαλεώνα"})
        Me.ComboBox1.Location = New System.Drawing.Point(290, 244)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 125
        '
        'cmdcancel
        '
        Me.cmdcancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.Location = New System.Drawing.Point(944, 441)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(103, 26)
        Me.cmdcancel.TabIndex = 9
        Me.cmdcancel.Text = "Ακυρο"
        Me.cmdcancel.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(835, 441)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(100, 26)
        Me.cmdsave.TabIndex = 8
        Me.cmdsave.Text = "Αποθήκευση"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Χορηγός", "Συνεργάτης", "Προσωπικό", "Σωματείο/Οργανισμός", "Masterclass/Panel", "Δημοσιογράφος", "VIP", "Pitching Lab", "Industry"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(634, 253)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(413, 169)
        Me.CheckedListBox2.TabIndex = 124
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Εθνικό", "Διεθνές", "Εθνικό Σπουδαστικό", "Διεθνές Σπουδαστικό", "Short & Green", "KIDDO", "Animation"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(634, 22)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(413, 169)
        Me.CheckedListBox1.TabIndex = 123
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(689, 564)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(128, 20)
        Me.txtTo.TabIndex = 121
        Me.txtTo.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Κείμενο (email)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(609, 564)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Πρός(email)"
        Me.Label11.Visible = False
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(86, 296)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(325, 143)
        Me.txtMessage.TabIndex = 118
        '
        'send
        '
        Me.send.Location = New System.Drawing.Point(343, 441)
        Me.send.Name = "send"
        Me.send.Size = New System.Drawing.Size(68, 26)
        Me.send.TabIndex = 117
        Me.send.Text = "Αποστολή"
        Me.send.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(257, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Αναχώρηση από Αεροδρόμιο"
        '
        'dtAirAnax
        '
        Me.dtAirAnax.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAirAnax.Location = New System.Drawing.Point(260, 214)
        Me.dtAirAnax.Name = "dtAirAnax"
        Me.dtAirAnax.Size = New System.Drawing.Size(151, 20)
        Me.dtAirAnax.TabIndex = 115
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(260, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 13)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Αφιξη σε Αεροδρόμιο"
        '
        'DtAirAfixi
        '
        Me.DtAirAfixi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtAirAfixi.Location = New System.Drawing.Point(260, 170)
        Me.DtAirAfixi.Name = "DtAirAfixi"
        Me.DtAirAfixi.Size = New System.Drawing.Size(151, 20)
        Me.DtAirAfixi.TabIndex = 113
        '
        'DTCheckout
        '
        Me.DTCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTCheckout.Location = New System.Drawing.Point(87, 214)
        Me.DTCheckout.Name = "DTCheckout"
        Me.DTCheckout.Size = New System.Drawing.Size(160, 20)
        Me.DTCheckout.TabIndex = 112
        '
        'DTCheckin
        '
        Me.DTCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTCheckin.Location = New System.Drawing.Point(86, 170)
        Me.DTCheckin.Name = "DTCheckin"
        Me.DTCheckin.Size = New System.Drawing.Size(160, 20)
        Me.DTCheckin.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Αναχώρηση :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Αφιξη :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Αεροδρόμιο :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Email"
        '
        'DIE
        '
        Me.DIE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIE.Location = New System.Drawing.Point(86, 66)
        Me.DIE.MaxLength = 40
        Me.DIE.Name = "DIE"
        Me.DIE.Size = New System.Drawing.Size(325, 21)
        Me.DIE.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Διεύθυνση :"
        '
        'onoProsf
        '
        Me.onoProsf.BackColor = System.Drawing.Color.PapayaWhip
        Me.onoProsf.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onoProsf.Location = New System.Drawing.Point(86, 39)
        Me.onoProsf.MaxLength = 50
        Me.onoProsf.Name = "onoProsf"
        Me.onoProsf.Size = New System.Drawing.Size(325, 21)
        Me.onoProsf.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Προσφώνηση :"
        '
        'ONO
        '
        Me.ONO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ONO.Location = New System.Drawing.Point(87, 12)
        Me.ONO.MaxLength = 100
        Me.ONO.Name = "ONO"
        Me.ONO.Size = New System.Drawing.Size(324, 21)
        Me.ONO.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Επωνυμία :"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.PapayaWhip
        Me.email.CausesValidation = False
        Me.email.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(87, 95)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(209, 21)
        Me.email.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 244)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 13)
        Me.Label18.TabIndex = 136
        Me.Label18.Text = "Αριθ. Πτήσης"
        '
        'PTHSHC5
        '
        Me.PTHSHC5.Location = New System.Drawing.Point(88, 244)
        Me.PTHSHC5.Name = "PTHSHC5"
        Me.PTHSHC5.Size = New System.Drawing.Size(100, 20)
        Me.PTHSHC5.TabIndex = 137
        '
        'FrmAddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1161, 602)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Προσκεκλημένος"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ONO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdcancel As System.Windows.Forms.Button
    Friend WithEvents onoProsf As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DIE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DTCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtAirAfixi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtAirAnax As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents send As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HotelRoom As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents HotelName As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Subject As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mAttachment As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Synodos As System.Windows.Forms.TextBox
    Friend WithEvents CH1 As System.Windows.Forms.Label
    Friend WithEvents CH2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rank As System.Windows.Forms.TextBox
    Friend WithEvents PTHSHC5 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
