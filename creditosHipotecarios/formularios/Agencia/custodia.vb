Public Class custodia
    Public hipotecaEstadoId As Integer
    Public estadoId As Integer
    Dim db As New DataSetLinQDataContext

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        'If txtMatricula.Text.Trim = "" Then
        '    MessageBox.Show("Es necesario un número de Matrícula ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtMatricula.Show()
        '    txtMatricula.Focus()

        '    Exit Sub
        'End If


        'If txtAsiento.Text.Trim = "" Then
        '    MessageBox.Show("Es necesario un número de Asiento ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtAsiento.Show()
        '    txtAsiento.Focus()

        '    Exit Sub
        'End If


        'If txtTomo.Text.Trim = "" Then
        '    MessageBox.Show("Es necesario un número de Tomo ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtTomo.Show()
        '    txtTomo.Focus()

        '    Exit Sub
        'End If

        Try
            Dim idPrest = (From he In db.hipotecaEstado
                           Join h In db.Hipoteca On he.hipotecaId Equals h.hipotecaId
                           Join p In db.prestamo On h.prestamoId Equals p.prestamoId
                           Where he.hipotecaEstadoId = hipotecaEstadoId
                           Select p.prestamoId).FirstOrDefault


            HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)

            HipotecaTableAdapter.UpdateCustodia(txtMatricula.Text, txtAsiento.Text, txtTomo.Text, idPrest)

            With enProtocolo
                .MdiParent = Inicio
                .Show()
                .Focus()
                .cargarDatos()
            End With
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub custodia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True

    End Sub


  
    Private Sub custodia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.Enabled = False
    End Sub
End Class