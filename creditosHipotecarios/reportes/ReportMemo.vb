Public Class ReportMemo
    Public IDm As Integer
   
    Public Sub generarReporte()
        Try
            MemoAdapter1.Fill(Remportmemo1.Memo, IDm)
        Catch ex As Exception

        End Try
    End Sub

End Class