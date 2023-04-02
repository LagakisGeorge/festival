Public Class test

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "Product ID"
        DataGridView1.Columns(1).Name = "Product Name"
        DataGridView1.Columns(2).Name = "Product_Price"

        Dim row As String() = New String() {"1", "Product 1", "1000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"2", "Product 2", "2000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"3", "Product 3", "3000"}
        DataGridView1.Rows.Add(row)
        row = New String() {"4", "Product 4", "4000"}
        DataGridView1.Rows.Add(row)

        Dim btn As New DataGridViewButtonColumn()
        DataGridView1.Columns.Add(btn)
        btn.HeaderText = "Click Data"
        btn.Text = "Click Here"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 3 Then
            MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
        End If
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows(1).Cells(2).Value = "SSS"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim HTR As New DataTable
        ' ΒΑΖΩ ΕΠΙΚΕΦΑΛΙΔΕΣ
        ExecuteSQLQuery("select MAX(DATECHECKIN) AS MAX1,MIN(DATECHECKIN) AS MIN1 from HOTROOMDAYS  ", HTR)
        Dim mApo As Date = HTR.Rows(0)("MIN1")
        Dim mEos As Date = HTR.Rows(0)("MAX1")
        Dim hmeres As Integer = DateDiff("d", mApo, mEos) + 1
        Dim hmera As Date = mApo
        'If DGV.Columns.Count < hmeres Then
        '    For l As Integer = 1 To DGV.Columns.Count - hmeres
        '        DGV.Columns.Add("aaa", "--")


        '    Next
        'End If
        DGV.RowHeadersVisible = False
        DGV.Columns(0).HeaderCell.Value = "Ξεν"
        DGV.Columns(1).HeaderCell.Value = "Δωμ"
        Dim pl As Integer = 40
        ' ΔΕΙΧΝΩ ΤΙΣ ΜΕΡΕΣ
        For nn As Integer = 2 To hmeres + 1
            DGV.Columns(nn).Width = pl
            'DGV.Rows(0).Cells(nn).Value = Format(hmera, "dd/MM")
            DGV.Columns(nn).HeaderCell.Value = Format(hmera, "dd/MM")
            hmera = DateAdd("d", 1, hmera)

        Next

        DGV.RowHeadersVisible = True


        ' DEIXNΩ ΔΩΜΑΤΙΑ & ΞΕΝΟΔΟΧΕΙΑ
        ExecuteSQLQuery("select H.NAME,R.ROOMN from HOTROOMS R inner join HOTELS H ON H.ID=R.HOTELID ORDER BY H.NAME,R.ROOMN ", HTR)

        For K As Integer = 0 To HTR.Rows.Count - 1
            DGV.Rows.Add()

            DGV.Rows(K).Cells(0).Value = HTR.Rows(K)("name")
            DGV.Rows(K).Cells(1).Value = HTR.Rows(K)("roomn")

        Next


        ExecuteSQLQuery("select HOTELNAME,ROOMN,DATECHECKIN,ISNULL(IDPEL,0) AS IDPEL from HOTROOMDAYS ORDER BY HOTELNAME,ROOMN ", HTR)
        Dim X As String, R As String
        For K As Integer = 0 To HTR.Rows.Count - 1
            'ΠΡΟΣΔΙΟΡΙΖΩ ΤΗΝ ΣΕΙΡΑ
            X = Trim(HTR.Rows(K)("HOTELname"))
            R = Trim(HTR.Rows(K)("ROOMN"))
            Dim seira As Integer = 0
            For i As Integer = 0 To DGV.Rows.Count - 1
                If X = DGV.Rows(i).Cells(0).Value And R = DGV.Rows(i).Cells(1).Value Then
                    seira = i
                    Exit For
                End If
            Next

            'ΠΡΟΣΔΙΟΡΙΖΩ ΤΗΝ ΣΤΗΛΗ
            Dim cc As String = Format(HTR.Rows(K)("datecheckin"), "dd/MM")
            Dim sthlh As Integer = 0
            For i = 0 To DGV.Columns.Count - 1
                If cc = DGV.Columns(i).HeaderCell.Value Then
                    sthlh = i
                    Exit For
                End If
            Next
            DGV.Rows(seira).Cells(sthlh).Style.BackColor = Color.Red
            DGV.Rows(seira).Cells(sthlh).Value = HTR.Rows(K)("idpel")




        Next

    End Sub

    
    Private Sub Krarhseis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Krarhseis.Click
        Dim PEL As New DataTable
        ' ΦΟΡΤΩΝΩ ΤΟΥΣ ΠΕΛΑΤΕΣ
        Dim MDAY As String, dcin As Date
        ExecuteSQLQuery("select * from PEL  ", PEL)
        For K As Integer = 0 To PEL.Rows.Count - 1
            MDAY = Format(PEL.Rows(K)("CHECKIN"), "dd/MM") ' βρηκα την ημερα checkin
            dcin = PEL.Rows(K)("CHECKIN") ' βρηκα την ημερα checkin
            ' α τροπος κρατησεις με database    ( b me pinaka datagridview)
            Dim HTR As New DataTable
            ' ΒΑΖΩ ΕΠΙΚΕΦΑΛΙΔΕΣ
            ExecuteSQLQuery("select DATECHECKIN,IDPEL,D.ID AS ID,HOTELID from HOTROOMDAYS D INNER JOIN HOTELS H ON D.HOTELID=H.ID  WHERE IDPEL=0 ORDER BY RANK ", HTR)
            For L As Integer = 0 To HTR.Rows.Count - 1
                ExecuteSQLQuery("UPDATE PEL SET NUM1=" + HTR.Rows(0)("ID").ToString + ",NUM2=" + HTR.Rows(0)("HOTELID").ToString + " WHERE ID=" + HTR(0)("PELID").ToString)
                ExecuteSQLQuery("UPDATE HOTROOMDAYS SET IDPEL=" + PEL(0)("ID").ToString + " WHERE ID=" + HTR(0)("ID"))

            Next





        Next

    End Sub
End Class