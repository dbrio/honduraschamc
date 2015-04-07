Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraReports.UI

Public Class enProtocolo
    Private stream As New MemoryStream
    Public idCargar As Integer
    Public titulo As String
    Dim db As New DataSetLinQDataContext


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
            If UsuarioActivo.cargo = "PROVEEDURIA" Then
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


            'SI SE VA ACTUALIZAR EL ESTADO DE IP DEBERA PERDIR UN NUMERO DE IP EN EL FORMULARIO IP

            If Me.Text = "PARA EN IP" Then

                Dim dict As Hashtable = obtenerDatos()
                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim estadoId As Integer = idCargar + 1

                With IP
                    .Show()
                    .hipotecaEstadoId = hipotecaEstadoId
                    .estadoId = estadoId
                End With


            ElseIf Me.Text = "EVIAR A CUSTODIA" Then
                Dim dict As Hashtable = obtenerDatos()
                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim estadoId As Integer = idCargar + 1

                With custodia
                    .Show()
                    .hipotecaEstadoId = hipotecaEstadoId
                    .estadoId = estadoId
                End With

            ElseIf Me.Text = "SOLICITAR PAGO" Then
                Dim dict As Hashtable = obtenerDatos()
                Dim estadoId As Integer = idCargar + 1

                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")

                With SolicitudPago
                    .Show()
                    .hipotecaEstadoId = hipotecaEstadoId
                    .estadioId = estadoId
                End With

            ElseIf Me.Text = "EFECTURAR PAGO" Then

                Dim dict As Hashtable = obtenerDatos()
                Dim estadoId As Integer = idCargar + 1

                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")


                HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)

                Dim idMemo = (From m In db.Memo
                               Where m.hipotecaId = hipotecaEstadoId
                               Select m.memoId).FirstOrDefault

                Dim reporte As New ReportMemo() With {.IDm = idMemo}
                reporte.generarReporte()

                Dim printTool As New ReportPrintTool(reporte)
                printTool.Report.CreateDocument(False)
                printTool.ShowRibbonPreviewDialog()



                'CARGAR DATOS
                cargarDatos()


            Else

                Dim dict As Hashtable = obtenerDatos()
                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim estadoId As Integer = idCargar + 1


                If MsgBox("¿Actualizar el estado?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
                    HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)
                End If

                'CARGAR DATOS
                cargarDatos()

                With buscarHipoteca
                    .cargarDaos()
                End With

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class