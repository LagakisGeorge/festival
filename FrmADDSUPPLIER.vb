Imports System.Net.Mail
Public Class FrmAddSupplier
    Dim stockID As Integer
    Dim hOldID As Integer
    Dim M_ID As Long = 0
    Dim mIsNew As Boolean = False

    Public Property IsNew() As Integer
        Get
            Return mIsNew
        End Get
        Set(ByVal Value As Integer)
            ' If Value < 1 Or Value > 12 Then
            ' Error processing for invalid value. 
            'Else
            mIsNew = Value
            'End If
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return M_ID
        End Get
        Set(ByVal Value As Integer)
            ' If Value < 1 Or Value > 12 Then
            ' Error processing for invalid value. 
            'Else
            M_ID = Value
            'End If
        End Set
    End Property




    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Dim SQL As String
        Dim mMON As String = Str(Val(AFM.Text))

        Dim mb As String = DIE.Text
        mb = Str(Val(mb))
        If Len(KOD.Text) = 0 Then
            'MsgBox("ΔΕΝ ΒΑΛΑΤΕ email")
            'Exit Sub
        End If
        If Len(ONO.Text) = 0 Then
            MsgBox("ΔΕΝ ΒΑΛΑΤΕ ΕΠΩΝΥΜΙΑ")
            Exit Sub
        End If
        If Len(AFM.Text) = 0 Then
            MsgBox("ΔΕΝ ΒΑΛΑΤΕ ΔΙΕΥΘΥΝΣΗ")
            Exit Sub
        End If



        Dim mkod As String = KOD.Text
        Dim mono As String = ONO.Text
        Dim m_mon As String = AFM.Text

        Dim mBaros As String = DIE.Text
        Dim ff As String = "MM/dd/yyyy HH:mm"
        Dim ci As String = Format(DTCheckin.Value, ff)
        Dim co As String = Format(DTCheckout.Value, ff)
        Dim aaf As String = Format(DtAirAfixi.Value, ff)
        Dim aan As String = Format(dtAirAnax.Value, ff)

        If IsNew Then

            SQL = "insert into PEL (CHECKIN,CHECKOUT,AIRAFIXI,AIRANAX,EMAIL,EPO,AFM,DIE) VALUES ('" + ci + "','" + co + "','" + aaf + "','" + aan + "','" + KOD.Text + "','" + Replace(ONO.Text, "'", "`") + "','" + AFM.Text + "','" + mBaros + "')"

        Else
            SQL = "UPDATE PEL SET CHECKOUT='" + co + "',CHECKIN='" + ci + "',EMAIL='" + mkod + "',EPO='" + mono + "',AFM='" + m_mon + "',DIE='" + mBaros + "'  WHERE ID=" + Str(ID)


        End If



        Try
            ExecuteSQLQuery(SQL)
        Catch ex As Exception
            MsgBox("ΔΕΝ ΚΑΤΕΧΩΡΗΘΗ " + Err.Description)
        End Try

        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmAddSupplier_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DTCheckin.CustomFormat = "dd/MM/yyyy HH:mm"
        DTCheckout.CustomFormat = "dd/MM/yyyy HH:mm"
        'Dim SQL As String
        'Dim mMON As String = Str(Val(AFM.Text))

        'Dim mb As String = DIE.Text
        'mb = Str(Val(mb))
        'If Len(KOD.Text) = 0 Then
        '    MsgBox("ΔΕΝ ΒΑΛΑΤΕ ΚΩΔΙΚΟ")
        '    Exit Sub
        'End If
        'If Len(ONO.Text) = 0 Then
        '    MsgBox("ΔΕΝ ΒΑΛΑΤΕ ΠΕΡΙΓΡΑΦΗ")
        '    Exit Sub
        'End If
        'If Len(AFM.Text) = 0 Then
        '    MsgBox("ΔΕΝ ΒΑΛΑΤΕ ΜΟΝΑΔΑ ΜΕΤΡΗΣΗΣ")
        '    Exit Sub
        'End If

    End Sub

    Private Sub DTCheckin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTCheckin.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles send.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("lagakis@otenet.gr", "a8417!")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "mailgate.otenet.gr"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(Trim(KOD.Text))

            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment("c:\mercvb\reports\reports.mdb")
            e_mail.Attachments.Add(attachment)


            e_mail.To.Add(txtTo.Text)
            'Dim item As System.Net.Mail.Attachment
            'e_mail.Attachments.Add(item)

            e_mail.Subject = "Email Sending"
            e_mail.IsBodyHtml = False
            e_mail.Body = txtMessage.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try


        'Try
        '    Dim oMail As New SmtpMail("TryIt")
        '    ' Set sender email address, please change it to yours
        '    oMail.From = "test@emailarchitect.net"
        '    ' Set recipient email address, please change it to yours
        '    oMail.To = "support@emailarchitect.net"

        '    ' Set email subject
        '    oMail.Subject = "test HTML email with attachment"
        '    ' Set HTML body
        '    oMail.HtmlBody = "<font size=5>This is</font> <font color=red><b>a test</b></font>"

        '    ' Add attachment from local disk
        '    oMail.AddAttachment("d:\test.pdf")

        '    ' Add attachment from remote website
        '    oMail.AddAttachment("http://www.emailarchitect.net/webapp/img/logo.jpg")

        '    ' Your SMTP server address
        '    Dim oServer As New SmtpServer("smtp.emailarchitect.net")

        '    ' User and password for ESMTP authentication
        '    oServer.User = "test@emailarchitect.net"
        '    oServer.Password = "testpassword"

        '    ' Most mordern SMTP servers require SSL/TLS connection now.
        '    ' ConnectTryTLS means if server supports SSL/TLS, SSL/TLS will be used automatically.
        '    oServer.ConnectType = SmtpConnectType.ConnectTryTLS

        '    ' If your SMTP server uses 587 port
        '    ' oServer.Port = 587

        '    ' If your SMTP server requires SSL/TLS connection on 25/587/465 port
        '    ' oServer.Port = 25 ' 25 or 587 or 465
        '    ' oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

        '    Console.WriteLine("start to send email with attachment ...")

        '    Dim oSmtp As New SmtpClient()
        '    oSmtp.SendMail(oServer, oMail)

        '    Console.WriteLine("email was sent successfully!")
        'Catch ep As Exception
        '    Console.WriteLine("failed to send email with the following error:")
        '    Console.WriteLine(ep.Message)
        'End Try



    End Sub


End Class