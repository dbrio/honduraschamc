Public Class buscarHipoteca


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombre As String = txtBuscar.Text
        Dim nombreNuevo As String = "%" + nombre + "%"

        Me.MostrarEstadoTableAdapter.Buscar(DataSetCreditos.MostrarEstado, nombreNuevo)

    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnBuscar_Click(sender, e)
        End If
    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("id") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "prestamoId")

        Return diccionario

    End Function


    

    Private Sub MostrarEstadoGridControl_DoubleClick(sender As Object, e As EventArgs) Handles MostrarEstadoGridControl.DoubleClick

        Dim dict As Hashtable = obtenerDatos()
        Dim id As String = dict("id")

        With seguimiento
            .idPrestamo = id
            .Show()

        End With

    End Sub
End Class