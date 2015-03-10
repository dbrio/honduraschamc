Public Class addProtocolo
    Public codigoCliente As String
    Public codigoAgencia As String
    Public nombre As String
    Public rnp As String
    Public propietario As String
    Public descripcion As String
    Public monto As Decimal
    Public plazo As Integer
    Public tasa As Decimal
    Public cuota As Decimal
    Public interesMora As Decimal
    Public valorRemate As Decimal



    Private Sub addProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = tasa
    End Sub
End Class