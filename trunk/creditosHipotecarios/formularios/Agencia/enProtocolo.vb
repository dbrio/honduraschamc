Public Class enProtocolo

    Public idCargar As Integer
    Public titulo As String

  
    Private Sub enProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.hipotecaEstado' Puede moverla o quitarla según sea necesario.
        Me.HipotecaEstadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEstado)
       


        cargarDatos()

    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("hipotecaEstadoId") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "hipotecaEstadoId")


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
   
   
  

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Try
           

            Dim dict As Hashtable = obtenerDatos()
            Dim hipotecaId As String = dict("hipotecaEstadoId")
            Dim estadoId As Integer = idCargar + 1
            If MsgBox("¿Actualizar el estado?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
                HipotecaEstadoTableAdapter.UpdateQuery(estadoId, hipotecaId)
            End If


            cargarDatos()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class