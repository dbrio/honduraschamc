Public Class Inicio
   
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Usuario' Puede moverla o quitarla según sea necesario.
        'Me.UsuarioTableAdapter.Fill(Me.DataSetCreditos.Usuario)
        GestionarPanel()

        LabelDeparamento.Text = UsuarioActivo.cargo


        If UsuarioActivo.cargo = "OPERATIVO" Then
            btnFirmaCliente.Enabled = False
            btnPresentacion.Enabled = False
            btnFirmaGerencia.Enabled = False
            btnCustodio.Enabled = False
            btnSolicitudPago.Enabled = False

        End If
        If UsuarioActivo.cargo = "PROVEEDURIA" Then
            btnProtocolo.Enabled = False
            btnListo.Enabled = False
            ESTADOToolStripMenuItem.Visible = False
            btnCustodio.Enabled = False
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

  
    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        Try
            With enProtocolo

                .MdiParent = Me
                .idCargar = 1
                .Show()
                .Focus()
                .titulo = btnListo.Text
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
                .titulo = btnProtocolo.Text
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
                .titulo = btnFirmaCliente.Text
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
                .titulo = btnFirmaGerencia.Text
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
                .titulo = btnPresentacion.Text
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
                .titulo = btnCustodio.Text
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
                .titulo = btnSolicitudPago.Text
                .cargarDatos()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


 
  
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If UsuarioActivo.cargo = "PROVEEDURIA" Or UsuarioActivo.cargo = "INFORMATICA" Then
            With buscarHipoteca
                .MdiParent = Me
                .Show()
                .Focus()
            End With

        Else
            With creditoList
                .MdiParent = Me
                .Show()
                .Focus()
            End With
        End If

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


  
End Class