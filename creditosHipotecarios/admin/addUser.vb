Public Class addUser
    Public personalId As Integer

    Dim db As New DataSetLinQDataContext

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub addUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True
    End Sub

    Private Sub addUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Usuario' Puede moverla o quitarla según sea necesario.
        Inicio.Enabled = False

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            Dim ComprovarUsuario = (From c In db.Usuario
                                    Where c.usuario = UsuarioTextEdit.Text
                                    Select c.usuario).FirstOrDefault

            If ComprovarUsuario = UsuarioTextEdit.Text Then
                MsgBox("El usuario ya esta en uso ", MsgBoxStyle.Information)
            Else
                Dim key As String = ContrasenaTextEdit.Text
                Dim keyCryto As String = Crypto.Encrypt(ContrasenaTextEdit.Text, key)

                Dim estado As Integer
                If EstadoCheckEdit.Checked = True Then
                    estado = 1
                Else
                    estado = 0
                End If
                UsuarioTableAdapter.InsertQuery(UsuarioTextEdit.Text, keyCryto, personalId, estado)

                MsgBox("Usuario Agregado ", MsgBoxStyle.Information)

                With listEmpleados
                    .Show()
                    .MdiParent = Inicio
                    .cargarDatos()
                End With

                Me.Close()
            End If

          

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class