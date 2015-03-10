Public Class garantiaList
    Public codigoClinteGarantia As String
    Public nombreClienteGarantia As String
    Public identidadGarantia As String
    Public codigoAgenciaGarantia As String
    Public montoGarantia As Decimal
    Public plazoGaratnia As Integer
    Public tasaInteresGaratnia As Decimal
    Public cuota As Decimal
    Public interesMoraGaratnia As Decimal



    Private Sub GrantiaHipotecariaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GrantiaHipotecariaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAMCProduccion)

    End Sub

    Private Sub garantiaList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Inicio.Enabled = True
    End Sub
    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("propietario") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "owngarant")
        diccionario("descripcion") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "descripcio")
        diccionario("valorRemate") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "valpericia")

        Return diccionario

    End Function

  

    Private Sub garantiaList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio.Enabled = False
        Try
            Me.GrantiaHipotecariaTableAdapter.Fill(Me.DataSetAMCProduccion.GrantiaHipotecaria, codigoClinteGarantia)
            LabelNombre.Text = "NOMBRE: " + nombreClienteGarantia
            LabelCodigo.Text = "CODIGO: " + codigoClinteGarantia
        Catch ex As Exception
            MsgBox("Debe de seleccionar un valor")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GrantiaHipotecariaGridControl_DoubleClick(sender As Object, e As EventArgs) Handles GrantiaHipotecariaGridControl.DoubleClick
        With addProtocolo

            Dim dict As Hashtable = obtenerDatos()
            Dim propietario As String = dict("propietario")
            Dim descripcion As String = dict("descripcion")
            Dim valorRemate As String = dict("valpericia")
            Me.Close()
            .propietarioAdd = propietario
            .descripcionAdd = descripcion
            .valorRemateAdd = valorRemate
            .codigoClinteGarantiaAdd = codigoClinteGarantia
            .nombreClienteGarantiaAdd = nombreClienteGarantia
            .identidadGarantiaAdd = identidadGarantia
            .codigoAgenciaGarantiaAdd = codigoAgenciaGarantia
            .montoGarantiaAdd = montoGarantia
            .plazoGaratniaAdd = plazoGaratnia
            .tasaInteresGaratniaAdd = tasaInteresGaratnia
            .cuotaAdd = cuota
            .interesMoraGaratniaAdd = interesMoraGaratnia
            .MdiParent = Inicio
            .Show()
            .Focus()

        End With
    End Sub
End Class