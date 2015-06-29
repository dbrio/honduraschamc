Public Class ReportFECHA
    Public fechaInicio As Date
    Public fechaFinal As Date

    Public Sub generarReporte()
        Try
            _ReporteFechaTableAdapter.Fill(DataSetCreditos1._ReporteFecha, fechaInicio, fechaFinal)
            XrLabel3.Text = Now.Date()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class