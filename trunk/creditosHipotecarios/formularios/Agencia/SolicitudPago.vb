Public Class SolicitudPago
    Public hipotecaEstadoId As Integer
    Public estadioId As Integer
    Dim db As New DataSetLinQDataContext

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtGastos.Text.Trim = "" Then
            MessageBox.Show("Es necesario un número de Gastos ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtGastos.Show()
            txtGastos.Focus()

            Exit Sub
        End If

        If txtHonorario.Text.Trim = "" Then
            MessageBox.Show("Es necesario un número de Honorarios ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHonorario.Show()
            txtHonorario.Focus()

            Exit Sub
        End If

        If txtComision.Text.Trim = "" Then
            MessageBox.Show("Es necesario un número de Comisión ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtComision.Show()
            txtComision.Focus()

            Exit Sub
        End If

        Try

            Dim idPrest = (From he In db.hipotecaEstado
                           Join h In db.Hipoteca On he.hipotecaId Equals h.hipotecaId
                           Join p In db.prestamo On h.prestamoId Equals p.prestamoId
                           Where he.hipotecaEstadoId = hipotecaEstadoId
                           Select p.prestamoId).FirstOrDefault

            Dim InsertarMemo As New Memo With {
                .gastos = CDec(txtGastos.Text),
                .honorarios = CDec(txtHonorario.Text),
                .valorComisionAmc = CDec(txtComision.Text),
                .hipotecaId = CDec(hipotecaEstadoId)
            }

            db.Memo.InsertOnSubmit(InsertarMemo)
            db.SubmitChanges()

            HipotecaEstadoTableAdapter.UpdateQuery(estadioId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)


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
End Class