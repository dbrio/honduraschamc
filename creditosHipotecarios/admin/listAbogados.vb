Public Class listAbogados

    Private Sub AbogadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AbogadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub listAbogados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Abogado' Puede moverla o quitarla según sea necesario.
        cargarDatos()


    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim ID As Integer = dameIdAbogado()


        With updateAgogado
            .abogadoId = ID
            .Show()

        End With
    End Sub


    Private Function dameIdAbogado() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "abogadoId")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Sub cargarDatos()
        Try
            Me.AbogadoTableAdapter.Fill(Me.DataSetCreditos.Abogado)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class