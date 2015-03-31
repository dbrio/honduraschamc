<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seguimiento
    'Inherits System.Windows.Forms.Form
    Inherits JaarForm.JForm
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Form reemplaza a Dispose para limpiar la lista de componentes.
    '<System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    Try
    '        If disposing AndAlso components IsNot Nothing Then
    '            components.Dispose()
    '        End If
    '    Finally
    '        MyBase.Dispose(disposing)
    '    End Try
    'End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreAgenciaLabel As System.Windows.Forms.Label
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Dim NombrePropietarioLabel As System.Windows.Forms.Label
        Dim RnpPropietarioLabel As System.Windows.Forms.Label
        Dim MontoLabel As System.Windows.Forms.Label
        Dim PlazoLabel As System.Windows.Forms.Label
        Dim TasaInteresLabel As System.Windows.Forms.Label
        Dim CuotaPagarLabel As System.Windows.Forms.Label
        Dim InteresMoraLabel As System.Windows.Forms.Label
        Dim ValorRemateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NumeroIpLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim AsientoLabel As System.Windows.Forms.Label
        Dim MatriculaLabel As System.Windows.Forms.Label
        Dim TomoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Me.DataSetCreditos = New creditosHipotecarios.DataSetCreditos()
        Me.SeguimientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SeguimientoTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.seguimientoTableAdapter()
        Me.TableAdapterManager = New creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager()
        Me.EstadoIdLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NombreAgenciaLabel1 = New System.Windows.Forms.Label()
        Me.NombreClienteLabel1 = New System.Windows.Forms.Label()
        Me.RnpClienteLabel1 = New System.Windows.Forms.Label()
        Me.NombrePropietarioLabel1 = New System.Windows.Forms.Label()
        Me.RnpPropietarioLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DescripcionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.MontoLabel1 = New System.Windows.Forms.Label()
        Me.PlazoLabel1 = New System.Windows.Forms.Label()
        Me.TasaInteresLabel1 = New System.Windows.Forms.Label()
        Me.CuotaPagarLabel1 = New System.Windows.Forms.Label()
        Me.InteresMoraLabel1 = New System.Windows.Forms.Label()
        Me.ValorRemateLabel1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NombresLabel1 = New System.Windows.Forms.Label()
        Me.ApellidosLabel1 = New System.Windows.Forms.Label()
        Me.AsientoLabel1 = New System.Windows.Forms.Label()
        Me.MatriculaLabel1 = New System.Windows.Forms.Label()
        Me.NumeroIpLabel1 = New System.Windows.Forms.Label()
        Me.TomoLabel1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.FechaLabel1 = New System.Windows.Forms.Label()
        Me.UsuarioLabel1 = New System.Windows.Forms.Label()
        NombreAgenciaLabel = New System.Windows.Forms.Label()
        NombreClienteLabel = New System.Windows.Forms.Label()
        NombrePropietarioLabel = New System.Windows.Forms.Label()
        RnpPropietarioLabel = New System.Windows.Forms.Label()
        MontoLabel = New System.Windows.Forms.Label()
        PlazoLabel = New System.Windows.Forms.Label()
        TasaInteresLabel = New System.Windows.Forms.Label()
        CuotaPagarLabel = New System.Windows.Forms.Label()
        InteresMoraLabel = New System.Windows.Forms.Label()
        ValorRemateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NumeroIpLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        AsientoLabel = New System.Windows.Forms.Label()
        MatriculaLabel = New System.Windows.Forms.Label()
        TomoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeguimientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DescripcionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreAgenciaLabel
        '
        NombreAgenciaLabel.AutoSize = True
        NombreAgenciaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreAgenciaLabel.Location = New System.Drawing.Point(23, 32)
        NombreAgenciaLabel.Name = "NombreAgenciaLabel"
        NombreAgenciaLabel.Size = New System.Drawing.Size(61, 16)
        NombreAgenciaLabel.TabIndex = 52
        NombreAgenciaLabel.Text = "Agencia:"
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreClienteLabel.Location = New System.Drawing.Point(23, 106)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(104, 16)
        NombreClienteLabel.TabIndex = 54
        NombreClienteLabel.Text = "Nombre Cliente:"
        '
        'NombrePropietarioLabel
        '
        NombrePropietarioLabel.AutoSize = True
        NombrePropietarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombrePropietarioLabel.Location = New System.Drawing.Point(23, 168)
        NombrePropietarioLabel.Name = "NombrePropietarioLabel"
        NombrePropietarioLabel.Size = New System.Drawing.Size(129, 16)
        NombrePropietarioLabel.TabIndex = 58
        NombrePropietarioLabel.Text = "Nombre Propietario:"
        '
        'RnpPropietarioLabel
        '
        RnpPropietarioLabel.AutoSize = True
        RnpPropietarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RnpPropietarioLabel.Location = New System.Drawing.Point(475, 168)
        RnpPropietarioLabel.Name = "RnpPropietarioLabel"
        RnpPropietarioLabel.Size = New System.Drawing.Size(24, 16)
        RnpPropietarioLabel.TabIndex = 60
        RnpPropietarioLabel.Text = "ID:"
        '
        'MontoLabel
        '
        MontoLabel.AutoSize = True
        MontoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoLabel.Location = New System.Drawing.Point(32, 37)
        MontoLabel.Name = "MontoLabel"
        MontoLabel.Size = New System.Drawing.Size(48, 16)
        MontoLabel.TabIndex = 80
        MontoLabel.Text = "Monto:"
        '
        'PlazoLabel
        '
        PlazoLabel.AutoSize = True
        PlazoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlazoLabel.Location = New System.Drawing.Point(310, 29)
        PlazoLabel.Name = "PlazoLabel"
        PlazoLabel.Size = New System.Drawing.Size(45, 16)
        PlazoLabel.TabIndex = 82
        PlazoLabel.Text = "Plazo:"
        '
        'TasaInteresLabel
        '
        TasaInteresLabel.AutoSize = True
        TasaInteresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TasaInteresLabel.Location = New System.Drawing.Point(31, 89)
        TasaInteresLabel.Name = "TasaInteresLabel"
        TasaInteresLabel.Size = New System.Drawing.Size(86, 16)
        TasaInteresLabel.TabIndex = 84
        TasaInteresLabel.Text = "Tasa Interes:"
        '
        'CuotaPagarLabel
        '
        CuotaPagarLabel.AutoSize = True
        CuotaPagarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuotaPagarLabel.Location = New System.Drawing.Point(310, 86)
        CuotaPagarLabel.Name = "CuotaPagarLabel"
        CuotaPagarLabel.Size = New System.Drawing.Size(86, 16)
        CuotaPagarLabel.TabIndex = 86
        CuotaPagarLabel.Text = "Cuota Pagar:"
        '
        'InteresMoraLabel
        '
        InteresMoraLabel.AutoSize = True
        InteresMoraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InteresMoraLabel.Location = New System.Drawing.Point(32, 139)
        InteresMoraLabel.Name = "InteresMoraLabel"
        InteresMoraLabel.Size = New System.Drawing.Size(85, 16)
        InteresMoraLabel.TabIndex = 88
        InteresMoraLabel.Text = "Interes Mora:"
        '
        'ValorRemateLabel
        '
        ValorRemateLabel.AutoSize = True
        ValorRemateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorRemateLabel.Location = New System.Drawing.Point(310, 139)
        ValorRemateLabel.Name = "ValorRemateLabel"
        ValorRemateLabel.Size = New System.Drawing.Size(94, 16)
        ValorRemateLabel.TabIndex = 90
        ValorRemateLabel.Text = "Valor Remate:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(475, 110)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(24, 16)
        Label1.TabIndex = 62
        Label1.Text = "ID:"
        '
        'NumeroIpLabel
        '
        NumeroIpLabel.AutoSize = True
        NumeroIpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumeroIpLabel.Location = New System.Drawing.Point(25, 165)
        NumeroIpLabel.Name = "NumeroIpLabel"
        NumeroIpLabel.Size = New System.Drawing.Size(88, 20)
        NumeroIpLabel.TabIndex = 85
        NumeroIpLabel.Text = "Número IP:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombresLabel.Location = New System.Drawing.Point(25, 10)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(68, 16)
        NombresLabel.TabIndex = 78
        NombresLabel.Text = "Abogado:"
        '
        'AsientoLabel
        '
        AsientoLabel.AutoSize = True
        AsientoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AsientoLabel.Location = New System.Drawing.Point(25, 66)
        AsientoLabel.Name = "AsientoLabel"
        AsientoLabel.Size = New System.Drawing.Size(67, 20)
        AsientoLabel.TabIndex = 81
        AsientoLabel.Text = "Asiento:"
        '
        'MatriculaLabel
        '
        MatriculaLabel.AutoSize = True
        MatriculaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatriculaLabel.Location = New System.Drawing.Point(25, 114)
        MatriculaLabel.Name = "MatriculaLabel"
        MatriculaLabel.Size = New System.Drawing.Size(77, 20)
        MatriculaLabel.TabIndex = 83
        MatriculaLabel.Text = "Matricula:"
        '
        'TomoLabel
        '
        TomoLabel.AutoSize = True
        TomoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TomoLabel.Location = New System.Drawing.Point(25, 207)
        TomoLabel.Name = "TomoLabel"
        TomoLabel.Size = New System.Drawing.Size(53, 20)
        TomoLabel.TabIndex = 87
        TomoLabel.Text = "Tomo:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(43, 119)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 13)
        Label2.TabIndex = 63
        Label2.Text = "INICIO"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(116, 119)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 13)
        Label3.TabIndex = 85
        Label3.Text = "PROTOCOLO"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(226, 120)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(52, 26)
        Label4.TabIndex = 86
        Label4.Text = "FIRMA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIENTE"
        Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(317, 120)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(59, 26)
        Label5.TabIndex = 87
        Label5.Text = "FIRMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GERENTE"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.Color.White
        Label6.Location = New System.Drawing.Point(408, 120)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(51, 13)
        Label6.TabIndex = 88
        Label6.Text = "IP LISTO"
        Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(497, 120)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(62, 13)
        Label7.TabIndex = 89
        Label7.Text = "CUSTODIA"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.Color.White
        Label8.Location = New System.Drawing.Point(594, 120)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(67, 26)
        Label8.TabIndex = 90
        Label8.Text = "SOLICITUD " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DE PAGO"
        Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsuarioLabel.ForeColor = System.Drawing.Color.OrangeRed
        UsuarioLabel.Location = New System.Drawing.Point(316, 47)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(24, 18)
        UsuarioLabel.TabIndex = 95
        UsuarioLabel.Text = "el:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.ForeColor = System.Drawing.Color.OrangeRed
        FechaLabel.Location = New System.Drawing.Point(16, 46)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(178, 18)
        FechaLabel.TabIndex = 94
        FechaLabel.Text = "Ultima Actualización por:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.Color.White
        Label9.Location = New System.Drawing.Point(699, 120)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 13)
        Label9.TabIndex = 98
        Label9.Text = "PAGADA"
        '
        'DataSetCreditos
        '
        Me.DataSetCreditos.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeguimientoBindingSource
        '
        Me.SeguimientoBindingSource.DataMember = "seguimiento"
        Me.SeguimientoBindingSource.DataSource = Me.DataSetCreditos
        '
        'SeguimientoTableAdapter
        '
        Me.SeguimientoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbogadoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EventoTableAdapter = Nothing
        Me.TableAdapterManager.hipotecaEstadoTableAdapter = Nothing
        Me.TableAdapterManager.HipotecaTableAdapter = Nothing
        Me.TableAdapterManager.MemoTableAdapter = Nothing
        Me.TableAdapterManager.prestamoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'EstadoIdLabel1
        '
        Me.EstadoIdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "estadoId", True))
        Me.EstadoIdLabel1.ForeColor = System.Drawing.Color.White
        Me.EstadoIdLabel1.Location = New System.Drawing.Point(979, 686)
        Me.EstadoIdLabel1.Name = "EstadoIdLabel1"
        Me.EstadoIdLabel1.Size = New System.Drawing.Size(100, 25)
        Me.EstadoIdLabel1.TabIndex = 3
        Me.EstadoIdLabel1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(NombreAgenciaLabel)
        Me.GroupBox1.Controls.Add(Me.NombreAgenciaLabel1)
        Me.GroupBox1.Controls.Add(NombreClienteLabel)
        Me.GroupBox1.Controls.Add(Me.NombreClienteLabel1)
        Me.GroupBox1.Controls.Add(Me.RnpClienteLabel1)
        Me.GroupBox1.Controls.Add(NombrePropietarioLabel)
        Me.GroupBox1.Controls.Add(Me.NombrePropietarioLabel1)
        Me.GroupBox1.Controls.Add(RnpPropietarioLabel)
        Me.GroupBox1.Controls.Add(Me.RnpPropietarioLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 255)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'NombreAgenciaLabel1
        '
        Me.NombreAgenciaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "nombreAgencia", True))
        Me.NombreAgenciaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreAgenciaLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.NombreAgenciaLabel1.Location = New System.Drawing.Point(102, 32)
        Me.NombreAgenciaLabel1.Name = "NombreAgenciaLabel1"
        Me.NombreAgenciaLabel1.Size = New System.Drawing.Size(263, 25)
        Me.NombreAgenciaLabel1.TabIndex = 53
        Me.NombreAgenciaLabel1.Text = "Label1"
        '
        'NombreClienteLabel1
        '
        Me.NombreClienteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "nombreCliente", True))
        Me.NombreClienteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreClienteLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.NombreClienteLabel1.Location = New System.Drawing.Point(163, 106)
        Me.NombreClienteLabel1.Name = "NombreClienteLabel1"
        Me.NombreClienteLabel1.Size = New System.Drawing.Size(306, 20)
        Me.NombreClienteLabel1.TabIndex = 55
        Me.NombreClienteLabel1.Text = "Label1"
        '
        'RnpClienteLabel1
        '
        Me.RnpClienteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "rnpCliente", True))
        Me.RnpClienteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RnpClienteLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.RnpClienteLabel1.Location = New System.Drawing.Point(503, 110)
        Me.RnpClienteLabel1.Name = "RnpClienteLabel1"
        Me.RnpClienteLabel1.Size = New System.Drawing.Size(143, 19)
        Me.RnpClienteLabel1.TabIndex = 57
        Me.RnpClienteLabel1.Text = "Label1"
        '
        'NombrePropietarioLabel1
        '
        Me.NombrePropietarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "nombrePropietario", True))
        Me.NombrePropietarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombrePropietarioLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.NombrePropietarioLabel1.Location = New System.Drawing.Point(163, 168)
        Me.NombrePropietarioLabel1.Name = "NombrePropietarioLabel1"
        Me.NombrePropietarioLabel1.Size = New System.Drawing.Size(306, 20)
        Me.NombrePropietarioLabel1.TabIndex = 59
        Me.NombrePropietarioLabel1.Text = "Label1"
        '
        'RnpPropietarioLabel1
        '
        Me.RnpPropietarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "rnpPropietario", True))
        Me.RnpPropietarioLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RnpPropietarioLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.RnpPropietarioLabel1.Location = New System.Drawing.Point(503, 166)
        Me.RnpPropietarioLabel1.Name = "RnpPropietarioLabel1"
        Me.RnpPropietarioLabel1.Size = New System.Drawing.Size(143, 19)
        Me.RnpPropietarioLabel1.TabIndex = 61
        Me.RnpPropietarioLabel1.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DescripcionMemoEdit)
        Me.GroupBox3.Controls.Add(MontoLabel)
        Me.GroupBox3.Controls.Add(Me.MontoLabel1)
        Me.GroupBox3.Controls.Add(PlazoLabel)
        Me.GroupBox3.Controls.Add(Me.PlazoLabel1)
        Me.GroupBox3.Controls.Add(TasaInteresLabel)
        Me.GroupBox3.Controls.Add(Me.TasaInteresLabel1)
        Me.GroupBox3.Controls.Add(CuotaPagarLabel)
        Me.GroupBox3.Controls.Add(Me.CuotaPagarLabel1)
        Me.GroupBox3.Controls.Add(InteresMoraLabel)
        Me.GroupBox3.Controls.Add(Me.InteresMoraLabel1)
        Me.GroupBox3.Controls.Add(ValorRemateLabel)
        Me.GroupBox3.Controls.Add(Me.ValorRemateLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 411)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1025, 317)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        '
        'DescripcionMemoEdit
        '
        Me.DescripcionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SeguimientoBindingSource, "descripcion", True))
        Me.DescripcionMemoEdit.Enabled = False
        Me.DescripcionMemoEdit.Location = New System.Drawing.Point(35, 173)
        Me.DescripcionMemoEdit.Name = "DescripcionMemoEdit"
        Me.DescripcionMemoEdit.Size = New System.Drawing.Size(976, 127)
        Me.DescripcionMemoEdit.TabIndex = 92
        '
        'MontoLabel1
        '
        Me.MontoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "monto", True))
        Me.MontoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.MontoLabel1.Location = New System.Drawing.Point(171, 29)
        Me.MontoLabel1.Name = "MontoLabel1"
        Me.MontoLabel1.Size = New System.Drawing.Size(100, 25)
        Me.MontoLabel1.TabIndex = 81
        Me.MontoLabel1.Text = "Label1"
        '
        'PlazoLabel1
        '
        Me.PlazoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "plazo", True))
        Me.PlazoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlazoLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.PlazoLabel1.Location = New System.Drawing.Point(474, 29)
        Me.PlazoLabel1.Name = "PlazoLabel1"
        Me.PlazoLabel1.Size = New System.Drawing.Size(100, 25)
        Me.PlazoLabel1.TabIndex = 83
        Me.PlazoLabel1.Text = "Label1"
        '
        'TasaInteresLabel1
        '
        Me.TasaInteresLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "tasaInteres", True))
        Me.TasaInteresLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TasaInteresLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.TasaInteresLabel1.Location = New System.Drawing.Point(171, 89)
        Me.TasaInteresLabel1.Name = "TasaInteresLabel1"
        Me.TasaInteresLabel1.Size = New System.Drawing.Size(100, 25)
        Me.TasaInteresLabel1.TabIndex = 85
        Me.TasaInteresLabel1.Text = "Label1"
        '
        'CuotaPagarLabel1
        '
        Me.CuotaPagarLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "cuotaPagar", True))
        Me.CuotaPagarLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuotaPagarLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.CuotaPagarLabel1.Location = New System.Drawing.Point(474, 86)
        Me.CuotaPagarLabel1.Name = "CuotaPagarLabel1"
        Me.CuotaPagarLabel1.Size = New System.Drawing.Size(100, 25)
        Me.CuotaPagarLabel1.TabIndex = 87
        Me.CuotaPagarLabel1.Text = "Label1"
        '
        'InteresMoraLabel1
        '
        Me.InteresMoraLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "interesMora", True))
        Me.InteresMoraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InteresMoraLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.InteresMoraLabel1.Location = New System.Drawing.Point(171, 139)
        Me.InteresMoraLabel1.Name = "InteresMoraLabel1"
        Me.InteresMoraLabel1.Size = New System.Drawing.Size(100, 25)
        Me.InteresMoraLabel1.TabIndex = 89
        Me.InteresMoraLabel1.Text = "Label1"
        '
        'ValorRemateLabel1
        '
        Me.ValorRemateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "valorRemate", True))
        Me.ValorRemateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorRemateLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.ValorRemateLabel1.Location = New System.Drawing.Point(474, 139)
        Me.ValorRemateLabel1.Name = "ValorRemateLabel1"
        Me.ValorRemateLabel1.Size = New System.Drawing.Size(100, 25)
        Me.ValorRemateLabel1.TabIndex = 91
        Me.ValorRemateLabel1.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(NumeroIpLabel)
        Me.Panel1.Controls.Add(NombresLabel)
        Me.Panel1.Controls.Add(Me.NombresLabel1)
        Me.Panel1.Controls.Add(Me.ApellidosLabel1)
        Me.Panel1.Controls.Add(AsientoLabel)
        Me.Panel1.Controls.Add(Me.AsientoLabel1)
        Me.Panel1.Controls.Add(MatriculaLabel)
        Me.Panel1.Controls.Add(Me.MatriculaLabel1)
        Me.Panel1.Controls.Add(Me.NumeroIpLabel1)
        Me.Panel1.Controls.Add(TomoLabel)
        Me.Panel1.Controls.Add(Me.TomoLabel1)
        Me.Panel1.Location = New System.Drawing.Point(715, 159)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 252)
        Me.Panel1.TabIndex = 83
        '
        'NombresLabel1
        '
        Me.NombresLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "nombres", True))
        Me.NombresLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombresLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.NombresLabel1.Location = New System.Drawing.Point(119, 10)
        Me.NombresLabel1.Name = "NombresLabel1"
        Me.NombresLabel1.Size = New System.Drawing.Size(83, 25)
        Me.NombresLabel1.TabIndex = 79
        Me.NombresLabel1.Text = "Label1"
        '
        'ApellidosLabel1
        '
        Me.ApellidosLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "apellidos", True))
        Me.ApellidosLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosLabel1.ForeColor = System.Drawing.Color.DimGray
        Me.ApellidosLabel1.Location = New System.Drawing.Point(208, 10)
        Me.ApellidosLabel1.Name = "ApellidosLabel1"
        Me.ApellidosLabel1.Size = New System.Drawing.Size(100, 25)
        Me.ApellidosLabel1.TabIndex = 80
        Me.ApellidosLabel1.Text = "Label1"
        '
        'AsientoLabel1
        '
        Me.AsientoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "asiento", True))
        Me.AsientoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsientoLabel1.ForeColor = System.Drawing.Color.Black
        Me.AsientoLabel1.Location = New System.Drawing.Point(119, 66)
        Me.AsientoLabel1.Name = "AsientoLabel1"
        Me.AsientoLabel1.Size = New System.Drawing.Size(100, 25)
        Me.AsientoLabel1.TabIndex = 82
        Me.AsientoLabel1.Text = "Label1"
        '
        'MatriculaLabel1
        '
        Me.MatriculaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "matricula", True))
        Me.MatriculaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatriculaLabel1.ForeColor = System.Drawing.Color.Black
        Me.MatriculaLabel1.Location = New System.Drawing.Point(119, 114)
        Me.MatriculaLabel1.Name = "MatriculaLabel1"
        Me.MatriculaLabel1.Size = New System.Drawing.Size(100, 25)
        Me.MatriculaLabel1.TabIndex = 84
        Me.MatriculaLabel1.Text = "Label1"
        '
        'NumeroIpLabel1
        '
        Me.NumeroIpLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "numeroIp", True))
        Me.NumeroIpLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroIpLabel1.ForeColor = System.Drawing.Color.Black
        Me.NumeroIpLabel1.Location = New System.Drawing.Point(119, 165)
        Me.NumeroIpLabel1.Name = "NumeroIpLabel1"
        Me.NumeroIpLabel1.Size = New System.Drawing.Size(100, 25)
        Me.NumeroIpLabel1.TabIndex = 86
        Me.NumeroIpLabel1.Text = "Label1"
        '
        'TomoLabel1
        '
        Me.TomoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "tomo", True))
        Me.TomoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TomoLabel1.ForeColor = System.Drawing.Color.Black
        Me.TomoLabel1.Location = New System.Drawing.Point(119, 207)
        Me.TomoLabel1.Name = "TomoLabel1"
        Me.TomoLabel1.Size = New System.Drawing.Size(100, 25)
        Me.TomoLabel1.TabIndex = 88
        Me.TomoLabel1.Text = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Green
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 70)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1029, 52)
        Me.ProgressBar1.TabIndex = 84
        '
        'FechaLabel1
        '
        Me.FechaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "fecha", True))
        Me.FechaLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaLabel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.FechaLabel1.Location = New System.Drawing.Point(346, 47)
        Me.FechaLabel1.Name = "FechaLabel1"
        Me.FechaLabel1.Size = New System.Drawing.Size(106, 15)
        Me.FechaLabel1.TabIndex = 97
        Me.FechaLabel1.Text = "Label9"
        '
        'UsuarioLabel1
        '
        Me.UsuarioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SeguimientoBindingSource, "usuario", True))
        Me.UsuarioLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioLabel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.UsuarioLabel1.Location = New System.Drawing.Point(200, 46)
        Me.UsuarioLabel1.Name = "UsuarioLabel1"
        Me.UsuarioLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UsuarioLabel1.TabIndex = 96
        Me.UsuarioLabel1.Text = "Label9"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(776, 120)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(84, 26)
        Label10.TabIndex = 99
        Label10.Text = "SOLICITUD DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DOCUMENTOS"
        Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.White
        Label11.Location = New System.Drawing.Point(868, 120)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(84, 26)
        Label11.TabIndex = 100
        Label11.Text = "ENTREGA DE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DOCUMENTOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.White
        Label12.Location = New System.Drawing.Point(965, 120)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(82, 13)
        Label12.TabIndex = 101
        Label12.Text = "CANCELACION"
        Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1080, 758)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.FechaLabel1)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioLabel1)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EstadoIdLabel1)
        Me.Name = "seguimiento"
        Me.Opacity = 1.0R
        Me.Text = "ESTADO | AMC"
        Me.Controls.SetChildIndex(Me.EstadoIdLabel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ProgressBar1, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Label5, 0)
        Me.Controls.SetChildIndex(Label6, 0)
        Me.Controls.SetChildIndex(Label7, 0)
        Me.Controls.SetChildIndex(Label8, 0)
        Me.Controls.SetChildIndex(FechaLabel, 0)
        Me.Controls.SetChildIndex(Me.UsuarioLabel1, 0)
        Me.Controls.SetChildIndex(UsuarioLabel, 0)
        Me.Controls.SetChildIndex(Me.FechaLabel1, 0)
        Me.Controls.SetChildIndex(Label9, 0)
        Me.Controls.SetChildIndex(Label10, 0)
        Me.Controls.SetChildIndex(Label11, 0)
        Me.Controls.SetChildIndex(Label12, 0)
        CType(Me.DataSetCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeguimientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DescripcionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetCreditos As creditosHipotecarios.DataSetCreditos
    Friend WithEvents SeguimientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SeguimientoTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.seguimientoTableAdapter
    Friend WithEvents TableAdapterManager As creditosHipotecarios.DataSetCreditosTableAdapters.TableAdapterManager
    Friend WithEvents EstadoIdLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NombreAgenciaLabel1 As System.Windows.Forms.Label
    Friend WithEvents NombreClienteLabel1 As System.Windows.Forms.Label
    Friend WithEvents RnpClienteLabel1 As System.Windows.Forms.Label
    Friend WithEvents NombrePropietarioLabel1 As System.Windows.Forms.Label
    Friend WithEvents RnpPropietarioLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MontoLabel1 As System.Windows.Forms.Label
    Friend WithEvents PlazoLabel1 As System.Windows.Forms.Label
    Friend WithEvents TasaInteresLabel1 As System.Windows.Forms.Label
    Friend WithEvents CuotaPagarLabel1 As System.Windows.Forms.Label
    Friend WithEvents InteresMoraLabel1 As System.Windows.Forms.Label
    Friend WithEvents ValorRemateLabel1 As System.Windows.Forms.Label
    Friend WithEvents DescripcionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NombresLabel1 As System.Windows.Forms.Label
    Friend WithEvents ApellidosLabel1 As System.Windows.Forms.Label
    Friend WithEvents AsientoLabel1 As System.Windows.Forms.Label
    Friend WithEvents MatriculaLabel1 As System.Windows.Forms.Label
    Friend WithEvents NumeroIpLabel1 As System.Windows.Forms.Label
    Friend WithEvents TomoLabel1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents FechaLabel1 As System.Windows.Forms.Label
    Friend WithEvents UsuarioLabel1 As System.Windows.Forms.Label
End Class
