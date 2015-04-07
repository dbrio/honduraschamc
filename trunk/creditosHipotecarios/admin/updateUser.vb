Public Class updateUser
    Public personalId As Integer

    Private Sub updateUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True
    End Sub

    Private Sub updateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Usuario' Puede moverla o quitarla según sea necesario.

        Inicio.Enabled = False

        Me.UsuarioTableAdapter.FillBy(Me.DataSetCreditos.Usuario, personalId)

    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim estado As Boolean

            If EstadoCheckEdit.Checked = True Then
                estado = True
            Else
                estado = False

            End If

            Dim key As String = ContrasenaTextBox.Text
            Dim keyCryto As String = Crypto.Encrypt(ContrasenaTextBox.Text, key)

            UsuarioTableAdapter.UpdateQuery(UsuarioTextBox.Text, keyCryto, estado, personalId)

            MsgBox("Usuario actualizado ", MsgBoxStyle.Information)

            With listEmpleados
                .MdiParent = Inicio
                .cargarDatos()
                .Show()

            End With
            Me.Close()


        Catch ex As Exception

        End Try
    End Sub
End Class