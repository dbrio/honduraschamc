Public Class addProtocolo
    Dim _Message As New System.Net.Mail.MailMessage()
    Dim _SMTP As New System.Net.Mail.SmtpClient

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
    Public Usser As Integer


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            'OBTENER EL ID DEL ABOGADO
            Dim abogadoId As Integer = NombresAbogado.SelectedValue
            'OBTENER EL CORREO DEL ABOGAD
            Dim correoAbogado As String = Me.AbogadoTableAdapter.obtenerCorreo(abogadoId)
            Dim ultimoPrestamo As Integer = Me.PrestamoTableAdapter.UltimoRegistro() + 1


            'CONFIGURACION DEL STMP
            _SMTP.Credentials = New System.Net.NetworkCredential("opamcmovil@gmail.com", "Amcmovil")
            _SMTP.Host = "smtp.gmail.com"
            _SMTP.Port = 587
            _SMTP.EnableSsl = False
            _SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            _Message.[To].Add(correoAbogado) 'Cuenta de Correo al que se le quiere enviar el e-mail
            _Message.From = New System.Net.Mail.MailAddress("dbrio2011@gmail.com", "AMC | HONDURAS", System.Text.Encoding.UTF8) 'Quien lo envía
            _Message.Subject = "PROTOCOLO" 'Sujeto del e-mail
            _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
            _Message.Body = "'<!DOCTYPE html>'" +
                    "<head>" +
                        "<title>AMC HONDURAS</title>" +
                        "<meta name='viewport' content='width=device-width, initial-scale=1'>" +
                        "<meta name='viewport' content=width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no'>" +
                        "<meta charset='UTF-8'>" +
                                "<style type='text/css'>" +
                                 "body{" +
                                            "font-family: helvetica;" +
                                           " font-weight: 200;" +
                                                "}" +
                                        ".col-xs-1{" +
                                            "padding: 20px;" +
                                            "font-size: 1.1em;" +
                                        "}" +
                                       " .col-xs-4{" +
                                            "padding-right: 20px;" +
                                        "}" +
                                       " body{" +
                                            "background: #fff;" +
                                       "}" +
                                        ".img-responsive{" +
                                           " max-width: 400px;" +
                                        "}" +
                                        ".table{" +
                                           " width: 100%;" +
                                           " background: #FAFAFA;" +
                                        "}" +
                                        "header{" +
                                            "background: red;" +
                                            "border-radius: 10px;" +
                                            "}" +
                                    "</style>" +
                    "</head>" +
                    "<body>" +
                    "<div class='container-fluid'>" +
                        "<header>" +
                            "<div class='col-xs-12'>" +
                           " </div>" +
                            "<div class='col-xs-12'>" +
                               " <br><h4>AUTORIZACION PARA PROTOCOLO</h4>" +
                               "<h2>PROTOCOLO NUMERO: " & ultimoPrestamo & "</h2>" +
                                "<br> <h4>FECHA Y HORA: " & DateTime.Now().ToString("dd/MM/yyyy hh:mm:ss tt") & "</h4><br>" +
                         "</header>" +
                               " <br> ABOGADO ASIGNADO: " & NombresAbogado.Text & "<br>" +
                               " <table class='table'>" +
                                    "<tr>" +
                                       " <td class='col-xs-1'><h5>Propietario : </h5</td>" +
                                        "<td class='col-xs-4'>" & propietarioAdd & "</td>" +
                                          "<td class='col-xs-1'><h5>Identidad: </h5> </td>" +
                                       " <td class='col-xs-4'>" & txtIdPropietario.Text & "</td>" +
                                    "</tr>" +
                                    "<tr>" +
                                        "<td class='col-xs-1'><h5>Prestatario: </h5></td>" +
                                       " <td class='col-xs-4'> " & nombreClienteGarantiaAdd & "</td>" +
                                        "<td class='col-xs-1'><h5>Identidad: </h5> </td>" +
                                        "<td class='col-xs-4'>" & identidadGarantiaAdd & "</td>" +
                                    "</tr>" +
                               "</table>" +
                               " <h3>DATOS PARA PROTOCOLO</h3>" +
                               " <div class='jumbotron'>" +
                                   " <table class='table'>" +
                                       " <tr>" +
                                           " <td class='col-xs-4'><h5>Monto prestamo: </h5></td>" +
                                           " <td class='col-xs-4'>" & montoGarantiaAdd & "</td>" +
                                           " <td class='col-xs-4'><h5>Cuota a pagar: </h5> </td>" +
                                           " <td class='col-xs-4'>" & cuotaAdd & "</td>" +
                                        "</tr>" +
                                       " <tr>" +
                                            "<td class='col-xs-2'><h5>Plazo cuotas: </h5></td>" +
                                           " <td class='col-xs-4'>" & plazoGaratniaAdd & "</td>" +
                                           " <td class='col-xs-2'><h5>Interes Moratorio: </h5</td>" +
                                            "<td class='col-xs-4'>" & interesMoraGaratniaAdd & "</td>" +
                                        "</tr>" +
                                       " <tr>" +
                                           " <td class='col-xs-4'><h5>Tasa Interes: </h5> </td>" +
                                           " <td class='col-xs-4'>" & tasaInteresGaratniaAdd & "</td>" +
                                            "<td class='col-xs-4'><h5>Valor de remate: </h5></td>" +
                                            "<td class='col-xs-4'>" & valorRemateAdd & "</td>" +
                                       " </tr>" +
                               " </table> " +
                               " </div>" +
                            "</div>" +
                           " <div class='row'>" +
                               " <div class='col-xs-12'>" +
                                "</div>" +
                           " </div>" +
                           " </div>" +
                       " <footer>" +
                        "<img class='img-responsive' src='http://dbriones.com/amclogo.png'>" +
                        "</footer>" +
                   " </div>" +
                   " <script src='http://code.jquery.com/jquery-2.1.3.min.js'></script'>" +
                   "<script src='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js'></script></body></html>"

            _Message.BodyEncoding = System.Text.Encoding.UTF8
            _Message.Priority = System.Net.Mail.MailPriority.Normal
            _Message.IsBodyHtml = True

            'ENVIO
            _SMTP.Send(_Message)

            'INSERTAR GARANTIA AL SISTEMA
            Me.PrestamoTableAdapter.Insert(codigoClinteGarantiaAdd, codigoAgenciaGarantiaAdd, nombreClienteGarantiaAdd, identidadGarantiaAdd, propietarioAdd, txtIdPropietario.Text, montoGarantiaAdd, plazoGaratniaAdd, tasaInteresGaratniaAdd, cuotaAdd, interesMoraGaratniaAdd, valorRemateAdd, descripcionAdd)

            Me.HipotecaTableAdapter.sp_Hipoteca(NombresAbogado.SelectedValue)

            Me.EventoTableAdapter.sp_Evento(UsuarioActivo.usuario)
            MessageBox.Show("Protocolo agregado exitosamente", "Protocolo agregado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            With enProtocolo
                .MdiParent = Inicio
                .idCargar = 1
                .Show()
                .Focus()
                .cargarDatos()
            End With
            Me.Close()

        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try






        'If LabelPropietario.Text.Trim = "" Or nombreClienteGarantiaAdd = propietarioAdd Then

        'Else
        '    MessageBox.Show("Identidad del Propietario es obligatoria", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtIdPropietario.Focus()
        '    Exit Sub

        'End If


    End Sub

    Private Sub addProtocolo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Evento' Puede moverla o quitarla según sea necesario.
        Me.EventoTableAdapter.Fill(Me.DataSetCreditos.Evento)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.Hipoteca' Puede moverla o quitarla según sea necesario.
        Me.HipotecaTableAdapter.Fill(Me.DataSetCreditos.Hipoteca)
        'TODO: esta línea de código carga datos en la tabla 'DataSetCreditos.prestamo' Puede moverla o quitarla según sea necesario.
        Me.PrestamoTableAdapter.Fill(Me.DataSetCreditos.prestamo)


        Me.AbogadoTableAdapter.Fill(Me.DataSetCreditos.Abogado)

        LabelNombre.Text = "NOMBRE:   " + Convert.ToString(nombreClienteGarantiaAdd)
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