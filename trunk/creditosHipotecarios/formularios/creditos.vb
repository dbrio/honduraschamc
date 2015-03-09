Public Class creditos
    Public clienteCodigo As String

  
    Private Sub creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClienteTableAdapter.Fill(Me.DataSetAMCProduccion.Cliente, clienteCodigo)

    End Sub
End Class