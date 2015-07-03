<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportFECHA
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Header = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TableHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrUsuario = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DataSetCreditos1 = New creditosHipotecarios.DataSetCreditos()
        Me.UsuarioTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter()
        Me._ReporteFechaTableAdapter = New creditosHipotecarios.DataSetCreditosTableAdapters._ReporteFechaTableAdapter()
        Me.XrFecha = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCreditos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'xrTableCell6
        '
        Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, " ReporteFecha.descripcion")})
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.Text = "xrTableCell6"
        Me.xrTableCell6.Weight = 0.46144207582412994R
        '
        'OddStyle
        '
        Me.OddStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.OddStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.OddStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.OddStyle.Name = "OddStyle"
        Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.OddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrLine1
        '
        Me.xrLine1.LineWidth = 2
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.00004238552!, 58.74998!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(649.9998!, 2.0!)
        Me.xrLine1.StyleName = "Header"
        '
        'xrTableCell4
        '
        Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, " ReporteFecha.nombreCliente")})
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.Text = "xrTableCell4"
        Me.xrTableCell4.Weight = 0.86595356313626459R
        '
        'xrTable1
        '
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 33.74999!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(649.9999!, 25.0!)
        Me.xrTable1.StyleName = "TableHeader"
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell7, Me.xrTableCell3})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.StylePriority.UseFont = False
        Me.xrTableCell1.Text = "NOMBRE"
        Me.xrTableCell1.Weight = 0.86462149190851545R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.StylePriority.UseFont = False
        Me.xrTableCell2.Text = "ESTADO"
        Me.xrTableCell2.Weight = 0.83468354231896336R
        '
        'xrTableCell7
        '
        Me.xrTableCell7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StylePriority.UseFont = False
        Me.xrTableCell7.StylePriority.UseTextAlignment = False
        Me.xrTableCell7.Text = "ACTUALIZADO"
        Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell7.Weight = 0.71053993661752435R
        '
        'xrTableCell3
        '
        Me.xrTableCell3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.StylePriority.UseFont = False
        Me.xrTableCell3.StylePriority.UseTextAlignment = False
        Me.xrTableCell3.Text = "NOTA"
        Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrTableCell3.Weight = 0.58553964410622639R
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!)
        Me.Header.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Header.Name = "Header"
        Me.Header.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Header.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell8, Me.xrTableCell6})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, " ReporteFecha.nombreEstado")})
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.Text = "xrTableCell5"
        Me.xrTableCell5.Weight = 1.0424068020515238R
        '
        'xrTableCell8
        '
        Me.xrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, " ReporteFecha.fecha", "{0:d/M/yy}")})
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.Text = "xrTableCell8"
        Me.xrTableCell8.Weight = 0.63019742033854809R
        '
        'xrLine3
        '
        Me.xrLine3.LineWidth = 2
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0001589457!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(649.9998!, 2.0!)
        Me.xrLine3.StyleName = "Header"
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(28.12503!, 12.41666!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(592.7083!, 50.70837!)
        Me.xrLabel1.StyleName = "Header"
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "REPORTE"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1, Me.xrLine1})
        Me.GroupHeader1.HeightF = 60.74999!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'xrPageInfo1
        '
        Me.xrPageInfo1.Format = "Page {0} of {1}"
        Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(584.3959!, 76.99998!)
        Me.xrPageInfo1.Name = "xrPageInfo1"
        Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(65.60406!, 23.0!)
        Me.xrPageInfo1.StyleName = "EvenStyle"
        '
        'EvenStyle
        '
        Me.EvenStyle.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.EvenStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.EvenStyle.Name = "EvenStyle"
        Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.EvenStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TableHeader
        '
        Me.TableHeader.BackColor = System.Drawing.Color.White
        Me.TableHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TableHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.TableHeader.Name = "TableHeader"
        Me.TableHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine2, Me.xrPageInfo1})
        Me.PageFooter.Name = "PageFooter"
        '
        'xrLine2
        '
        Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 64.58334!)
        Me.xrLine2.Name = "xrLine2"
        Me.xrLine2.SizeF = New System.Drawing.SizeF(649.9999!, 2.0!)
        Me.xrLine2.StyleName = "Header"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrFecha, Me.XrLabel2, Me.XrUsuario, Me.xrLabel1})
        Me.TopMargin.HeightF = 86.12504!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(28.12503!, 63.12504!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Usuario: "
        '
        'XrUsuario
        '
        Me.XrUsuario.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrUsuario.LocationFloat = New DevExpress.Utils.PointFloat(136.4584!, 63.12504!)
        Me.XrUsuario.Name = "XrUsuario"
        Me.XrUsuario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrUsuario.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrUsuario.StylePriority.UseFont = False
        Me.XrUsuario.Text = "XrUsuario"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail.HeightF = 28.125!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTable2
        '
        Me.xrTable2.EvenStyleName = "EvenStyle"
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.OddStyleName = "OddStyle"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(650.0!, 16.66667!)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine3})
        Me.GroupFooter1.HeightF = 3.041649!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DataSetCreditos1
        '
        Me.DataSetCreditos1.DataSetName = "DataSetCreditos"
        Me.DataSetCreditos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        '_ReporteFechaTableAdapter
        '
        Me._ReporteFechaTableAdapter.ClearBeforeFill = True
        '
        'XrFecha
        '
        Me.XrFecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrFecha.LocationFloat = New DevExpress.Utils.PointFloat(489.5833!, 63.12502!)
        Me.XrFecha.Name = "XrFecha"
        Me.XrFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrFecha.SizeF = New System.Drawing.SizeF(131.25!, 23.0!)
        Me.XrFecha.StylePriority.UseFont = False
        Me.XrFecha.Text = "XrFecha"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(368.75!, 63.12502!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Fecha:"
        '
        'ReportFECHA
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataAdapter = Me.UsuarioTableAdapter
        Me.DataMember = " ReporteFecha"
        Me.DataSource = Me.DataSetCreditos1
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 86, 0)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Header, Me.TableHeader, Me.OddStyle, Me.EvenStyle})
        Me.Version = "13.1"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCreditos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

End Sub
    Friend WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents OddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Header As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TableHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents xrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DataSetCreditos1 As creditosHipotecarios.DataSetCreditos
    Friend WithEvents UsuarioTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.UsuarioTableAdapter
    Friend WithEvents _ReporteFechaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters._ReporteFechaTableAdapter
    Friend WithEvents XrUsuario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    'Friend WithEvents ReporteFechaTableAdapter As creditosHipotecarios.DataSetCreditosTableAdapters.ReporteFechaTableAdapter
End Class
