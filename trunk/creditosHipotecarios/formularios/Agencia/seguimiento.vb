Public Class seguimiento
    Public idPrestamo As Integer



    Private Sub seguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.SeguimientoTableAdapter.Fill(Me.DataSetCreditos.seguimiento, CType(IdPrestamoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub cargar()
        Me.SeguimientoTableAdapter.Fill(Me.DataSetCreditos.seguimiento, idPrestamo)
    End Sub
End Class