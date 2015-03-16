Imports System.IO
Imports System.Text
Imports System.Security.Cryptography


Public Class login

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            Dim key As String = txtPass.Text
            Dim keyCryto As String = Crypto.Encrypt(txtPass.Text, key)

            Dim login As Integer = UsuarioTableAdapter.sp_Login(txtUser.Text, keyCryto)

            If txtUser.Text = Nothing Then
                txtUser.Text = MessageBox.Show("Es necesario un usuario", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUser.Text = ""
                txtUser.Focus()
                Exit Sub
            End If


            If txtPass.Text = Nothing Then
                txtPass.Text = MessageBox.Show("Es necesario una contraseña", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPass.Text = ""
                txtPass.Focus()
                txtPass.BackColor = Color.Azure

                Exit Sub
            End If



            'comprovar si el usuario existe en la base de datos

            If login = 1 Then
                With Inicio
                    .Text = "Adel Microcréditos | Créditos Hipotecarios"

                End With

                Dim idUsuario As Integer = UsuarioTableAdapter.ScalarQuery(txtUser.Text, keyCryto)

                UsuarioActivo.usuario = idUsuario

                Inicio.Show()
                Me.Close()


            Else
                MessageBox.Show("Usuario ó Contraseña incorrecta", "Adel Microcréditos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUser.Text = ""
                txtPass.Text = ""
                txtUser.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


 

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnEnter_Click(sender, e)
        End If
    End Sub
End Class
