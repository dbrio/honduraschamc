Public Class addAbogado

    Private Sub addAbogado_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Inicio.Enabled = True
    End Sub




    Private Sub addAbogado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.Enabled = False
    End Sub

    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If NombresTextEdit.Text.Trim = "" Then
            MessageBox.Show("Es necesario un nombre ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NombresTextEdit.Focus()

            Exit Sub
        End If

        If ApellidosTextEdit.Text.Trim = "" Then
            MessageBox.Show("Es necesarios los apellido ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ApellidosTextEdit.Focus()

            Exit Sub
        End If

        If TelefonoTextEdit.Text.Trim = "" Then
            MessageBox.Show("Es necesario un número de teléfono ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TelefonoTextEdit.Focus()

            Exit Sub
        End If

        If CorreoTextEdit.Text.Trim = "" Then
            MessageBox.Show("Es necesario un correo ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CorreoTextEdit.Focus()


            Exit Sub
        End If

        If DireccionMemoEdit.Text.Trim = "" Then
            MessageBox.Show("Es necesaria una dirección del Bufete", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DireccionMemoEdit.Focus()
            Exit Sub
        End If

        Try
            AbogadoTableAdapter.Insert(NombresTextEdit.Text, ApellidosTextEdit.Text, TelefonoTextEdit.Text, DireccionMemoEdit.Text, CodigoAbogadoTextEdit.Text, CorreoTextEdit.Text)



            MsgBox("Abogado agregado ", MsgBoxStyle.Information)

            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub
End Class