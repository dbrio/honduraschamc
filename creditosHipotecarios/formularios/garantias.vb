Public Class garantias

    Private Sub GrantiaHipotecariaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GrantiaHipotecariaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAMCProduccion)

    End Sub

    Private Sub addHipoteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        llenarGrid()

    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("nombre") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nomdeudor")
        diccionario("valor2") = 2015
        Return diccionario

    End Function

    'Private Sub GrantiaHipotecariaGridControl_DoubleClick(sender As Object, e As EventArgs)
    '    With addHipoteca
    '        With addHipoteca
    '            .MdiParent = MdiParent
    '            .Show()
    '            .Focus()
    '        End With
    '    End With
    'End Sub


    Sub llenarGrid()
        Me.GrantiaHipotecariaTableAdapter.Fill(Me.DataSetAMCProduccion.GrantiaHipotecaria)
    End Sub


    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Trim = "" Then
            MessageBox.Show("Escriba un nombre nombre para buscar", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            llenarGrid()
            txtBuscar.Focus()
        Else
            Dim texto As String = txtBuscar.Text
            Dim buscar As String = "%" + texto + "%"
            Me.GrantiaHipotecariaTableAdapter.bauscar(Me.DataSetAMCProduccion.GrantiaHipotecaria, buscar)
            txtBuscar.Text = ""
            txtBuscar.Focus()
        End If
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnBuscar_Click_1(sender, e)
        End If
    End Sub

   
    Private Sub VerGrantiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerGrantiaToolStripMenuItem.Click

        Dim dict As Hashtable = obtenerDatos()
        MsgBox(dict("nombre"))

    End Sub
End Class