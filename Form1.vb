Imports System.Data.OleDb

Public Class Form1
    Public DIAS, PARCELAS, PERCENT As Double
    Private Sub PreencheCboCond()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT id_cond_pag,desc_cond_pag FROM Tbl_CondicoesPagamento"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

                cmbCondicoes.ValueMember = "id_cond_pag"
                cmbCondicoes.DisplayMember = "desc_cond_pag"
                cmbCondicoes.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try

        End Using
    End Sub

    Private Sub PreencheDados(ByVal parametro As String)
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()

                SQL = "SELECT Tbl_CondicoesPagamento.id_cond_pag, Tbl_CondicoesPagamento.desc_cond_pag, Tbl_CondicoesPagamento.parcelas, Tbl_PrazoPagamentoDetalhe.NDias, Tbl_PrazoPagamentoDetalhe.Percent
FROM Tbl_CondicoesPagamento INNER JOIN Tbl_PrazoPagamentoDetalhe ON Tbl_CondicoesPagamento.id_cond_pag = Tbl_PrazoPagamentoDetalhe.CodPrazoPagto
GROUP BY Tbl_CondicoesPagamento.id_cond_pag, Tbl_CondicoesPagamento.desc_cond_pag, Tbl_CondicoesPagamento.parcelas, Tbl_PrazoPagamentoDetalhe.NDias, Tbl_PrazoPagamentoDetalhe.Percent
HAVING Tbl_CondicoesPagamento.desc_cond_pag='" & parametro & "'"


                Dim cmd As OleDbCommand = New OleDbCommand(SQL, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    DIAS = dr.Item("NDias")
                    PARCELAS = dr.Item("parcelas")
                    PERCENT = dr.Item("Percent")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub cmbCondicoes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCondicoes.SelectedIndexChanged
        PreencheDados(cmbCondicoes.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreencheCboCond()
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class