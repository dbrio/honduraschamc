Public Class pudatePersonal
    Public personalId As Integer

    Private Sub pudatePersonal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True
    End Sub

    Private Sub pudatePersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Inicio.Enabled = False

        Me.CargoTableAdapter.Fill(Me.DataSetCreditos.Cargo)

        Me.AgenciaTableAdapter.Fill(Me.DataSetCreditos.Agencia)

        Me.PersonalTableAdapter.FillBy(Me.DataSetCreditos.Personal, personalId)

    End Sub

    Private Sub PersonalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PersonalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            PersonalTableAdapter.UpdateQuery(NombresTextEdit.Text, ApellidosTextEdit.Text, CodigoAgenciaComboBox.SelectedValue, CargoIdComboBox.SelectedValue, personalId)

            MsgBox("Empleado actualizado", MsgBoxStyle.Information)

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