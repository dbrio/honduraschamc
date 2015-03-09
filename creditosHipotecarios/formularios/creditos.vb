Public Class creditos
    Public clienteCodigo As String
    Public nombre As String
    Public propietario As String
    Public descripcion As String


    Private Sub creditos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        garantias.Enabled = True


    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("codigoCliente") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "numclien")
        diccionario("nombre") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nomdeudor")
        diccionario("propietario") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "owngarant")
        diccionario("descripcion") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "descripcio")


        Return diccionario

    End Function


  
    Private Sub creditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.ClienteTableAdapter.Fill(Me.DataSetAMCProduccion.Cliente, clienteCodigo)

            LabelNombre.Text = nombre
            With garantias
                .Enabled = False
                .GrantiaHipotecariaGridControl.Enabled = False

            End With

        Catch ex As Exception
            MsgBox("No existe ningun valor")
            With garantias
                .Enabled = False
                .GrantiaHipotecariaGridControl.Enabled = False

            End With
        End Try
       


    End Sub

   


    Private Sub ClienteGridControl_DoubleClick(sender As Object, e As EventArgs) Handles ClienteGridControl.DoubleClick
        Dim dict As Hashtable = obtenerDatos()
        Dim codigoCliente As String = dict("codigoCliente")
        Dim nombre As String = dict("nombre")
        Dim propietario As String = dict("propietario")
        Dim descripcion As String = dict("descripcion")
        With addProtocolo

            
            .Show()
            .Focus()

        End With
    End Sub
End Class