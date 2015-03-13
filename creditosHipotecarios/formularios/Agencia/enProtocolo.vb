Public Class enProtocolo

    Public idCargar As Integer

  
    Private Sub enProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarDatos()

    End Sub

    Sub cargarDatos()
        Me.HipotecaEestadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEestado, idCargar)
    End Sub


   
   
End Class