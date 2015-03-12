Public Class enProtocolo


 
  
    Private Sub enProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.HipotecaEestadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEestado, 1)

    End Sub

   
   
End Class