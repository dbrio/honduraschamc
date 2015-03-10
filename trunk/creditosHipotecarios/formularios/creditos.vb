Public Class creditos
    Public clienteCodigo As String
    Public nombre As String
    Public propietario As String
    Public descripcion As String
    Public valorRemate As Decimal



    Private Sub creditos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        garantias.Enabled = True


    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("codigoCliente") = clienteCodigo
        diccionario("nombre") = nombre
        diccionario("identidad") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colcnudoci")
        diccionario("propietario") = propietario
        diccionario("descripcion") = descripcion
        diccionario("codigoAgencia") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colccodofi")
        diccionario("monto") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colnmonsug")
        diccionario("plazo") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "plazo")
        diccionario("monto") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colnmonsug")
        diccionario("intres") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colntasint")
        diccionario("cuota") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colnmoncuo")
        diccionario("intresMora") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "colnMora_int")




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
        Dim identidad As String = dict("identidad")
        Dim codigoAgencia As String = dict("codigoAgencia")
        Dim descripcion As String = dict("descripcion")
        Dim monto As String = dict("monto")
        Dim plazo As String = dict("plazo")
        Dim interes As String = dict("interes")
        Dim cuota As String = dict("cuota")
        Dim intesMora As String = dict("interesMora")

       

        With addProtocolo


            .codigoCliente = codigoCliente
            .codigoAgencia = codigoAgencia
            .nombre = nombre
            .rnp = identidad
            .propietario = propietario
            .descripcion = descripcion
            .monto = monto
            .plazo = plazo
            .tasa = interes
            .cuota = cuota
            .interesMora = intesMora
            .valorRemate = valorRemate
            
            .Show()
            .Focus()

        End With
    End Sub
End Class