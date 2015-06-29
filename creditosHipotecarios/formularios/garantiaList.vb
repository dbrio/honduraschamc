Public Class garantiaList
    Public codigoClinteGarantia As String
    Public nombreClienteGarantia As String
    Public identidadGarantia As String
    Public codigoAgenciaGarantia As String
    Public montoGarantia As Decimal
    Public plazoGaratnia As Decimal
    Public tasaInteresGaratnia As Decimal
    Public cuotaGaratnia As Decimal
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

  
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        

        Try
            With addProtocolo

                Dim dict As Hashtable = obtenerDatos()
                If IsDBNull(dict("propietario")) Then
                    dict("propietario") = ""
                End If

                Dim propietario As String = dict("propietario")
                Dim descripcion As String = dict("descripcion")
                Dim valorRemate As Decimal = dict("valorRemate")



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
                .cuotaAdd = cuotaGaratnia
                .interesMoraGaratniaAdd = interesMoraGaratnia
                .MdiParent = Inicio
                .Show()
                .cargarDatos()
                .Focus()


            End With
        Catch ex As Exception
            MsgBox("El ítem seleccionado contiene datos vacios, seleccione otro ítem", MsgBoxStyle.Critical)
        End Try
    End Sub

    
End Class