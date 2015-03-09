Public Class garantias

    Private Sub GrantiaHipotecariaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GrantiaHipotecariaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAMCProduccion)

    End Sub



    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("codigoCliente") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "numclien")
        diccionario("nombre") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nomdeudor")
        diccionario("propietario") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "owngarant")
        diccionario("descripcion") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "descripcio")


        Return diccionario

    End Function



    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Trim = "" Then
            MessageBox.Show("Escriba un nombre nombre para buscar", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtBuscar.Focus()
        Else
            Dim texto As String = txtBuscar.Text
            Dim buscar As String = "%" + texto + "%"
            Me.GrantiaHipotecariaTableAdapter.bauscar(Me.DataSetAMCProduccion.GrantiaHipotecaria, buscar)
            txtBuscar.Text = ""
            txtBuscar.Focus()
            GrantiaHipotecariaGridControl.Enabled = True
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnBuscar_Click_1(sender, e)
        End If
    End Sub


    Private Sub VerGrantiaToolStripMenuItem_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub GrantiaHipotecariaGridControl_DoubleClick(sender As Object, e As EventArgs) Handles GrantiaHipotecariaGridControl.DoubleClick
        Dim dict As Hashtable = obtenerDatos()
        Dim codigoCliente As String = dict("codigoCliente")
        Dim nombre As String = dict("nombre")
        Dim propietario As String = dict("propietario")
        Dim descripcion As String = dict("descripcion")
        With creditos

            .clienteCodigo = codigoCliente
            .nombre = nombre
            .propietario = propietario
            .descripcion = descripcion
            .Show()
            .Focus()

        End With

    End Sub

    Private Sub garantias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrantiaHipotecariaGridControl.Enabled = False
    End Sub
End Class