Public Class frmRelVenda
    Private Sub frmRelVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSetBanco.qryVenda'. Você pode movê-la ou removê-la conforme necessário.
        Me.qryVendaTableAdapter.Fill_IdPedido(Me.DataSetBanco.qryVenda, ID_PEDIDOVENDA)
        'TODO: esta linha de código carrega dados na tabela 'DataSetBanco.qryDetalheVenda'. Você pode movê-la ou removê-la conforme necessário.
        Me.qryDetalheVendaTableAdapter.Fill_IdDetVenda(Me.DataSetBanco.qryDetalheVenda, ID_PEDIDOVENDA)
        'TODO: esta linha de código carrega dados na tabela 'DataSetBanco.qryParcelas'. Você pode movê-la ou removê-la conforme necessário.
        Me.qryParcelasTableAdapter.Fill_IdVencimentos(Me.DataSetBanco.qryParcelas, ID_PEDIDOVENDA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class