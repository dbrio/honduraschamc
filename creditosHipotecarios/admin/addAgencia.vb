Public Class addAgencia

    Private Sub AgenciaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AgenciaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub addAgencia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True

    End Sub

    Private Sub addAgencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Agencia' Puede moverla o quitarla según sea necesario.
        Inicio.Enabled = False
        Me.AgenciaTableAdapter.Fill(Me.DataSetCreditos.Agencia)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCodigo.Text.Trim = "" Then
            MsgBox("Es necesario un código ", MsgBoxStyle.Critical)
            txtCodigo.Focus()

            Exit Sub
        End If

        If txtNombre.Text.Trim = "" Then
            MsgBox("Es necesario un nombre ", MsgBoxStyle.Critical)
            txtNombre.Focus()

            Exit Sub
        End If

        Try
            AgenciaTableAdapter.Insert(txtCodigo.Text, txtNombre.Text)
            MsgBox("Agencia agregada", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class