Public Class ReportMemo


    Public Sub New(ByRef NumFactura As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MemoAdapter1.Fill(Remportmemo1.Memo, NumFactura)

       

    End Sub
End Class