
Public Class enProtocolo
  
    Public idCargar As Integer
    Public titulo As String


    Private Sub enProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CAGAR DATOS
        cargarDatos()

    End Sub


    'FUNCION PARA OBTENER DATOS 
    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("hipotecaEstadoId") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "hipotecaEstadoId")
        Return diccionario

    End Function

    'LLENAR LOS DATOS  EN EL GRIDCONTROL
    Sub cargarDatos()
        Try
            Me.Text = titulo
            If UsuarioActivo.cargo = "Iformatica" Then
                Me.HipotecaEestadoTableAdapter.FillInformatica(Me.DataSetCreditos.hipotecaEestado, idCargar)

            Else
                Me.HipotecaEestadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEestado, idCargar, UsuarioActivo.codigoAgencia)

            End If

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

            'CARGAR DATOS
            cargarDatos()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
End Class