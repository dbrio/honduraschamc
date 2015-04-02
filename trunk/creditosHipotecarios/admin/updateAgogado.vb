Public Class updateAgogado
    Public abogadoId As Integer

    Private Sub AbogadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AbogadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub updateAgogado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Inicio.Enabled = True
    End Sub

    Private Sub updateAgogado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.Enabled = False

        cargarDatos()


    End Sub

    Sub cargarDatos()
        Try
            Me.AbogadoTableAdapter.FillBy(Me.DataSetCreditos.Abogado, abogadoId)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
    '    AbogadoTableAdapter.Update(NombresTextEdit.Text, ApellidosTextEdit.Text, TelefonoTextEdit.Text, DireccionMemoEdit.Text, CodigoAbogadoTextEdit.Text, CorreoTextEdit.Text)
    'End Sub
End Class