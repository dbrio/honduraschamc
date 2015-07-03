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
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.prestamo' Puede moverla o quitarla según sea necesario.
        'Me.PrestamoTableAdapter.Fill(Me.DataSetCreditos.prestamo)
        'CAGAR DATOS

        TextBoxBuscar.Focus()


        If UsuarioActivo.cargo = "INFORMATICA" Then
            RegresarToolStripMenuItem.Visible = True

        End If
        cargarDatos()
        Inicio.cargarNumeros()

    End Sub


    'FUNCION PARA OBTENER DATOS 
    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("hipotecaEstadoId") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "hipotecaEstadoId")
        diccionario("numreferen") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "numreferen")


        Return diccionario

    End Function

    'LLENAR LOS DATOS  EN EL GRIDCONTROL
    Sub cargarDatos()
        Try
            Me.Text = titulo
            If UsuarioActivo.cargo = "ARCHIVO" Or UsuarioActivo.cargo = "INFORMATICA" Then
                Me.HipotecaEestadoTableAdapter.FillInformatica(Me.DataSetCreditos.hipotecaEestado, idCargar)
                Inicio.cargarNumeros()
            Else
                Me.HipotecaEestadoTableAdapter.Fill(Me.DataSetCreditos.hipotecaEestado, idCargar, UsuarioActivo.codigoAgencia)
                Inicio.cargarNumeros()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub








    Private Sub AGREGARNOTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARNOTAToolStripMenuItem.Click
        Dim dict As Hashtable = obtenerDatos()
        Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")

        If hipotecaEstadoId = Nothing Then
            MsgBox("Seleccione un valor")
        Else
            With observacion
                .hiptecaEstadoId = hipotecaEstadoId
                .Show()

            End With
        End If

       
    End Sub

    Private Sub RegresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarToolStripMenuItem.Click
        Dim dict As Hashtable = obtenerDatos()
        Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")

        Dim numeroReferencia As String
        Dim estadoActual As Integer = HipotecaEstadoTableAdapter.obtenerEstado(hipotecaEstadoId)
        Dim estadoId As Integer = estadoActual - 1

        Dim estadoActualizarProduccion As String

        If IsDBNull(dict("numreferen")) Then
            numeroReferencia = ""
            estadoActualizarProduccion = ""

        Else
            numeroReferencia = dict("numreferen")
            estadoActualizarProduccion = HipotecaEestadoTableAdapter.actualizarAestado(estadoId)
        End If

        Try

            Dim eestado As Integer = idCargar

            Dim estadoActualizar As String = HipotecaEestadoTableAdapter.actualizarAestado(eestado)

            If MsgBox("¿Actualizar el estado " + estadoActualizar + " ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
                HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)
                GrantiaHipotecariaTableAdapter.UpdateGaranHipo(estadoActualizarProduccion, numeroReferencia)
                cargarDatos()

            End If


        Catch ex As Exception

        End Try
    End Sub



  

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GridView1_RowCellClick_1(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Try


            'SI SE VA ACTUALIZAR EL ESTADO DE IP DEBERA PERDIR UN NUMERO DE IP EN EL FORMULARIO IP

            If Me.Text = "NUMERO IP" Then

                Dim dict As Hashtable = obtenerDatos()
                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim numeroReferencia As String
                Dim estadoActualizarProduccion As String
                Dim estadoId As Integer = idCargar + 1

                If IsDBNull(dict("numreferen")) Then
                    numeroReferencia = ""
                    estadoActualizarProduccion = ""

                Else
                    numeroReferencia = dict("numreferen")
                    estadoActualizarProduccion = HipotecaEestadoTableAdapter.actualizarAestado(estadoId)
                End If


                With IP
                    .Show()
                    .numreferen = numeroReferencia
                    .hipotecaEstadoId = hipotecaEstadoId
                    .estadoActualizadoProduccion = estadoActualizarProduccion
                    .estadoId = estadoId
                End With


            ElseIf Me.Text = "EVIAR A CUSTODIA" Then
                Dim dict As Hashtable = obtenerDatos()
                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim numeroReferencia As String

                Dim estadoActualizarProduccion As String
                Dim estadoId As Integer = idCargar + 1

                If IsDBNull(dict("numreferen")) Then
                    numeroReferencia = ""
                    estadoActualizarProduccion = ""

                Else
                    numeroReferencia = dict("numreferen")
                    estadoActualizarProduccion = HipotecaEestadoTableAdapter.actualizarAestado(estadoId)
                End If

                With custodia
                    .Show()
                    .hipotecaEstadoId = hipotecaEstadoId
                    .estadoId = estadoId
                    .numreferen = numeroReferencia
                    .estadoActualizadoProduccion = estadoActualizarProduccion
                End With

            ElseIf Me.Text = "SOLICITAR PAGO" Then
                Dim dict As Hashtable = obtenerDatos()

                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim numeroReferencia As String
                Dim estadoActualizarProduccion As String
                Dim estadoId As Integer = idCargar + 1

                If IsDBNull(dict("numreferen")) Then
                    numeroReferencia = ""
                    estadoActualizarProduccion = ""

                Else
                    numeroReferencia = dict("numreferen")
                    estadoActualizarProduccion = HipotecaEestadoTableAdapter.actualizarAestado(estadoId)
                End If



                With SolicitudPago
                    .Show()
                    .hipotecaEstadoId = hipotecaEstadoId
                    .estadioId = estadoId
                    .numreferen = numeroReferencia
                    .estadoActualizadoProduccion = estadoActualizarProduccion
                End With

            ElseIf Me.Text = "EFECTURAR PAGO" Then

                Dim dict As Hashtable = obtenerDatos()
                Dim numeroReferencia As String
                Dim estadoActualizarProduccion As String
                Dim estadoId As Integer = idCargar + 1

                If IsDBNull(dict("numreferen")) Then
                    numeroReferencia = ""
                    estadoActualizarProduccion = ""

                Else
                    numeroReferencia = dict("numreferen")
                    estadoActualizarProduccion = HipotecaEestadoTableAdapter.actualizarAestado(estadoId)
                End If



                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")


                HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)
                GrantiaHipotecariaTableAdapter.UpdateGaranHipo(estadoActualizarProduccion, numeroReferencia)


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
                Dim estadoId As Integer = idCargar + 1

                Dim hipotecaEstadoId As String = dict("hipotecaEstadoId")
                Dim numeroReferencia As String

                Dim estadoActualizarProduccion As String

                If IsDBNull(dict("numreferen")) Then
                    numeroReferencia = ""
                    estadoActualizarProduccion = ""

                Else
                    numeroReferencia = dict("numreferen")
                    estadoActualizarProduccion = HipotecaEestadoTableAdapter.actualizarAestado(estadoId)
                End If

                Dim eestado As Integer = idCargar + 2
                Dim eestadoProduccion As Integer = idCargar + 1



                Dim estadoActualizar As String = HipotecaEestadoTableAdapter.actualizarAestado(eestado)


                If MsgBox("¿Actualizar el estado a " + estadoActualizar + " ?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
                    HipotecaEstadoTableAdapter.UpdateQuery(estadoId, DateTime.Now(), UsuarioActivo.usuario, hipotecaEstadoId)

                    Dim prestamoId As Integer = PrestamoTableAdapter.ScalarPrestamoId(hipotecaEstadoId)

                    PrestamoTableAdapter.UpdatePrestamo(UsuarioActivo.UsuarioNombre, Date.Now(), prestamoId)

                    GrantiaHipotecariaTableAdapter.UpdateGaranHipo(estadoActualizarProduccion, numeroReferencia)


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

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBoxBuscar.Text.Trim = "" Then
                cargarDatos()

                TextBoxBuscar.Focus()
            End If


            Dim texto As String = TextBoxBuscar.Text
            Dim buscar As String = "%" + texto + "%"
            If UsuarioActivo.cargo = "INFORMATICA" Or UsuarioActivo.cargo = "ARCHIVO" Then
                Me.HipotecaEestadoTableAdapter.buscarConCargo(Me.DataSetCreditos.hipotecaEestado, idCargar, buscar)

            Else
                Me.HipotecaEestadoTableAdapter.BuscarConAgencia(Me.DataSetCreditos.hipotecaEestado, idCargar, buscar, UsuarioActivo.codigoAgencia)
            End If
            TextBoxBuscar.Text = ""
            TextBoxBuscar.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged

    End Sub

   
End Class