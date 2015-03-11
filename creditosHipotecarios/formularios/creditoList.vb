﻿Public Class creditoList

    Private Sub creditoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClienteGridControl.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Trim = "" Then
            MessageBox.Show("Escriba un nombre nombre para buscar", "No hay resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            txtBuscar.Focus()
        Else
            Dim texto As String = txtBuscar.Text
            Dim buscar As String = "%" + texto + "%"
            ClienteTableAdapter.Buscar(Me.DataSetAMCProduccion.Cliente, buscar)
            txtBuscar.Text = ""
            txtBuscar.Focus()
            ClienteGridControl.Enabled = True
        End If
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

    Private Sub ClienteGridControl_DoubleClick(sender As Object, e As EventArgs) Handles ClienteGridControl.DoubleClick

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
End Class