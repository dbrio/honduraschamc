Public Class observacion
    Public hiptecaEstadoId As Integer

    Private Sub observacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True
    End Sub

    Private Sub observacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.hipotecaEstado' Puede moverla o quitarla según sea necesario.
        'Me.HipotecaEstadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEstado)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.hipotecaEstado' Puede moverla o quitarla según sea necesario.
        Me.HipotecaEstadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEstado)
        Inicio.Enabled = False
        'HipotecaEestadoTableAdapter.FillInformatica(DataSetCreditos.hipotecaEestado, hiptecaEstadoId)

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            HipotecaEestadoTableAdapter.UpdateQuery(TextBox1.Text, hiptecaEstadoId)
            MsgBox("Observación agregada", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class