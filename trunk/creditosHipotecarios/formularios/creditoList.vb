Public Class creditoList

    Private Sub creditoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtBuscar.Text.Trim = "" Then
                MessageBox.Show("Escriba un nombre nombre para buscar", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                txtBuscar.Focus()
            Else
                Dim texto As String = txtBuscar.Text
                Dim buscar As String = "%" + texto + "%"
                If UsuarioActivo.cargo = "INFORMATICA" Then
                    ClienteTableAdapter.BuscarInformatica(Me.DataSetAMCProduccion.Cliente, buscar)

                Else
                    ClienteTableAdapter.Buscar(Me.DataSetAMCProduccion.Cliente, buscar, UsuarioActivo.codigoAgencia)
                End If
                txtBuscar.Text = ""
                txtBuscar.Focus()
                ClienteGridControl.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function obtenerDatos() As Hashtable
        Dim diccionario As New Hashtable

        diccionario("codigoCliente") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ccodcli")
        diccionario("nombre") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cnomcli")

        diccionario("identidad") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "cnudoci")
        diccionario("codigoAgencia") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ccodofi")
        diccionario("monto") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nmonsug")
        diccionario("plazo") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ncuosug")
        diccionario("interes") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ntasint")
        diccionario("cuota") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nmoncuo")
        diccionario("interesMora") = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nMora_int")



        Return diccionario

    End Function

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnBuscar_Click(sender, e)
        End If
    End Sub

   
    Private Sub GridView1_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        Dim dict As Hashtable = obtenerDatos()
        Dim codigoCliente As String = dict("codigoCliente")
        Dim nombre As String = dict("nombre")
        Dim identidad As String = dict("identidad")
        Dim codigoAgencia As String = dict("codigoAgencia")
        Dim monto As Decimal = dict("monto")
        Dim plazo As Decimal = dict("plazo")
        Dim interes As Decimal = dict("interes")
        Dim cuota As Decimal = dict("cuota")
        Dim interesMora As Decimal = IsDBNull(dict("interesMora"))

        If interesMora = -1 Or interesMora = Nothing Then
            interesMora = 0.0
        Else
            interesMora = interesMora
        End If

        With garantiaList
            .codigoClinteGarantia = codigoCliente
            .nombreClienteGarantia = nombre
            .identidadGarantia = identidad
            .montoGarantia = monto
            .plazoGaratnia = plazo
            .tasaInteresGaratnia = interes
            .cuotaGaratnia = cuota
            .interesMoraGaratnia = interesMora
            .codigoAgenciaGarantia = codigoAgencia

            .Show()
            .Focus()

        End With



    End Sub

  
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub
End Class