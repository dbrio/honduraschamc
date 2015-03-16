Public Class enProtocolo

    Public idCargar As Integer
    Public titulo As String

  
    Private Sub enProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarDatos()

    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("hipotecaId") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "hipotecaId")
        
        Return diccionario

    End Function

    Sub cargarDatos()
        Try
            Me.Text = titulo
            Me.HipotecaEestadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEestado, idCargar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
   
   


    Private Sub HipotecaEestadoGridControl_Click(sender As Object, e As EventArgs) Handles HipotecaEestadoGridControl.Click
        Dim dict As Hashtable = obtenerDatos()
        Dim hipotecaId As String = dict("hipotecaId")


        MsgBox(hipotecaId)
    End Sub
End Class