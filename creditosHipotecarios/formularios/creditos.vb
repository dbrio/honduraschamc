Public Class creditos
    Public clienteCodigo As String
    Public nombre As String

    Private Sub creditos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        garantias.Enabled = True


    End Sub


  
    Private Sub creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ClienteTableAdapter.Fill(Me.DataSetAMCProduccion.Cliente, clienteCodigo)

            LabelNombre.Text = nombre
            With garantias
                .Enabled = False
                .GrantiaHipotecariaGridControl.Enabled = False

            End With

        Catch ex As Exception
            MsgBox("No existe ningun valor")
            With garantias
                .Enabled = False
                .GrantiaHipotecariaGridControl.Enabled = False

            End With
        End Try
       


    End Sub


End Class