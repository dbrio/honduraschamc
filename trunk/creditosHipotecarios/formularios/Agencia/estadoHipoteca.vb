Public Class estadoHipoteca

  
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombre As String = txtBuscar.Text
        Dim nombreNuevo As String = "%" + nombre + "%"

        Me.MostrarEstadoTableAdapter.Fill(DataSetCreditos.MostrarEstado, nombreNuevo)

    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnBuscar_Click(sender, e)
        End If
    End Sub
End Class