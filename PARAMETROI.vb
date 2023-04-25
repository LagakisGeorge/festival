Public Class PARAMETROI

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ff As String = "MM/dd/yyyy HH:mm"
        Dim ci1 As String = Format(DateTimePicker1.Value, ff)
        Dim ci2 As String = Format(DateTimePicker2.Value, ff)

        ExecuteSQLQuery("update MEM SET HMEARX='" + ci1 + "',HMETEL='" + ci2 + "'")
    End Sub

    Private Sub PARAMETROI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DT2 As New DataTable
        DT2 = Execute2SQLQuery("SELECT ISNULL(HMEARX,GETDATE()) AS HMEARX,ISNULL(HMETEL,GETDATE()) AS HMETEL FROM MEM")
        DateTimePicker1.Value = DT2.Rows(0)("HMEARX")
        DateTimePicker2.Value = DT2.Rows(0)("HMETEL")

    End Sub
End Class