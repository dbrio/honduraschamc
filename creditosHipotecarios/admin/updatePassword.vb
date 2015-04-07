Public Class updatePassword

    Dim db As New DataSetLinQDataContext

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim key As String = txtPass.Text
        Dim keyCryto As String = Crypto.Encrypt(txtPass.Text, key)


        If txtPass.Text.Trim = "" Then
            MsgBox("Escribir una contraseña ", MsgBoxStyle.Critical)
            txtPass.Focus()
            Exit Sub

        End If

        If txtRePass.Text.Trim = "" Then
            MsgBox("Escribir una contraseña ", MsgBoxStyle.Critical)
            txtRePass.Focus()
            Exit Sub

        End If

        If txtPass.Text = txtRePass.Text Then
            UsuarioTableAdapter.UpdateContrasena(keyCryto, UsuarioActivo.usuario)

            MsgBox("Contraseña acutalizada ", MsgBoxStyle.Information)
            login.Show()
            Me.Close()
            Inicio.Close()

        Else
            MsgBox("Las contraseñas son distintas ", MsgBoxStyle.Critical)
            txtPass.Focus()
        End If

    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub updatePassword_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True

    End Sub

    Private Sub updatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim user = (From u In db.Usuario
                       Where u.usuarioId = UsuarioActivo.usuario
                       Select u.usuario).FirstOrDefault

        Label3.Text = user

        Inicio.Enabled = False

    End Sub
End Class