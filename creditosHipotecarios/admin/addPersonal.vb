Public Class addPersonal

    Private Sub CargoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CargoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub addPersonal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Inicio.Enabled = True
    End Sub

    Private Sub addPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Personal' Puede moverla o quitarla según sea necesario.
        Me.PersonalTableAdapter.Fill(Me.DataSetCreditos.Personal)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Agencia' Puede moverla o quitarla según sea necesario.
        Me.AgenciaTableAdapter.Fill(Me.DataSetCreditos.Agencia)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.DataSetCreditos.Cargo)

        Inicio.Enabled = False

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            PersonalTableAdapter.Insert("", txtNombre.Text, txtApellido.Text, ComboBoxAGE.SelectedValue, ComboBoxCARG.SelectedValue, "", "")

            MsgBox("Empleado agregado", MsgBoxStyle.Information)

            With listEmpleados
                .MdiParent = Inicio
                .Show()
                .cargarDatos()
            End With

            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class