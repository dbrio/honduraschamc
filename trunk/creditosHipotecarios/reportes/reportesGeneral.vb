Public Class reportesGeneral
    Public idCargar As Integer
    Public titulo As String
    Private Sub reportesGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Try
            Me.Text = titulo

            ReporteGeneralTableAdapter.Fill(Me.DataSetCreditos.ReporteGeneral, idCargar)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtBuscar.Text.Trim = "" Then
                MessageBox.Show("Escriba un nombre nombre para buscar", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                txtBuscar.Focus()
            End If


            Dim texto As String = txtBuscar.Text
            Dim buscar As String = "%" + texto + "%"

            ReporteGeneralTableAdapter.FillBy(Me.DataSetCreditos.ReporteGeneral, idCargar, buscar)


            txtBuscar.Text = ""
            txtBuscar.Focus()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnBuscar_Click(sender, e)
        End If
    End Sub

End Class