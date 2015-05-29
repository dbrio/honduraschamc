Public Class seguimiento
    Public idPrestamo As Integer

    Private Sub seguimiento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True
    End Sub



    Private Sub seguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remportmemo.Memo' Puede moverla o quitarla según sea necesario.

        Try
            MemoSeguimientoTableAdapter.Fill(DataSetCreditos.memoSeguimiento, idPrestamo)
            cargar()
            Inicio.Enabled = False
            Dim progreso As Double = CInt(EstadoIdLabel1.Text) * 100 / 11
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = 100
            ProgressBar1.Value = progreso
            Me.Controls.Add(ProgressBar1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub



    Sub cargar()
        Try
            Me.SeguimientoTableAdapter.Fill(Me.DataSetCreditos.seguimiento, idPrestamo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
 
    Private Sub ProgressBar1_SystemColorsChanged(sender As Object, e As EventArgs) Handles ProgressBar1.SystemColorsChanged
        Me.ProgressBar1.ForeColor = Color.AliceBlue
        Me.ProgressBar1.BackColor = Color.Aqua
    End Sub

 
End Class