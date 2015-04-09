Imports DevExpress.XtraReports.UI

Public Class Inicio
    Dim db As New DataSetLinQDataContext
    Dim tiempo As Integer
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Usuario' Puede moverla o quitarla según sea necesario.
        'Me.UsuarioTableAdapter.Fill(Me.DataSetCreditos.Usuario)
        GestionarPanel()

        cargarNumeros()
        Timer1.Start()

        'LabelDeparamento.Text = UsuarioActivo.cargo


        If UsuarioActivo.cargo = "OPERATIVO" Then

            pageBuscar.Visible = True
            pageProtocoloListo.Visible = True
            pageFirmaCliente.Visible = True
            pageSolicitarDocumentos.Visible = True
            RibEstado.Visible = True
            RibPerfil.Visible = True


        End If
        If UsuarioActivo.cargo = "PROVEEDURIA" Then
            pageEstado.Visible = True
            pageFirmaGerente.Visible = True
            pageIP.Visible = True
            pageEnviarCustodia.Visible = True
            pageEfectuarPago.Visible = True
            pageEntregaCliente.Visible = True
            pageCancelar.Visible = True
            RibEstado.Visible = True
            RibReportes.Visible = True
            RibPerfil.Visible = True



        End If

        If UsuarioActivo.cargo = "JEFE DE AGENCIA" Then
            pageEstado.Visible = True
            pageSolicitarPago.Visible = True
            pageSolicitarDocumentos.Visible = True
            RibEstado.Visible = True
            RibPerfil.Visible = True
        End If

        If UsuarioActivo.cargo = "INFORMATICA" Then
            RibAdmin.Visible = True
            RibPerfil.Visible = True
        End If




    End Sub

    'Gestionar Panel formularios cargan en el panel1
   
    Sub cargarNumeros()

        Try
            If UsuarioActivo.cargo = "PROVEEDURIA" Then
                For contar As Integer = 0 To 11
                    Dim i As Integer = contar + 1

                    Dim numeros = (From he In db.hipotecaEstado
                                   Join h In db.Hipoteca On he.hipotecaId Equals h.hipotecaId
                                   Join p In db.prestamo On h.prestamoId Equals p.prestamoId
                                   Where he.estadoId = i
                                   Select he.hipotecaId).Count
                    If i = 1 Then
                        pageProtocoloListo.Text = numeros
                    ElseIf i = 2 Then
                        pageFirmaCliente.Text = numeros
                    ElseIf i = 3 Then
                        pageFirmaGerente.Text = numeros
                    ElseIf i = 4 Then
                        pageIP.Text = numeros
                    ElseIf i = 5 Then
                        pageEnviarCustodia.Text = numeros
                    ElseIf i = 6 Then
                        pageSolicitarPago.Text = numeros
                    ElseIf i = 7 Then
                        pageEfectuarPago.Text = numeros
                    ElseIf i = 8 Then
                        pageSolicitarDocumentos.Text = numeros
                    ElseIf i = 9 Then
                        pageEntregaCliente.Text = numeros
                    ElseIf i = 10 Then
                        pageCancelar.Text = numeros
                    End If
                Next contar

            Else

                For contar As Integer = 0 To 11
                    Dim i As Integer = contar + 1

                    Dim numeros = (From he In db.hipotecaEstado
                                   Join h In db.Hipoteca On he.hipotecaId Equals h.hipotecaId
                                   Join p In db.prestamo On h.prestamoId Equals p.prestamoId
                                   Where he.estadoId = i And p.codigoAgencia = UsuarioActivo.codigoAgencia
                                   Select he.hipotecaId).Count
                    If i = 1 Then
                        pageProtocoloListo.Text = numeros
                    ElseIf i = 2 Then
                        pageFirmaCliente.Text = numeros
                    ElseIf i = 3 Then
                        pageFirmaGerente.Text = numeros
                    ElseIf i = 4 Then
                        pageIP.Text = numeros
                    ElseIf i = 5 Then
                        pageEnviarCustodia.Text = numeros
                    ElseIf i = 6 Then
                        pageSolicitarPago.Text = numeros
                    ElseIf i = 7 Then
                        pageEfectuarPago.Text = numeros
                    ElseIf i = 8 Then
                        pageSolicitarDocumentos.Text = numeros
                    ElseIf i = 9 Then
                        pageEntregaCliente.Text = numeros
                    ElseIf i = 10 Then
                        pageCancelar.Text = numeros
                    End If
                Next contar
            End If

        Catch ex As Exception
            MsgBox("No hay conexión con el servidor pongase en contacto con el administrador", MsgBoxStyle.Information)
        End Try

    End Sub



    'Gestionar Panel formularios cargan en el panel1
    Sub GestionarPanel()
        If XtraTabbedMdiManager1.Pages.Count = 0 Then
            PanelControl1.Visible = True

        Else
            PanelControl1.Visible = False
        End If


    End Sub

    Private Sub XtraTabbedMdiManager1_PageAdded(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageAdded
        GestionarPanel()

    End Sub

    Private Sub XtraTabbedMdiManager1_PageRemoved(ByVal sender As Object, ByVal e As DevExpress.XtraTabbedMdi.MdiTabPageEventArgs) Handles XtraTabbedMdiManager1.PageRemoved
        GestionarPanel()
    End Sub



    Private Sub ESTADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ESTADOToolStripMenuItem.Click
        With buscarHipoteca
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub


    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetCreditos)

    End Sub





    Private Sub btnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscar.ItemClick

        With creditoList
            .MdiParent = Me
            .Show()
            .Focus()
        End With


    End Sub

    Private Sub btnListo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnListo.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 1
                .Show()
                .Focus()
                .titulo = btnListo.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnProtocolo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProtocolo.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 2
                .Show()
                .Focus()
                .titulo = btnProtocolo.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirmaCliente.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 3
                .Show()
                .Focus()
                .titulo = btnFirmaCliente.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFirmaGerente_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirmaGerente.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 4
                .Show()
                .Focus()
                .titulo = btnFirmaGerente.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPresentacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPresentacion.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 5
                .Show()
                .Focus()
                .titulo = btnPresentacion.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCustodia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCustodia.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 6
                .Show()
                .Focus()
                .titulo = btnCustodia.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSolicitudPago_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSolicitudPago.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 7
                .Show()
                .Focus()
                .titulo = btnSolicitudPago.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEfectuarPago_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEfectuarPago.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 8
                .Show()
                .Focus()
                .titulo = btnEfectuarPago.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSolicitudDocumentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSolicitudDocumentos.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 9
                .Show()
                .Focus()
                .titulo = btnSolicitudDocumentos.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEntregaDocumentos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEntregaDocumentos.ItemClick
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 10
                .Show()
                .Focus()
                .titulo = btnEntregaDocumentos.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnEstado_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEstado.ItemClick
        With buscarHipoteca
            .MdiParent = Me
            .Show()
            .Focus()
            .cargarDaos()
        End With
    End Sub

    Private Sub btnCustodia1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCustodia1.ItemClick

        Try
            With reportesGeneral

                .MdiParent = Me
                .idCargar = 6
                .Show()
                .Focus()
                .titulo = btnCustodia1.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

        With addAbogado
            .Show()

        End With

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        With listAbogados
            .MdiParent = Me
            .Focus()
            .Show()

        End With

    End Sub

 
    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        With addPersonal
            .Show()
        End With
    End Sub

   
  
    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        With listEmpleados
            .MdiParent = Me
            .Show()

        End With
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelar1.ItemClick
        Try
            With reportesGeneral

                .MdiParent = Me
                .idCargar = 11
                .Show()
                .Focus()
                .titulo = btnCancelar1.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnContrsena_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnContrsena.ItemClick
        With updatePassword
            .Show()

        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If tiempo = 1800 Then
            '// aqui se resetea el tiempo
            tiempo = 0
            '//coloque aqui lo que quiera, si desea mostrar el form nuevamente, entonces:
            cargarNumeros()
            enProtocolo.cargarDatos()

        Else
            tiempo = tiempo + 1
        End If
    End Sub
End Class