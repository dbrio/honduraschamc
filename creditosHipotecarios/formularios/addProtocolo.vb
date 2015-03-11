Public Class addProtocolo
    Public codigoClinteGarantiaAdd As String
    Public nombreClienteGarantiaAdd As String
    Public identidadGarantiaAdd As String
    Public codigoAgenciaGarantiaAdd As String
    Public montoGarantiaAdd As Decimal
    Public plazoGaratniaAdd As Decimal
    Public tasaInteresGaratniaAdd As Decimal
    Public cuotaAdd As Decimal
    Public interesMoraGaratniaAdd As Decimal
    Public propietarioAdd As String
    Public descripcionAdd As String
    Public valorRemateAdd As Decimal


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            Me.PrestamoTableAdapter.Insert(codigoClinteGarantiaAdd, codigoAgenciaGarantiaAdd, nombreClienteGarantiaAdd, identidadGarantiaAdd, propietarioAdd, txtIdPropietario.Text, montoGarantiaAdd, plazoGaratniaAdd, tasaInteresGaratniaAdd, cuotaAdd, interesMoraGaratniaAdd, valorRemateAdd, descripcionAdd)



            MessageBox.Show("Protocolo agregado exitosamente", "Protocolo agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

      

        'If LabelPropietario.Text.Trim = "" Or nombreClienteGarantiaAdd = propietarioAdd Then

        'Else
        '    MessageBox.Show("Identidad del Propietario es obligatoria", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtIdPropietario.Focus()
        '    Exit Sub

        'End If


    End Sub

    Private Sub addProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.prestamo' Puede moverla o quitarla según sea necesario.
        Me.PrestamoTableAdapter.Fill(Me.DataSetCreditos.prestamo)


        Me.AbogadoTableAdapter.Fill(Me.DataSetCreditos.Abogado)

        LabelNombre.Text = "NOMBRE:   " + Convert.ToString(propietarioAdd)
        LabelIdentidadCliente.Text = "IDENTIDAD:    " + Convert.ToString(identidadGarantiaAdd)
        LabelPropietario.Text = "PROPIETARIO:    " + Convert.ToString(propietarioAdd)
        LabelMonto.Text = "MONTO:   " + Convert.ToString(montoGarantiaAdd)
        LabelPlazos.Text = "PLAZO CUOTAS:   " + Convert.ToString(plazoGaratniaAdd)
        LabelInteres.Text = "TASA DE INTERES:   " + Convert.ToString(tasaInteresGaratniaAdd)
        LabelCuota.Text = "CUOTA A PAGAR:   " + Convert.ToString(cuotaAdd)
        LabelInteresMora.Text = "INTERES POR MORA:   " + Convert.ToString(interesMoraGaratniaAdd)
        LabelValorRemate.Text = "VALOR REMATE:   " + Convert.ToString(valorRemateAdd)

        

    End Sub

    
End Class