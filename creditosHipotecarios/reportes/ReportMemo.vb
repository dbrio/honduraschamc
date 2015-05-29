Public Class ReportMemo
    Public IDm As Integer
   
    Public Sub generarReporte()
        Try
            MemoReportTableAdapter.Fill(DataSetCreditos1.MemoReport, IDm)
        Catch ex As Exception

        End Try
    End Sub

End Class