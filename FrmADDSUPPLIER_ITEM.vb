Public Class FrmADDSUPPLIER_ITEM


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
            Return m_ID
        End Get
        Set(ByVal Value As Integer)
            ' If Value < 1 Or Value > 12 Then
            ' Error processing for invalid value. 
            'Else
            m_ID = Value
            'End If
        End Set
    End Property






    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        '       CREATE TABLE [dbo].[HOTELS](
        '[ID] [int] NOT NULL,
        '[CATEGORY] int NULL,
        '[RANK] int NULL,
        '[EMAIL] nvarchar(50),
        '[THL] NVARCHAR(30),
        '[DIE] NVARCHAR(35),
        '[NAME] [varchar](50) NULL)
        Dim SQL As String = ""
        If IsNew Then

            Sql = "insert into HOTELS (EMAIL,NAME,THL,DIE) VALUES ('" + txtemail.Text + "','" + Replace(txtname.Text, "'", "`") + "','" + TxtTHL.Text + "','" + TxtTHL.Text + "')"

        Else
            Sql = "UPDATE HOTELS SET EMAIL='" + txtemail.Text + "',NAME='" + txtname.Text + "',THL='" + TxtTHL.Text + "',DIE='" + txtDie.Text + "'  WHERE ID=" + Str(ID)


        End If



        Try
            Debug.Print(SQL)

            ExecuteSQLQuery(SQL)
        Catch ex As Exception
            MsgBox("ΔΕΝ ΚΑΤΕΧΩΡΗΘΗ " + Err.Description)
        End Try

        Me.Close()





    End Sub

    Private Sub FrmADDSUPPLIER_ITEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtEmail.Select()
        txtEmail.Focus()
    End Sub
End Class