Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionarPanel()

        With creditoList
            .MdiParent = Me
            .Show()
            .Focus()
        End With

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

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        With creditoList
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub btnAddHipoteca_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddHipoteca.ItemClick
        With creditoList
            .MdiParent = Me
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

        With enProtocolo
            .MdiParent = Me
            .idCargar = 1
            .Show()
            .Focus()
            .cargarDatos()
        End With
    End Sub


    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        With enProtocolo

            .MdiParent = Me
            .idCargar = 2
            .Show()
            .Focus()
            .cargarDatos()

        End With

    End Sub

  
    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 1
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    

 
   
    Private Sub btnProtocolo_Click(sender As Object, e As EventArgs) Handles btnProtocolo.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 2
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFirmaCliente_Click(sender As Object, e As EventArgs) Handles btnFirmaCliente.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 3
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFirmaGerencia_Click(sender As Object, e As EventArgs) Handles btnFirmaGerencia.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 4
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPresentacion_Click(sender As Object, e As EventArgs) Handles btnPresentacion.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 5
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCustodio_Click(sender As Object, e As EventArgs) Handles btnCustodio.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 6
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSolicitudPago_Click(sender As Object, e As EventArgs) Handles btnSolicitudPago.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 7
                .Show()
                .Focus()
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


 
End Class