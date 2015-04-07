Imports DevExpress.XtraReports.UI

Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Usuario' Puede moverla o quitarla según sea necesario.
        'Me.UsuarioTableAdapter.Fill(Me.DataSetCreditos.Usuario)
        GestionarPanel()

        'LabelDeparamento.Text = UsuarioActivo.cargo


        If UsuarioActivo.cargo = "OPERATIVO" Then

            pageBuscar.Visible = True
            pageProtocoloListo.Visible = True
            pageFirmaCliente.Visible = True
            pageSolicitarDocumentos.Visible = True
            RibEstado.Visible = True


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



        End If

        If UsuarioActivo.cargo = "JEFE DE AGENCIA" Then
            pageEstado.Visible = True
            pageSolicitarPago.Visible = True
            pageSolicitarDocumentos.Visible = True
            RibEstado.Visible = True
        End If

        If UsuarioActivo.cargo = "INFORMATICA" Then
            RibAdmin.Visible = True
        End If




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

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Try
            With reportesGeneral

                .MdiParent = Me
                .idCargar = 11
                .Show()
                .Focus()
                .titulo = btnCustodia1.Caption
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class