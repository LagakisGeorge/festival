Public Class Fdomatia
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim SQL As String = "INSERT INTO HOTROOMS (ROOMN,HOTELID,DOMATIA,APO,EOS) VALUES(" + domatio.Text + "," + Str(ID) + "," + kreb.Text + ",'" + Format(D1.Value, "MM/dd/yyyy") + "','" + Format(D2.Value, "MM/dd/yyyy") + "')"
        ExecuteSQLQuery(Sql)


        '        CREATE TABLE [dbo].[HOTROOMS](
        '	[ROOMN] [varchar](5) NOT NULL,
        '	[HOTELID] [int] NOT NULL,
        '	[DOMATIA] [int] NULL,
        '	[CATEGORY] [int] NULL,
        '	[APO] [datetime] NULL,
        '	[EOS] [datetime] NULL,
        '	[N1] [real] NULL,
        '	[N2] [real] NULL,
        '	[N3] [real] NULL,
        '	[C1] [nvarchar](50) NULL,
        '	[C2] [nvarchar](50) NULL,
        '	[C3] [nvarchar](50) NULL,
        '	[H1] [datetime] NULL,
        '	[H2] [datetime] NULL,
        '	[H3] [datetime] NULL,
        '	[B1] [bit] NULL,
        '	[B2] [bit] NULL,
        '	[ID] [int] IDENTITY(1,1) NOT NULL,
        ' CONSTRAINT [PK_HOTROOMS] PRIMARY KEY CLUSTERED 
        '(
        '	[ROOMN] ASC,
        '        [HOTELID](Asc)
        ')WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
        ') ON [PRIMARY]
        Dim DT2 As New DataTable
        DT2 = Execute2SQLQuery("select * from HOTROOMS WHERE HOTELID=" + Str(ID))
        Dim N As Integer
        For K As Integer = 0 To DT2.Rows.Count - 1

            ListView1.Items.Add(DT2.Rows(K)("ROOMN"))
            ListView1.Items(N).SubItems.Add(DT2.Rows(K)("APO").ToString)
            ListView1.Items(N).SubItems.Add(DT2.Rows(K)("EOS").ToString)
            ListView1.Items(N).SubItems.Add(DT2.Rows(K)("DOMATIA").ToString)

            N = N + 1

        Next
        'ListView1.Items.Add("77")
        'ListView1.Items.Add("")
        'For k As Integer = 0 To ListView1.Items.Count - 1

        '    ListView1.Items(k).SubItems.Add("1lagakis")
        '    ListView1.Items(k).SubItems.Add("2Accounting")
        '    ListView1.Items(k).SubItems.Add("3John Smith")
        '    ListView1.Items(k).SubItems.Add("4Accounting")
        'Next

        
    End Sub

    Private Sub Fdomatia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PAINTROOMS()

    End Sub

    Private Sub DIAGRAFI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIAGRAFI.Click
        Dim a As String = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
        Dim n As Integer = ListView1.FocusedItem.Index
        ExecuteSQLQuery("delete from HOTROOMS WHERE ROOMN=" + a + "")
        PAINTROOMS()

    End Sub


    Private Sub PAINTROOMS()

        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ListView1.Columns.Add("Δωμάτιο", 100, HorizontalAlignment.Center) 'Column 1
        ListView1.Columns.Add("Από", 100, HorizontalAlignment.Center) 'Column 1
        ListView1.Columns.Add("Εως", 100, HorizontalAlignment.Center) 'Column 1
        ListView1.Columns.Add("Κρεββάτια", 100, HorizontalAlignment.Center) 'Column 1
        Dim DT2 As New DataTable
        DT2 = Execute2SQLQuery("select * from HOTROOMS WHERE HOTELID=" + Str(ID))
        Dim N As Integer
        For K As Integer = 0 To DT2.Rows.Count - 1

            ListView1.Items.Add(DT2.Rows(K)("ROOMN"))
            ListView1.Items(N).SubItems.Add(DT2.Rows(K)("APO").ToString)
            ListView1.Items(N).SubItems.Add(DT2.Rows(K)("EOS").ToString)
            ListView1.Items(N).SubItems.Add(DT2.Rows(K)("DOMATIA").ToString)

            N = N + 1

        Next
    End Sub






    Private Sub DIORTOSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIORTOSI.Click
        If DIORTOSI.BackColor = Color.Green Then
            ExecuteSQLQuery("update HOTROOMS set DOMATIA=" + kreb.Text + " WHERE ROOMN=" + domatio.Text + "")
            'Format(D1.Value, "MM/dd/yyyy") + "'
            ExecuteSQLQuery("update HOTROOMS set APO='" + Format(D1.Value, "MM/dd/yyyy") + "' WHERE ROOMN=" + domatio.Text + "")

            ExecuteSQLQuery("update HOTROOMS set EOS='" + Format(D2.Value, "MM/dd/yyyy") + "' WHERE ROOMN=" + domatio.Text + "")

            DIORTOSI.BackColor = Color.Gray
            DIORTOSI.Text = "Διόρθωση"
            domatio.Enabled = True
            PAINTROOMS()

        Else


            Dim n As Integer
            Try
                n = ListView1.FocusedItem.Index ' OR ListView1.SelectedIndices(0)
            


                domatio.Text = ListView1.Items(n).SubItems(0).Text
                D1.Value = ListView1.Items(n).SubItems(1).Text
                D2.Value = ListView1.Items(n).SubItems(2).Text
                kreb.Text = ListView1.Items(n).SubItems(3).Text
                domatio.Enabled = False

                'Dim n As Integer = ListView1.FocusedItem.Index
                ' ExecuteSQLQuery("delete from HOTELROOMS WHERE ROOMN=" + a + "")
                'PAINTROOMS()
                DIORTOSI.BackColor = Color.Green
                DIORTOSI.Text = "Καταχώρηση"
            Catch
                MsgBox("Διαλέξτε δωμάτιο")
            End Try

        End If
    End Sub
End Class