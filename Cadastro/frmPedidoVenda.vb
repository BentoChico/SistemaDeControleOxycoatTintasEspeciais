Imports System.Data.OleDb

Public Class frmPedidoVenda
    Dim _unique_id_venda As String

    Private Sub frmPedidoVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveXButton(Me.Handle)
        _unique_id_venda = System.Guid.NewGuid.ToString("N")
        tcPedido.SelectedIndex = 0
        'If dgvListaPedidos.Rows.Count > 0 Then
        'ConfiguraGridLista()
        'End If
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
        btnEdita.Enabled = False
        btnImprimir.Enabled = False
        cboCliente.Enabled = False
        TxtNumPedido.Enabled = False
        cboStatus.Enabled = False
    End Sub
    Private Sub PreencheCboCliente()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String = "SELECT id,razao FROM Tbl_Clientes"
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)

                cboCliente.ValueMember = "id"
                cboCliente.DisplayMember = "razao"
                cboCliente.DataSource = dt
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

                SQL = "SELECT Tbl_Clientes.id, Tbl_Clientes.razao, Tbl_Clientes.cond_pag_cli, Tbl_CondicoesPagamento.desc_cond_pag, 
                Tbl_Clientes.repres_cli, Tbl_Representante.nome, Tbl_Clientes.transp_cli, 
                Tbl_Clientes.contato, Tbl_Transportadora.razao_transp, 
                Tbl_Clientes.endereco, Tbl_Clientes.bairro, 
                Tbl_Clientes.cidade, Tbl_Clientes.uf, Tbl_Clientes.contato, Tbl_Clientes.tel1, Tbl_Clientes.cel, Tbl_Icms.icm_uf
                FROM (((Tbl_Clientes INNER JOIN Tbl_CondicoesPagamento ON Tbl_Clientes.cond_pag_cli = Tbl_CondicoesPagamento.id_cond_pag) INNER JOIN Tbl_Representante ON Tbl_Clientes.repres_cli = Tbl_Representante.id_rep) INNER JOIN Tbl_Transportadora ON Tbl_Clientes.transp_cli = Tbl_Transportadora.id_transp) INNER JOIN Tbl_Icms ON Tbl_Clientes.uf = Tbl_Icms.sigla_uf
                WHERE Tbl_Clientes.razao='" & parametro & "'"


                Dim cmd As OleDbCommand = New OleDbCommand(SQL, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    ID_CLIENTE = dr.Item("id")
                    TxtCondicoes.Text = dr.Item("desc_cond_pag")
                    TxtRepresentante.Text = dr.Item("nome")
                    _ICMS = dr.Item("icm_uf")
                    TxtEndereco.Text = dr.Item("endereco")
                    TxtBairro.Text = dr.Item("bairro")
                    TxtCidade.Text = dr.Item("cidade")
                    txtUf.Text = dr.Item("uf")
                    mskTelCli.Text = dr.Item("tel1")
                    mskCelCli.Text = dr.Item("cel")
                    TxtContato.Text = dr.Item("contato")
                    TxtRepresentante.Text = dr.Item("nome")
                    If Not IsDBNull(dr.Item("razao_transp")) Then TxtTransporte.Text = dr.Item("razao_transp")
                    'If Not IsDBNull(dr.Item("endreco_transp")) Then TxtEndecTransp.Text = dr.Item("endreco_transp")
                    'If Not IsDBNull(dr.Item("bairro_transp")) Then TxtBairroTransp.Text = dr.Item("bairro_transp")
                    'If Not IsDBNull(dr.Item("cidade_transp")) Then TxtCidadeTransp.Text = dr.Item("cidade_transp")
                    'If Not IsDBNull(dr.Item("uf_transp")) Then TxtUfTransp.Text = dr.Item("uf_transp")
                    'If Not IsDBNull(dr.Item("telefone_transp")) Then mskTelTransp.Text = dr.Item("telefone_transp")
                    'If Not IsDBNull(dr.Item("celular_transp")) Then mskCelTransp.Text = dr.Item("celular_transp")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Function CarregaDadosProd() As DataTable

        SQL = "SELECT Tbl_DetalheProdutoCliente.id_cli_det_prod, Tbl_DetalheProdutoCliente.id_prod_det_cli, 
        Tbl_Produto.cod_prod, Tbl_Produto.desc_prod, Tbl_Produto.ncm_prod, Tbl_Produto.ipi_prod, Tbl_DetalheProdutoCliente.preco_venda_prod_det_cli
        FROM Tbl_DetalheProdutoCliente INNER JOIN Tbl_Produto ON Tbl_DetalheProdutoCliente.id_prod_det_cli = Tbl_Produto.id_prod
        WHERE Tbl_DetalheProdutoCliente.id_cli_det_prod=" & (CInt(ID_CLIENTE))


        Dim dt As New DataTable

        Try

            Using con As OleDbConnection = GetConnection()
                con.Open()
                Using da = New OleDbDataAdapter(SQL, con)
                    da.Fill(dt)
                    dgvRelacaoProdutoCliente.DataSource = dt
                End Using
                ConfiguraGrid()
            End Using

        Catch ex As Exception
            MsgBox("Falha: " + ex.Message)
            dt = Nothing
        End Try
        Return dt

    End Function
    Private Sub ConfiguraGrid()
        With dgvRelacaoProdutoCliente
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .RowHeadersWidth = 25       'Largura do seletor lateral

            .Columns(1).HeaderText = "IDCli"
            .Columns(1).Width = 50
            .Columns(1).Visible = False

            .Columns(2).HeaderText = "IDProd"
            .Columns(2).Width = 50
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "Codigo"
            .Columns(3).Width = 50
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Descrição"
            .Columns(4).Width = 50
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "Ncm"
            .Columns(5).Width = 50
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "IPI"
            .Columns(6).Width = 50
            .Columns(6).Visible = True

            .Columns(7).HeaderText = "Prç. de Venda"
            .Columns(7).Width = 50
            .Columns(7).Visible = True
        End With
    End Sub
    Private Sub cboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectedIndexChanged
        PreencheDados(cboCliente.Text)
        TxtNumPedido.Focus()
        CarregaDadosProd()
    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        PreencheCboCliente()
        cboCliente.SelectedIndex = -1
        LimpaCampos()
        mskDataCad.Text = Date.Today
        cboCliente.Enabled = True
        TxtNumPedido.Enabled = True
        cboStatus.Enabled = True
        cboCliente.Focus()
        TxtRepresentante.Text = ""
        TxtTransporte.Text = ""
        TxtCondicoes.Text = ""
        btnNovo.Enabled = False
        btnConsulta.Enabled = False
        btnSalvar.Enabled = True
        btnEdita.Enabled = False
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False
    End Sub
    Private Sub LimpaCampos()
        TxtId.Clear()
        cboCliente.Text = ""
        cboCliente.SelectedIndex = -1
        TxtNumPedido.Clear()
        mskDataCad.Clear()
        cboStatus.SelectedIndex = -1
        TxtRepresentante.Clear()
        TxtEndereco.Clear()
        TxtBairro.Clear()
        TxtCidade.Clear()
        txtUf.Clear()
        TxtContato.Clear()
        mskTelCli.Clear()
        mskCelCli.Clear()
        TxtTransporte.Clear()
        TxtCondicoes.Clear()
    End Sub
    Private Sub PEncerraPedido()
        Dim sql As String
        Using con As OleDbConnection = GetConnection()
            Try
                If TxtId.Text = "" Then
                    con.Open()
                    sql = "INSERT INTO Tbl_PedidoVenda (id_pedido,id_cliente,dta_emissao,num_ped_cli,status_pedido) VALUES (?,?,?,?,?)"
                    Dim cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.Add(New OleDbParameter("id_pedido", _unique_id_venda))
                    cmd.Parameters.Add(New OleDbParameter("id_cliente", ID_CLIENTE))
                    cmd.Parameters.Add(New OleDbParameter("dta_emissao", mskDataCad.Text))
                    cmd.Parameters.Add(New OleDbParameter("num_ped_cli", TxtNumPedido.Text))
                    cmd.Parameters.Add(New OleDbParameter("status_pedido", cboStatus.Text))
                    cmd.ExecuteNonQuery()
                    MsgBox("Pedido Iniciado com sucesso!", vbInformation, "Aviso")
                Else
                    con.Open()
                    sql = "Update Tbl_PedidoVenda set "
                    sql += "id_cliente=?, dta_emissao=?, "
                    sql += "num_ped_cli=?, status_pedido=?"
                    sql += "Where id_pedido=?"
                    Dim cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.Add(New OleDbParameter("id_cliente", ID_CLIENTE))
                    cmd.Parameters.Add(New OleDbParameter("dta_emissao", mskDataCad.Text))
                    cmd.Parameters.Add(New OleDbParameter("num_ped_cli", TxtNumPedido.Text))
                    cmd.Parameters.Add(New OleDbParameter("status_pedido", cboStatus.Text))
                    cmd.Parameters.Add(New OleDbParameter("id_pedido", TxtId.Text))
                    cmd.ExecuteNonQuery()
                    MsgBox("Pedido Alterado com sucesso!", vbInformation, "Aviso")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Dispose()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        PEncerraPedido()
        PLeDados(_unique_id_venda)
        'dgvPedido.DataSource.Clear
        'LimpaCampos()
        cboCliente.Enabled = False
        TxtNumPedido.Enabled = False
        cboStatus.Enabled = False
        TxtProduto.Enabled = True
        TxtQtde.Enabled = True
        btnNovo.Enabled = False
        btnSalvar.Enabled = False
        btnEdita.Enabled = False
        btnExcluir.Enabled = False
        btnConsulta.Enabled = True
        btnFechar.Enabled = True
        TxtProduto.Focus()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        tcPedido.SelectedIndex = 3
        TxtPesquisa.Focus()
    End Sub


    Private Sub btnPesquisaGeral_Click(sender As Object, e As EventArgs) Handles btnPesquisaGeral.Click
        dgvListaPedidos.DataSource = CarregaPedidos()

        ConfiguraGridLista()
    End Sub
    Private Function CarregaPedidos() As DataTable

        SQL = "SELECT Tbl_PedidoVenda.id_pedido, Tbl_PedidoVenda.id_cliente, Tbl_Clientes.razao, Tbl_Clientes.endereco, Tbl_Clientes.bairro, Tbl_Clientes.cidade, Tbl_Clientes.uf, Tbl_Clientes.contato, Tbl_Clientes.tel1, Tbl_Clientes.cel, Tbl_Representante.nome, Tbl_Transportadora.razao_transp, Tbl_Transportadora.endreco_transp, Tbl_Transportadora.bairro_transp, Tbl_Transportadora.cidade_transp, Tbl_Transportadora.uf_transp, Tbl_Transportadora.telefone_transp, Tbl_Transportadora.celular_transp, Tbl_CondicoesPagamento.desc_cond_pag, Tbl_CondicoesPagamento.dias_1, Tbl_CondicoesPagamento.dias_2, Tbl_CondicoesPagamento.dias_3, Tbl_CondicoesPagamento.parcelas, Tbl_PedidoVenda.dta_emissao, Tbl_PedidoVenda.num_ped_cli, Tbl_PedidoVenda.status_pedido, Tbl_Icms.icm_uf
        FROM ((((Tbl_PedidoVenda INNER JOIN Tbl_Clientes ON Tbl_PedidoVenda.id_cliente = Tbl_Clientes.id) INNER JOIN Tbl_Transportadora ON Tbl_Clientes.transp_cli = Tbl_Transportadora.id_transp) INNER JOIN Tbl_CondicoesPagamento ON Tbl_Clientes.cond_pag_cli = Tbl_CondicoesPagamento.id_cond_pag) INNER JOIN Tbl_Representante ON Tbl_Clientes.repres_cli = Tbl_Representante.id_rep) INNER JOIN Tbl_Icms ON Tbl_Clientes.uf = Tbl_Icms.sigla_uf;"
        'WHERE Tbl_PedidoVenda.id_pedido='" & _unique_id_venda & "'"


        Dim dt As New DataTable

        Try

            Using con As OleDbConnection = GetConnection()
                con.Open()
                Using da = New OleDbDataAdapter(Sql, con)
                    da.Fill(dt)

                End Using

            End Using

        Catch ex As Exception
            MsgBox("Falha: " + ex.Message)
            dt = Nothing
        End Try
        Return dt

    End Function
    Private Sub ConfiguraGridLista()
        With dgvListaPedidos
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .RowHeadersWidth = 25       'Largura do seletor lateral

            .Columns(1).HeaderText = "N.º Ped."
            .Columns(1).Width = 40
            .Columns(1).Visible = True

            .Columns(2).HeaderText = "IDCli"
            .Columns(2).Width = 50
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "Cliente"
            .Columns(3).Width = 200
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Endereço"
            .Columns(4).Width = 50
            .Columns(4).Visible = False

            .Columns(5).HeaderText = "Bairro"
            .Columns(5).Width = 50
            .Columns(5).Visible = False

            .Columns(6).HeaderText = "Cidade"
            .Columns(6).Width = 50
            .Columns(6).Visible = False

            .Columns(7).HeaderText = "UF"
            .Columns(7).Width = 50
            .Columns(7).Visible = False

            .Columns(8).HeaderText = "Contato"
            .Columns(8).Width = 50
            .Columns(8).Visible = False

            .Columns(9).HeaderText = "Telef."
            .Columns(9).Width = 50
            .Columns(9).Visible = False

            .Columns(10).HeaderText = "Celular"
            .Columns(10).Width = 50
            .Columns(10).Visible = False

            .Columns(11).HeaderText = "Representante"
            .Columns(11).Width = 50
            .Columns(11).Visible = True

            .Columns(12).HeaderText = "Transportadora"
            .Columns(12).Width = 50
            .Columns(12).Visible = True

            .Columns(13).HeaderText = "End. Trsnp."
            .Columns(13).Width = 50
            .Columns(13).Visible = False

            .Columns(14).HeaderText = "Bairro. Trsnp."
            .Columns(14).Width = 50
            .Columns(14).Visible = False

            .Columns(15).HeaderText = "Cidade Trsnp."
            .Columns(15).Width = 50
            .Columns(15).Visible = False

            .Columns(16).HeaderText = "Uf Trsnp."
            .Columns(16).Width = 50
            .Columns(16).Visible = False

            .Columns(17).HeaderText = "Tel.Trnsp"
            .Columns(17).Width = 50
            .Columns(17).Visible = False

            .Columns(18).HeaderText = "Cel.Trnsp"
            .Columns(18).Width = 50
            .Columns(18).Visible = False

            .Columns(19).HeaderText = "Cond. Pag."
            .Columns(19).Width = 50
            .Columns(19).Visible = True

            .Columns(20).HeaderText = "Dias1"
            .Columns(20).Width = 50
            .Columns(20).Visible = False

            .Columns(21).HeaderText = "Dias2"
            .Columns(21).Width = 50
            .Columns(21).Visible = False

            .Columns(22).HeaderText = "Dias3"
            .Columns(22).Width = 50
            .Columns(22).Visible = False

            .Columns(23).HeaderText = "Parcelas"
            .Columns(23).Width = 50
            .Columns(23).Visible = False

            .Columns(24).HeaderText = "Dta. Emis."
            .Columns(24).Width = 50
            .Columns(24).Visible = True

            .Columns(25).HeaderText = "N.º Ped. Cli."
            .Columns(25).Width = 70
            .Columns(25).Visible = True

            For Each row As DataGridViewRow In .Rows

                If row.Cells(26).Value = "ATIVO" Then
                    row.Cells(26).Style.ForeColor = Color.Blue
                Else
                    row.Cells(26).Style.ForeColor = Color.Red
                End If
                .Columns(26).Visible = True
            Next

            .Columns(27).HeaderText = "ICMS"
            .Columns(27).Width = 50
            .Columns(27).Visible = False

        End With
    End Sub

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        PBuscaPedidos(TxtPesquisa.Text)
    End Sub

    Private Sub PBuscaPedidos(ByVal strRazao As String)
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()

                SQL = "SELECT Tbl_PedidoVenda.id_pedido, Tbl_PedidoVenda.id_cliente, Tbl_Clientes.razao, Tbl_Clientes.endereco, 
                Tbl_Clientes.bairro, Tbl_Clientes.cidade, Tbl_Clientes.uf, Tbl_Clientes.contato, Tbl_Clientes.tel1, Tbl_Clientes.cel, 
                Tbl_Representante.nome, Tbl_Transportadora.razao_transp, Tbl_Transportadora.endreco_transp, Tbl_Transportadora.bairro_transp,
                Tbl_Transportadora.cidade_transp, Tbl_Transportadora.uf_transp, Tbl_Transportadora.telefone_transp, Tbl_Transportadora.celular_transp,
                Tbl_CondicoesPagamento.desc_cond_pag, Tbl_CondicoesPagamento.dias_1, Tbl_CondicoesPagamento.dias_2, Tbl_CondicoesPagamento.dias_3, 
                Tbl_CondicoesPagamento.parcelas, Tbl_PedidoVenda.dta_emissao, Tbl_PedidoVenda.num_ped_cli, Tbl_PedidoVenda.status_pedido, Tbl_Icms.icm_uf
                FROM ((((Tbl_PedidoVenda INNER JOIN Tbl_Clientes ON Tbl_PedidoVenda.id_cliente = Tbl_Clientes.id) INNER JOIN Tbl_Transportadora ON Tbl_Clientes.transp_cli = Tbl_Transportadora.id_transp) INNER JOIN Tbl_CondicoesPagamento ON Tbl_Clientes.cond_pag_cli = Tbl_CondicoesPagamento.id_cond_pag) INNER JOIN Tbl_Representante ON Tbl_Clientes.repres_cli = Tbl_Representante.id_rep) INNER JOIN Tbl_Icms ON Tbl_Clientes.uf = Tbl_Icms.sigla_uf
                WHERE Tbl_Clientes.razao LIKE '%" & strRazao & "%'"


                Dim cmd As OleDbCommand = New OleDbCommand(SQL, con)

                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvListaPedidos.DataSource = dt
                'Formata a gridview
                ConfiguraGridLista()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub dgvListaPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPedidos.CellClick
        Try
            If e.ColumnIndex = 0 Then
                'PLimpaCampos()
                tcPedido.SelectedIndex = 0
                TxtId.Text = dgvListaPedidos.Rows(e.RowIndex).Cells(1).Value
                PLeDados((TxtId.Text))
                CarregaDadosProd()
            End If
            TxtProduto.Enabled = False
            dgvPedido.Enabled = False
            btnNovo.Enabled = False
            btnConsulta.Enabled = False
            btnSalvar.Enabled = False
            btnEdita.Enabled = True
            btnCancelar.Enabled = True
            btnExcluir.Enabled = True
            btnImprimir.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub PLeDados(CodigoPedido As String)
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()


                SQL = "SELECT Tbl_PedidoVenda.id_pedido, Tbl_PedidoVenda.id_cliente, Tbl_PedidoVenda.dta_emissao, Tbl_PedidoVenda.num_ped_cli, 
                Tbl_PedidoVenda.status_pedido, Tbl_Clientes.razao, Tbl_Representante.nome, Tbl_Clientes.endereco, Tbl_Clientes.bairro, 
                Tbl_Clientes.cidade, Tbl_Clientes.uf, Tbl_Clientes.contato, Tbl_Clientes.tel1, Tbl_Clientes.cel, Tbl_Transportadora.razao_transp,
                Tbl_CondicoesPagamento.desc_cond_pag
                FROM (((Tbl_PedidoVenda INNER JOIN Tbl_Clientes ON Tbl_PedidoVenda.id_cliente = Tbl_Clientes.id) INNER JOIN Tbl_Representante ON Tbl_Clientes.repres_cli = Tbl_Representante.id_rep) INNER JOIN Tbl_Transportadora ON Tbl_Clientes.transp_cli = Tbl_Transportadora.id_transp) INNER JOIN Tbl_CondicoesPagamento ON Tbl_Clientes.cond_pag_cli = Tbl_CondicoesPagamento.id_cond_pag
                 WHERE Tbl_PedidoVenda.id_pedido LIKE '%" & CodigoPedido & "%'"


                Dim cmd As OleDbCommand = New OleDbCommand(SQL, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    ID_PEDIDOVENDA = dr.Item("id_pedido")
                    TxtId.Text = dr.Item("id_pedido")
                    ID_CLIENTE = dr.Item("id_cliente")
                    mskDataCad.Text = dr.Item("dta_emissao")
                    TxtNumPedido.Text = dr.Item("num_ped_cli")
                    cboStatus.Text = dr.Item("status_pedido")
                    cboCliente.Text = dr.Item("razao")
                    TxtRepresentante.Text = dr.Item("nome")
                    TxtEndereco.Text = dr.Item("endereco")
                    TxtBairro.Text = dr.Item("bairro")
                    TxtCidade.Text = dr.Item("cidade")
                    txtUf.Text = dr.Item("uf")
                    TxtContato.Text = dr.Item("contato")
                    mskTelCli.Text = dr.Item("tel1")
                    mskCelCli.Text = dr.Item("cel")
                    If Not IsDBNull(dr.Item("razao_transp")) Then TxtTransporte.Text = dr.Item("razao_transp")
                    'If Not IsDBNull(dr.Item("endreco_transp")) Then TxtEndecTransp.Text = dr.Item("endreco_transp")
                    'If Not IsDBNull(dr.Item("bairro_transp")) Then TxtBairroTransp.Text = dr.Item("bairro_transp")
                    'If Not IsDBNull(dr.Item("cidade_transp")) Then TxtCidadeTransp.Text = dr.Item("cidade_transp")
                    'If Not IsDBNull(dr.Item("uf_transp")) Then TxtUfTransp.Text = dr.Item("uf_transp")
                    'If Not IsDBNull(dr.Item("telefone_transp")) Then mskTelTransp.Text = dr.Item("telefone_transp")
                    'If Not IsDBNull(dr.Item("celular_transp")) Then mskCelTransp.Text = dr.Item("celular_transp")
                    TxtCondicoes.Text = dr.Item("desc_cond_pag")
                End If
                CarregaItensPedido()
                CalcPedido()
                'GeraParcelas()
                'TxtProduto.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                dr.Close()
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btnEdita_Click(sender As Object, e As EventArgs) Handles btnEdita.Click
        cboCliente.Enabled = True
        TxtNumPedido.Enabled = True
        cboStatus.Enabled = True
        cboCliente.Focus()
        btnSalvar.Enabled = True
        dgvListaPedidos.Refresh()
        dgvListaPedidos.DataSource.Clear
        dgvPedido.Enabled = True
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged

    End Sub

    Private Sub TxtProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtProduto.KeyDown
        tcPedido.SelectedIndex = 1
        dgvRelacaoProdutoCliente.DataSource = CarregaDadosProd()
        If dgvRelacaoProdutoCliente.Rows.Count > 0 Then
            ConfiguraGrid()
        End If
    End Sub

    Private Sub dgvRelacaoProdutoCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRelacaoProdutoCliente.CellContentClick
        If e.ColumnIndex = 0 Then
            _IDPROD = dgvRelacaoProdutoCliente.Rows(e.RowIndex).Cells(2).Value
            TxtProduto.Text = dgvRelacaoProdutoCliente.Rows(e.RowIndex).Cells(4).Value
            TxtCodigo.Text = dgvRelacaoProdutoCliente.Rows(e.RowIndex).Cells(3).Value
            TxtPrcVenda.Text = FormatNumber(dgvRelacaoProdutoCliente.Rows(e.RowIndex).Cells(7).Value)

            tcPedido.SelectedIndex = 0
        End If
        TxtIten.Text = dgvPedido.RowCount + 1
        TxtQtde.Enabled = True
        TxtQtde.Focus()
    End Sub

    Private Sub TxtQtde_TextChanged(sender As Object, e As EventArgs) Handles TxtQtde.TextChanged
        Moeda(TxtQtde)
    End Sub

    Private Sub TxtQtde_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQtde.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgvPedido.AllowUserToAddRows = False
            SalvarProdutoPedido()
            dgvPedido.AllowUserToAddRows = False
            CarregaItensPedido()
            CalcPedido()
            GeraParcelas()
            TxtProduto.Text = ""
            TxtCodigo.Text = ""
            TxtPrcVenda.Text = ""
            TxtQtde.Text = ""
            TxtProduto.Focus()
        End If
    End Sub

    Private Sub SalvarProdutoPedido()

        Using con As OleDbConnection = GetConnection()
            Try
                If _IDDETALHE = "" Then
                    con.Open()
                    Dim Sql = "INSERT INTO Tbl_DetalhePedidoVenda (id_pedido, id_produto, qtde_pedido, preco_venda_pedido, iten_pedido) VALUES (?,?,?,?,?)"
                    Dim cmd As OleDbCommand = New OleDbCommand(Sql, con)
                    cmd.Parameters.Add(New OleDbParameter("id_pedido", SqlDbType.VarChar)).Value = TxtId.Text
                    cmd.Parameters.Add(New OleDbParameter("id_produto", SqlDbType.VarChar)).Value = _IDPROD
                    cmd.Parameters.Add(New OleDbParameter("qtde_pedido", SqlDbType.VarChar)).Value = TxtQtde.Text
                    cmd.Parameters.Add(New OleDbParameter("preco_venda_pedido", SqlDbType.VarChar)).Value = TxtPrcVenda.Text
                    cmd.Parameters.Add(New OleDbParameter("iten_pedido", SqlDbType.VarChar)).Value = TxtIten.Text
                    cmd.ExecuteNonQuery()
                Else
                    con.Open()
                    Dim Sql = "UPDATE Tbl_DetalhePedidoVenda SET id_pedido=?, id_produto=?, qtde_pedido=?, preco_venda_pedido=?, iten_pedido=? WHERE id_det_pedido=@id_det_pedido"
                    MsgBox("Iten alterado com sucesso", vbExclamation, "Aviso")

                    Dim cmd As OleDbCommand = New OleDbCommand(Sql, con)
                    cmd.Parameters.Add(New OleDbParameter("id_pedido", SqlDbType.VarChar)).Value = TxtId.Text
                    cmd.Parameters.Add(New OleDbParameter("id_produto", SqlDbType.VarChar)).Value = _IDPROD
                    cmd.Parameters.Add(New OleDbParameter("qtde_pedido", SqlDbType.VarChar)).Value = TxtQtde.Text
                    cmd.Parameters.Add(New OleDbParameter("preco_venda_pedido", SqlDbType.VarChar)).Value = TxtPrcVenda.Text
                    cmd.Parameters.Add(New OleDbParameter("iten_pedido", SqlDbType.VarChar)).Value = TxtIten.Text
                    cmd.Parameters.Add(New OleDbParameter("@id_det_pedido", SqlDbType.VarChar)).Value = _IDDETALHE
                    cmd.ExecuteNonQuery()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Sub

    Public Function CarregaItensPedido() As DataTable

        SQL = "SELECT Tbl_DetalhePedidoVenda.id_det_pedido, Tbl_DetalhePedidoVenda.id_pedido, Tbl_DetalhePedidoVenda.id_produto, Tbl_DetalhePedidoVenda.iten_pedido, Tbl_Produto.cod_prod, Tbl_Produto.desc_prod, Tbl_DetalhePedidoVenda.qtde_pedido, Tbl_DetalhePedidoVenda.preco_venda_pedido, [qtde_pedido]*[preco_venda_pedido] AS T_Pedido, ([total_produto]*[ipi_prod])/100 AS T_Ipi, ([total_produto]*[icm_uf])/100 AS T_Icm, [T_Pedido]+[T_Ipi] AS S_Pedido
        FROM (((Tbl_DetalhePedidoVenda INNER JOIN Tbl_Produto ON Tbl_DetalhePedidoVenda.id_produto = Tbl_Produto.id_prod) INNER JOIN Tbl_PedidoVenda ON Tbl_DetalhePedidoVenda.id_pedido = Tbl_PedidoVenda.id_pedido) INNER JOIN Tbl_Clientes ON Tbl_PedidoVenda.id_cliente = Tbl_Clientes.id) INNER JOIN Tbl_Icms ON Tbl_Clientes.uf = Tbl_Icms.sigla_uf
        WHERE Tbl_DetalhePedidoVenda.id_pedido LIKE '%" & TxtId.Text & "%'
        ORDER BY Tbl_DetalhePedidoVenda.iten_pedido;"


        Dim dt As New DataTable
        Dim ds As DataSet = New DataSet

        Try

            Using con As OleDbConnection = GetConnection()
                con.Open()
                Using da = New OleDbDataAdapter(SQL, con)
                    da.Fill(ds, "Tbl_DetalhePedidoVenda")
                    dgvPedido.DataSource = ds.Tables("Tbl_DetalhePedidoVenda")
                    ConfiguraGridIten()
                    con.Close()
                End Using

            End Using

        Catch ex As Exception
            MsgBox("Falha: " + ex.Message)

            dt = Nothing
        End Try
        Return dt
    End Function

    Public Sub ConfiguraGridIten()
        With dgvPedido
            'Cor do Cabeçalho
            '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            '.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            'Dados
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersWidth = 25       'Largura do seletor lateral

            .Columns(0).Width = 50

            .Columns(1).HeaderText = "ID Det"
            .Columns(1).Width = 50
            .Columns(1).Visible = False

            .Columns(2).HeaderText = "ID Ped"
            .Columns(2).Width = 50
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "ID Prod"
            .Columns(3).Width = 50
            .Columns(3).Visible = False

            .Columns(4).HeaderText = "Iten"
            .Columns(4).Width = 50
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "Codigo"
            .Columns(5).Width = 80
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "Descrição"
            .Columns(6).Width = 250
            .Columns(6).Visible = True

            .Columns(7).HeaderText = "QTDE"
            .Columns(7).Width = 60
            .Columns(7).DefaultCellStyle.Format = "N0"
            .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(7).Visible = True

            .Columns(8).HeaderText = "PREÇO"
            .Columns(8).Width = 80
            .Columns(8).DefaultCellStyle.Format = "N2"
            .Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).Visible = True

            .Columns(9).HeaderText = "TOTAL"
            .Columns(9).Width = 95
            .Columns(9).DefaultCellStyle.Format = "N2"
            .Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(9).Visible = True

            .Columns(10).HeaderText = "IPI"
            .Columns(10).Width = 70
            .Columns(10).DefaultCellStyle.Format = "N2"
            .Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(10).Visible = True

            .Columns(11).HeaderText = "ICM"
            .Columns(11).Width = 70
            .Columns(11).DefaultCellStyle.Format = "N2"
            .Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).Visible = True

            .Columns(12).HeaderText = "Total Iten"
            .Columns(12).Width = 95
            .Columns(12).DefaultCellStyle.Format = "N2"
            .Columns(12).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(12).Visible = True

        End With
    End Sub

    Public Sub CalcPedido()

        Dim _totalbase As Double
        For i As Integer = 0 To dgvPedido.RowCount - 1
            _totalbase = _totalbase + dgvPedido.Rows(i).Cells(9).Value
        Next
        TxtTotalBase.Text = FormatNumber(_totalbase)

        Dim _totalipi As Double
        For i As Integer = 0 To dgvPedido.RowCount - 1
            _totalipi = _totalipi + dgvPedido.Rows(i).Cells(10).Value
        Next
        TxtTotalIpi.Text = FormatNumber(_totalipi)

        Dim _totalicm As Double
        For i As Integer = 0 To dgvPedido.RowCount - 1
            _totalicm = _totalicm + dgvPedido.Rows(i).Cells(11).Value
        Next
        TxtTotalIcm.Text = FormatNumber(_totalicm)

        Dim _totalpedido As Double
        For i As Integer = 0 To dgvPedido.RowCount - 1
            _totalpedido = _totalpedido + dgvPedido.Rows(i).Cells(12).Value
        Next
        TxtTotalPedido.Text = FormatNumber(_totalpedido)


    End Sub

    Private Sub dgvPedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellContentClick
        With dgvPedido.Rows(dgvPedido.CurrentCell.RowIndex)
            _IDDETALHE = .Cells(1).Value
            _IDPROD = .Cells(3).Value
            TxtProduto.Text = .Cells(6).Value
            TxtCodigo.Text = .Cells(5).Value
            TxtQtde.Text = Format((.Cells(7).Value), "N2")
            _ITEN = .Cells(4).Value
            TxtIten.Text = .Cells(4).Value
            TxtPrcVenda.Text = .Cells(8).Value
        End With
        CalcPedido()
        btnEdita.Enabled = True
        btnExcluir.Enabled = True
        btnConsulta.Enabled = False
        btnCancelar.Enabled = True
        btnNovo.Enabled = False
        btnSalvar.Enabled = True
        btnImprimir.Enabled = True
        TxtQtde.Enabled = True
        TxtProduto.Focus()
    End Sub
    Private Sub PExcluiItens()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                Dim sql As String
                sql = "DELETE Tbl_DetalhePedidoVenda.id_pedido
                FROM Tbl_DetalhePedidoVenda
                WHERE Tbl_DetalhePedidoVenda.id_det_pedido LIKE '%" & dgvPedido.CurrentRow().Cells(1).Value & "%'"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Iten cancelado.", MsgBoxStyle.Information, "Oxycoat")
                'PLimpaCampos()
                'tcCliente.SelectTab(0)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub dgvPedido_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellDoubleClick
        If e.ColumnIndex = 0 Then
            intPergunta = MsgBox("Tem certeza que deseja remover o produto!" & dgvPedido.CurrentRow().Cells(6).Value.ToString & "` da lista?",
                                               MsgBoxStyle.Question + MsgBoxStyle.YesNo, My.Application.Info.CompanyName)
            If intPergunta <> vbYes Then Exit Sub
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index)

            PExcluiItens()
            CalcPedido()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If TxtId.Text = "" Then
            MsgBox("Escolha um pedido para que possa ser feita a exclusão.", MsgBoxStyle.Information, "Oxycoat")
            Exit Sub
        End If
        If TxtId.Text = "" Then
            MsgBox("O registro do pedido ainda não foi salvo.", MsgBoxStyle.Information, "Oxycoat")
            Exit Sub
        End If

        intPergunta = MsgBox("Tem certeza que deseja excluir o pedido " & TxtId.Text & "?",
                             MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Oxycoat")
        If intPergunta <> vbYes Then Exit Sub
        PExcluiVenda()
    End Sub

    Private Sub PExcluiVenda()
        Using con As OleDbConnection = GetConnection()
            Try
                con.Open()
                SQL = "DELETE FROM Tbl_PedidoVenda WHERE id_pedido LIKE '%" & TxtId.Text & "%'"
                Dim cmd As OleDbCommand = New OleDbCommand(SQL, con)
                cmd.ExecuteNonQuery()

                SQL = "DELETE FROM Tbl_DetalhePedidoVenda WHERE id_pedido LIKE '%" & TxtId.Text & "%'"
                Dim cmd1 As OleDbCommand = New OleDbCommand(SQL, con)
                cmd1.ExecuteNonQuery()

                MsgBox("O pedido foi excluído com sucesso.", MsgBoxStyle.Information, "Oxycoat")
                LimpaCampos()
                TxtTotalBase.Clear()
                TxtTotalIpi.Clear()
                TxtTotalIcm.Clear()
                TxtTotalPedido.Clear()
                dgvPedido.DataSource.Clear
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        LimpaCampos()
        TxtProduto.Enabled = False
        btnNovo.Enabled = True
        btnSalvar.Enabled = False
        btnEdita.Enabled = False
        btnCancelar.Enabled = False
        btnExcluir.Enabled = False
        btnConsulta.Enabled = True
        btnImprimir.Enabled = False
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Using frm As New frmRelVenda
            frm.ShowDialog()
        End Using
        Me.Dispose()
    End Sub

    Private Sub GeraParcelas()
        Dim dr As OleDbDataReader = Nothing

        Using con As OleDbConnection = GetConnection()

            Try

                con.Open()

                SQL = "SELECT Tbl_PedidoVenda.id_pedido, Tbl_PrazoPagamentoDetalhe.NDias, Tbl_PedidoVenda.dta_emissao, [dta_emissao]+[NDias] AS Vencimentos, Sum(([Tbl_DetalhePedidoVenda].[total_produto])/[parcelas]) AS TotalProduto, Sum(([total_produto]+([total_produto]*[ipi_prod])/100)) AS TotalPedido, Sum((([total_produto]+([total_produto]*[ipi_prod])/100)*[percent])/100) AS ValorParcela
                FROM ((((Tbl_PedidoVenda INNER JOIN Tbl_DetalhePedidoVenda ON Tbl_PedidoVenda.id_pedido = Tbl_DetalhePedidoVenda.id_pedido) INNER JOIN Tbl_Clientes ON Tbl_PedidoVenda.id_cliente = Tbl_Clientes.id) INNER JOIN Tbl_CondicoesPagamento ON Tbl_Clientes.cond_pag_cli = Tbl_CondicoesPagamento.id_cond_pag) INNER JOIN Tbl_PrazoPagamentoDetalhe ON Tbl_CondicoesPagamento.id_cond_pag = Tbl_PrazoPagamentoDetalhe.CodPrazoPagto) INNER JOIN Tbl_Produto ON Tbl_DetalhePedidoVenda.id_produto = Tbl_Produto.id_prod
                GROUP BY Tbl_PedidoVenda.id_pedido, Tbl_PrazoPagamentoDetalhe.NDias, Tbl_PedidoVenda.dta_emissao, [dta_emissao]+[NDias]
                HAVING Tbl_PedidoVenda.id_pedido LIKE '%" & ID_PEDIDOVENDA & "%'"


                Dim cmd As OleDbCommand = New OleDbCommand(SQL, con)

                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)

                If dr.HasRows Then
                    dr.Read()
                    venc = dr.Item("Vencimentos")
                    vlr = dr.Item("ValorParcela")
                End If
            Catch ex As Exception

            End Try

        End Using
    End Sub

    Public Shared Function GravarParcelas(dgv As DataGridView) As Boolean

        Try
            Using con As OleDbConnection = GetConnection()
                con.Open()

                For Each r As DataGridViewRow In dgv.Rows
                    If r.Cells(0).Value = ID_PEDIDOVENDA Then
                        SQL = "UPDATE Tbl_VencimentosVenda Set id_pedido=@id_pedido, venc_parc=@venc_parc, vlr_parc=@vlr_parc WHERE id_pedido=@id_pedido"
                    Else
                        SQL = "INSERT INTO Tbl_VencimentosVenda (id_pedido, venc_parc, vlr_parc) VALUES (@id_pedido, @venc_parc, @vlr_parc)"
                    End If

                    Using cmd As OleDbCommand = New OleDbCommand(SQL, con)
                        cmd.Parameters.AddWithValue("@id_pedido", r.Cells(ID_PEDIDOVENDA).Value)
                        cmd.Parameters.AddWithValue("@venc_parc", r.Cells(venc).Value)
                        cmd.Parameters.AddWithValue("@vlr_parc", r.Cells(vlr).Value)
                        If r.Cells(0).Value = ID_PEDIDOVENDA Then
                            cmd.Parameters.AddWithValue("@id_pedido", r.Cells(0).Value)
                        End If
                        cmd.ExecuteNonQuery()
                    End Using
                Next

            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Falha: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub PFormataDataGridParcelas()
        With dgvVencimentos

            'Cor do Cabeçalho
            '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            '.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
            'Dados
            .DefaultCellStyle.Font = New Font("Arial", 8)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersWidth = 25       'Largura do seletor lateral

            .Columns(0).HeaderText = "ID Ped."
            .Columns(0).Width = 50
            .Columns(0).Visible = True

            .Columns(1).HeaderText = "Dias"
            .Columns(1).Width = 50
            .Columns(1).Visible = False

            .Columns(2).HeaderText = "Emissão"
            .Columns(2).Width = 50
            .Columns(2).Visible = False

            .Columns(3).HeaderText = "Vencimentos"
            .Columns(3).Width = 120
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(3).Visible = True

            .Columns(4).HeaderText = "Total Produto"
            .Columns(4).Width = 130
            .Columns(4).DefaultCellStyle.Format = "N2"
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).Visible = True

            .Columns(5).HeaderText = "Total Pedido"
            .Columns(5).Width = 100
            .Columns(5).DefaultCellStyle.Format = "N2"
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).Visible = True

            .Columns(6).HeaderText = "Vlr. Parcela"
            .Columns(6).Width = 100
            .Columns(6).DefaultCellStyle.Format = "N2"
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).Visible = True
        End With

    End Sub

    Private Sub btnGerarCobranca_Click(sender As Object, e As EventArgs) Handles btnGerarCobranca.Click
        GravarParcelas(dgvVencimentos)
        GeraParcelas()
        MsgBox("Parcelas Geradas")
    End Sub
End Class