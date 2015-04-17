Imports DevExpress.XtraReports.UI

Public Class fechas


    Private Sub fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub


    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextInicio.EditValueChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If TextInicio.Text.Trim = "" Then
            MsgBox("Debe de seleccionar una fecha inicial", MsgBoxStyle.Critical)
            TextInicio.Focus()
            Exit Sub
        End If

        If TextFinal.Text.Trim = "" Then
            MsgBox("Debe de seleccionar una fecha inicial", MsgBoxStyle.Critical)
            TextFinal.Focus()
            Exit Sub
        End If

        Dim reporte As New ReportFECHA() With {.fechaInicio = TextInicio.Text, .fechaFinal = TextFinal.Text}
        reporte.generarReporte()

        Dim printTool As New ReportPrintTool(reporte)
        printTool.Report.CreateDocument(False)
        printTool.ShowRibbonPreviewDialog()
    End Sub
End Class