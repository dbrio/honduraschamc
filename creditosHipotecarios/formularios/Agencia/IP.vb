Public Class IP
    Public hipotecaEstadoId As Integer
    Public estadoId As Integer

    Dim db As New DataSetLinQDataContext
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click



        If txtIP.Text.Trim = "" Then
            MessageBox.Show("Es necesario un número de IP ", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            Dim idPrest = (From he In db.hipotecaEstado
                           Join h In db.Hipoteca On he.hipotecaId Equals h.hipotecaId
                           Join p In db.prestamo On h.prestamoId Equals p.prestamoId
                           Where he.hipotecaEstadoId = hipotecaEstadoId
                           Select p.prestamoId).FirstOrDefault


            HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)

            HipotecaTableAdapter.UpdateIP(CInt(txtIP.Text), idPrest)

            With enProtocolo
                .MdiParent = Inicio
                .Show()
                .Focus()
                .cargarDatos()
            End With
            Me.Close()


        Catch ex As Exception

        End Try



    End Sub




    Private Sub IP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.hipotecaEstado' Puede moverla o quitarla según sea necesario.
        Me.HipotecaEstadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEstado)

    End Sub
End Class