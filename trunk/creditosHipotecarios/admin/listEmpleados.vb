Public Class listEmpleados


    Private Sub listEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatos()
    End Sub

    Sub cargarDatos()
        Try
            PersonalListTableAdapter.Fill(DataSetCreditos.PersonalList)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AGREGARUSUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGREGARUSUARIOToolStripMenuItem.Click
        Dim Id As Integer = dameId()
        Dim usuario As String = dameUser()

        If usuario = Nothing Then

            With addUser
                .personalId = Id
                .Show()
            End With

        Else
            MsgBox("El empleado ya tiene asignado un usuario intente modificarlo", MsgBoxStyle.Information)
        End If


     

    End Sub

    Private Function dameId() As Integer
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "personalId")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function dameUser() As String
        Try
            Return GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "usuario")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim empleadoId As Integer = dameId()


        With pudatePersonal
            .personalId = empleadoId
            .Show()

        End With

    End Sub

    Private Sub MODIFICARUSUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARUSUARIOToolStripMenuItem.Click
        Dim personalId As Integer = dameId()

        With updateUser
            .personalId = personalId
            .Show()
        End With


    End Sub
End Class