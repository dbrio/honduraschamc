Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports DevExpress.XtraReports.UI


Public Class login
    Dim db As New DataSetLinQDataContext
    Public inactivdad As String
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

            Dim estadoUser = (From a In db.Usuario
                          Where a.usuario = txtUser.Text And a.contrasena = keyCryto
                          Select a.estado).FirstOrDefault

            If login = 1 And estadoUser = "True" Then
                With Inicio
                    .Text = "Adel Microcréditos"

                End With


                Dim idUsuario As Integer = UsuarioTableAdapter.ScalarQuery(txtUser.Text, keyCryto)

                UsuarioActivo.usuario = idUsuario

                Dim cargo As String = UsuarioTableAdapter.ObtenerCargo(idUsuario)

                Dim codigoAgencia As String = UsuarioTableAdapter.obtenerAgencia(idUsuario)

                UsuarioActivo.codigoAgencia = codigoAgencia

                UsuarioActivo.cargo = cargo
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub




    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnEnter_Click(sender, e)
        End If
    End Sub


    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#29347B")
        btnEnter.BackColor = ColorTranslator.FromHtml("#009D84")
        btnSalir.BackColor = ColorTranslator.FromHtml("#FFC500")
        'Panel1.BackColor = ColorTranslator.FromHtml("#323D44")
        Label1.Text = "Adel Microcréditos"

    End Sub



 


End Class
