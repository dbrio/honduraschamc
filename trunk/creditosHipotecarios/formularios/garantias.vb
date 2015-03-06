Public Class garantias

    Private Sub GrantiaHipotecariaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GrantiaHipotecariaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAMCProduccion)

    End Sub

    Private Sub addHipoteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetAMCProduccion.GrantiaHipotecaria' Puede moverla o quitarla según sea necesario.
        Me.GrantiaHipotecariaTableAdapter.Fill(Me.DataSetAMCProduccion.GrantiaHipotecaria)

    End Sub


    Private Sub GrantiaHipotecariaGridControl_DoubleClick(sender As Object, e As EventArgs) Handles GrantiaHipotecariaGridControl.DoubleClick
        With addHipoteca
            With addHipoteca
                .MdiParent = MdiParent
                .Show()
                .Focus()
            End With
        End With
    End Sub
End Class