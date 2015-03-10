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
End Class