Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmstatAddSupplier
    Dim stockID As Integer
    Dim hOldID As Integer
    Dim M_ID As Long = 0
    Dim mIsNew As Boolean = False


    '  Dim GDB As New ADODB.Connection


    'Create connection
    Dim conn As OleDbConnection

    'create data adapter
    Dim da As OleDbDataAdapter

    'create dataset
    Dim ds As DataSet = New DataSet

    Dim dt As New DataTable






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
        Dim conn As New OleDbConnection
        conn.ConnectionString = gConnect
        conn.Open()



        Try

            da = New OleDbDataAdapter(sql.Text, conn)

            'create command builder
            ' Dim cb As OleDbCommandBuilder = New OleDbCommandBuilder(da)
            ds.Clear()
            'fill dataset
            'Exit Sub
            Try
                da.Fill(ds, "PEL")
                DataGridView1.ClearSelection()
                DataGridView1.DataSource = ds
                DataGridView1.DataMember = "PEL"



            Catch ex As Exception
                MsgBox(Err.Description + Chr(13) + sql.Text)

            End Try

            ' Exit Sub

            'GridView1.Columns(STHLHTOY_ID).Width = 0
            ' DataGridView1.Columns(STHLHTOY_ID).Visible = False

        Catch ex As SqlException
            MsgBox(ex.ToString)
        Finally
            ' Close connection
            conn.Close()
        End Try

    End Sub


    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        ''This code draws a checkbox using the DrawCheckBox method of the ControlPaint class and uses the DrawString method of the Graphics object to draw the text of the item. The if statement inside the DrawCheckBox method sets the state of the checkbox to either ButtonState.Checked or ButtonState.Normal, depending on whether the item is selected.

        '' Draw the background of the ListBox control for each item.
        'e.DrawBackground()

        '' Determine the color of the checkbox based on whether the item is selected.
        'Dim checkboxColor As Color
        'If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
        '    checkboxColor = SystemColors.HighlightText
        'Else
        '    checkboxColor = SystemColors.ControlText
        'End If

        '' Draw the checkbox next to the item text.
        'Dim checkboxRect As New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Height, e.Bounds.Height)
        'Dim n As Integer
        'If e.Index = 1 Then n = ButtonState.Checked Else n = ButtonState.Normal
        'ControlPaint.DrawCheckBox(e.Graphics, checkboxRect, n) 'If(e.Index Mod 2 = 0, n, ButtonState.Normal)
        'e.Graphics.DrawString(ListBox1.Items(e.Index), Me.Font, New SolidBrush(checkboxColor), e.Bounds.X + checkboxRect.Width, e.Bounds.Y)
    End Sub


    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
    'This code uses the IndexFromPoint method of the ListBox to get the index of the clicked item, and the GetItemRectangle method to get the bounds of the item. It then creates a Rectangle object for the checkbox based on the item bounds, and checks whether the click occurred within this rectangle using the Contains method.

    'If the click occurred within the checkbox, the code sets the selected state of the item to True using the SetSelected method, and toggles the checked state of the checkbox using the SetItemChecked method. Note that you need to set the selected state to True in order for the checked state to be updated correctly.












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

    
    Private Sub sendEmail(ByVal ToEmail As String, ByVal PROSF As String)


        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("lagakis@otenet.gr", "a8417!")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "mailgate.otenet.gr"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(Trim(ToEmail))

            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment("c:\mercvb\reports\timol1.csv")
            e_mail.Attachments.Add(attachment)


            e_mail.To.Add(ToEmail) ' txtTo.Text)
            'Dim item As System.Net.Mail.Attachment
            'e_mail.Attachments.Add(item)

            e_mail.Subject = Subject.Text + " " + ToEmail
            e_mail.IsBodyHtml = False
            e_mail.Body = PROSF + Chr(13) + txtMessage.Text
            Smtp_Server.Send(e_mail)
            'MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try







        'Try
        '    Dim Smtp_Server As New SmtpClient
        '    Dim e_mail As New MailMessage()
        '    Smtp_Server.UseDefaultCredentials = False
        '    Smtp_Server.Credentials = New Net.NetworkCredential("lagakis@otenet.gr", "a8417!")
        '    Smtp_Server.Port = 587
        '    Smtp_Server.EnableSsl = True
        '    Smtp_Server.Host = "mailgate.otenet.gr"



        '    Dim attachment As System.Net.Mail.Attachment
        '    attachment = New System.Net.Mail.Attachment("c:\mercvb\reports\timol1.csv")
        '    e_mail.Attachments.Add(attachment)

        '    txtTo.Text = ToEmail
        '    e_mail.To.Add(txtTo.Text)
        '    'Dim item As System.Net.Mail.Attachment
        '    'e_mail.Attachments.Add(item)

        '    e_mail.Subject = Subject.Text '"Email Sending"
        '    e_mail.IsBodyHtml = False
        '    e_mail.Body = txtMessage.Text  'PROSF + Chr(13) +
        '    Smtp_Server.Send(e_mail)
        '    MsgBox("Mail Sent")

        'Catch error_t As Exception
        '    MsgBox(error_t.ToString)
        'End Try


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



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SQLBuild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQLBuild.Click
        Dim CH3 As String = ""
        For l As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(l) = True Then
                CH3 = IIf(Len(CH3) > 0, CH3 + " or ", "") + " SUBSTRING(CH3," + Format(l + 1, "0") + ",1)='1' "
            Else
                '
            End If
        Next


        Dim CH4 As String = IIf(Len(CH3) > 0, CH3, "")
        For l = 0 To CheckedListBox2.Items.Count - 1
            If CheckedListBox2.GetItemChecked(l) = True Then
                CH4 = IIf(Len(CH4) > 0, CH4 + " or ", "") + " SUBSTRING(CH4," + Format(l + 1, "0") + ",1)='1' "
            Else
                'cc4 = cc4 + "0"
            End If
        Next
        CH4 = IIf(Len(CH4) > 0, " WHERE " + CH4, "")
        sql.Text = "select EPO,CH3,CH4,isnull(EMAIL,'') as EMAIL,ISNULL(ONO,'') AS ONO FROM PEL  " + CH4




    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        attachment.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles send.Click

        Dim SQLDT4 As New DataTable
        SQLDT4 = ExecuteSQLQuery(sql.Text)



        For k As Integer = 0 To SQLDT4.Rows.Count - 1 'DataGridView1.Rows.Count - 1
            Dim mEmail As String = SQLDT4.Rows(k)("email").ToString()
            Dim PROSF As String = SQLDT4.Rows(k)("ONO").ToString()
            If Len(mEmail) > 0 Then
                Application.DoEvents()
                Me.Text = mEmail
                sendEmail(mEmail, PROSF)
                txtTo.Text = mEmail
            End If
        Next
    End Sub

   
   
    Private Sub toexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toexcel.Click
        Dim filename As String = "c:\mercvb\ektyp.xlsx"
        Dim sheetname As String = "Φύλλο1"
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xl As Excel.Worksheet
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add 'αν ηθελα να το ανοιξω αντι για add -> Open(filename)
        xlWorkBook.Worksheets.Add()  '(1)
        xl = xlWorkBook.Worksheets(1) ' .Add
        xlApp.Visible = True  'ΜΠΟΡΩ ΝΑ ΤΟ ΒΛΕΠΩ
        xl.Name = "fest"
        Dim WS(30) As Microsoft.Office.Interop.Excel.Worksheet

        Dim dt As New DataTable
        Dim k As Integer
        Dim mn1 As String = "1"
        Dim sql2 As String '= "SELECT ONO AS [Ονομα ],KOD AS [ΚΩΔ],N1 AS [ΚΑΤΗΓ],BAROS AS [ΒΑΡΟΣ],C1,C2,ID  FROM YLIKA WHERE N1=" + mn1 + " ORDER BY KOD "



        sql2 = sql.Text


        ExecuteSQLQuery(sql2, dt) 'D.PATIENTID,CHMEEIS desc

        xl.Cells(1, 2).value = "Προσκεκλημένοι"  '"ΕΠΙΚΕΦΑΛΙΔΑ" + "EIS"

        Dim sken As Single = 0
        Dim seopy As Single = 0

        Dim mSeir As Integer = 2

        Dim L As Integer

        For L = 0 To dt.Columns.Count - 1
            xl.Cells(mSeir, L + 1).value = dt.Columns(L).Caption 'a
        Next



0:
        mSeir = 2
        For k = 0 To dt.Rows.Count - 1
            mSeir = mSeir + 1
            For L = 0 To dt.Columns.Count - 1
                xl.Cells(mSeir, L + 1).value = dt.Rows(k)(L)  'aa
            Next
        Next

        xl.Columns.AutoFit()
        xlApp.Visible = True
        mreleaseObject(xlApp)
        mreleaseObject(xlWorkBook)
        mreleaseObject(xl)

    End Sub
End Class