<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoVenda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPedidoVenda))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdita = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFechar = New System.Windows.Forms.ToolStripButton()
        Me.btnConsulta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtCondicoes = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTransporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNumPedido = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.mskDataCad = New System.Windows.Forms.MaskedTextBox()
        Me.TxtContato = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtRepresentante = New System.Windows.Forms.TextBox()
        Me.mskCelCli = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mskTelCli = New System.Windows.Forms.MaskedTextBox()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtBairro = New System.Windows.Forms.TextBox()
        Me.TxtCidade = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tcPedido = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTotalIpi = New System.Windows.Forms.TextBox()
        Me.TxtTotalIcm = New System.Windows.Forms.TextBox()
        Me.TxtTotalBase = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtTotalPedido = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtQtde = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIten = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtPrcVenda = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvRelacaoProdutoCliente = New System.Windows.Forms.DataGridView()
        Me.btnVizualizar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtPesquisarNomes = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvListaPedidos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPesquisaGeral = New System.Windows.Forms.Button()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.dgvVencimentos = New System.Windows.Forms.DataGridView()
        Me.btnGerarCobranca = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tcPedido.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRelacaoProdutoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvListaPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvVencimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 60)
        Me.Panel1.TabIndex = 182
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(70, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 29)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Pedido de Venda"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.ToolStripSeparator5, Me.btnSalvar, Me.ToolStripSeparator6, Me.btnEdita, Me.ToolStripSeparator1, Me.btnExcluir, Me.ToolStripSeparator7, Me.btnCancelar, Me.ToolStripSeparator8, Me.btnFechar, Me.btnConsulta, Me.ToolStripSeparator2, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 60)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(987, 32)
        Me.ToolStrip1.TabIndex = 178
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(61, 29)
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(97, 29)
        Me.btnSalvar.Text = "&Salvar/Editar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 32)
        '
        'btnEdita
        '
        Me.btnEdita.Image = CType(resources.GetObject("btnEdita.Image"), System.Drawing.Image)
        Me.btnEdita.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEdita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdita.Name = "btnEdita"
        Me.btnEdita.Size = New System.Drawing.Size(66, 29)
        Me.btnEdita.Text = "&Editar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(63, 29)
        Me.btnExcluir.Text = "&Excluir"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 32)
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(74, 29)
        Me.btnCancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 32)
        '
        'btnFechar
        '
        Me.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnFechar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(70, 29)
        Me.btnFechar.Text = "&Fechar"
        '
        'btnConsulta
        '
        Me.btnConsulta.Image = CType(resources.GetObject("btnConsulta.Image"), System.Drawing.Image)
        Me.btnConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(87, 29)
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(82, 29)
        Me.btnImprimir.Text = "Imprimir"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtCondicoes)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TxtTransporte)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxtId)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.cboStatus)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TxtNumPedido)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.mskDataCad)
        Me.Panel3.Controls.Add(Me.TxtContato)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.TxtRepresentante)
        Me.Panel3.Controls.Add(Me.mskCelCli)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.mskTelCli)
        Me.Panel3.Controls.Add(Me.cboCliente)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.TxtEndereco)
        Me.Panel3.Controls.Add(Me.txtUf)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TxtBairro)
        Me.Panel3.Controls.Add(Me.TxtCidade)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(6, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(960, 137)
        Me.Panel3.TabIndex = 183
        '
        'TxtCondicoes
        '
        Me.TxtCondicoes.Enabled = False
        Me.TxtCondicoes.Location = New System.Drawing.Point(305, 110)
        Me.TxtCondicoes.Name = "TxtCondicoes"
        Me.TxtCondicoes.Size = New System.Drawing.Size(291, 20)
        Me.TxtCondicoes.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Condições de Venda"
        '
        'TxtTransporte
        '
        Me.TxtTransporte.Enabled = False
        Me.TxtTransporte.Location = New System.Drawing.Point(8, 110)
        Me.TxtTransporte.Name = "TxtTransporte"
        Me.TxtTransporte.Size = New System.Drawing.Size(291, 20)
        Me.TxtTransporte.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Transportadora"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(602, 110)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(350, 20)
        Me.TxtId.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(625, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"ABERTO", "FECHADO"})
        Me.cboStatus.Location = New System.Drawing.Point(628, 25)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 45
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(599, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(18, 13)
        Me.Label28.TabIndex = 75
        Me.Label28.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "N.º Pedido"
        '
        'TxtNumPedido
        '
        Me.TxtNumPedido.Location = New System.Drawing.Point(453, 26)
        Me.TxtNumPedido.Name = "TxtNumPedido"
        Me.TxtNumPedido.Size = New System.Drawing.Size(94, 20)
        Me.TxtNumPedido.TabIndex = 43
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(613, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Contato"
        '
        'mskDataCad
        '
        Me.mskDataCad.Enabled = False
        Me.mskDataCad.Location = New System.Drawing.Point(553, 26)
        Me.mskDataCad.Mask = "00/00/0000"
        Me.mskDataCad.Name = "mskDataCad"
        Me.mskDataCad.Size = New System.Drawing.Size(69, 20)
        Me.mskDataCad.TabIndex = 42
        '
        'TxtContato
        '
        Me.TxtContato.Enabled = False
        Me.TxtContato.Location = New System.Drawing.Point(616, 66)
        Me.TxtContato.Name = "TxtContato"
        Me.TxtContato.Size = New System.Drawing.Size(135, 20)
        Me.TxtContato.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(550, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Dta. Cadastro"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(856, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Celular"
        '
        'TxtRepresentante
        '
        Me.TxtRepresentante.Enabled = False
        Me.TxtRepresentante.Location = New System.Drawing.Point(756, 26)
        Me.TxtRepresentante.Name = "TxtRepresentante"
        Me.TxtRepresentante.Size = New System.Drawing.Size(196, 20)
        Me.TxtRepresentante.TabIndex = 53
        '
        'mskCelCli
        '
        Me.mskCelCli.Enabled = False
        Me.mskCelCli.Location = New System.Drawing.Point(859, 66)
        Me.mskCelCli.Mask = "(99) 00000-0000"
        Me.mskCelCli.Name = "mskCelCli"
        Me.mskCelCli.Size = New System.Drawing.Size(93, 20)
        Me.mskCelCli.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Cliente"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(757, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Telefone"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(753, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Representante"
        '
        'mskTelCli
        '
        Me.mskTelCli.Enabled = False
        Me.mskTelCli.Location = New System.Drawing.Point(760, 66)
        Me.mskTelCli.Mask = "(99) 0000-0000"
        Me.mskTelCli.Name = "mskTelCli"
        Me.mskTelCli.Size = New System.Drawing.Size(93, 20)
        Me.mskTelCli.TabIndex = 64
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(8, 26)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(439, 21)
        Me.cboCliente.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(562, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "UF"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Enabled = False
        Me.TxtEndereco.Location = New System.Drawing.Point(8, 66)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(216, 20)
        Me.TxtEndereco.TabIndex = 55
        '
        'txtUf
        '
        Me.txtUf.Enabled = False
        Me.txtUf.Location = New System.Drawing.Point(565, 66)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(45, 20)
        Me.txtUf.TabIndex = 61
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Endereço"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(402, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Cidade"
        '
        'TxtBairro
        '
        Me.TxtBairro.Enabled = False
        Me.TxtBairro.Location = New System.Drawing.Point(230, 66)
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Size = New System.Drawing.Size(169, 20)
        Me.TxtBairro.TabIndex = 57
        '
        'TxtCidade
        '
        Me.TxtCidade.Enabled = False
        Me.TxtCidade.Location = New System.Drawing.Point(405, 66)
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Size = New System.Drawing.Size(154, 20)
        Me.TxtCidade.TabIndex = 59
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(227, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Bairro"
        '
        'tcPedido
        '
        Me.tcPedido.Controls.Add(Me.TabPage1)
        Me.tcPedido.Controls.Add(Me.TabPage2)
        Me.tcPedido.Controls.Add(Me.TabPage3)
        Me.tcPedido.Controls.Add(Me.TabPage4)
        Me.tcPedido.Location = New System.Drawing.Point(4, 100)
        Me.tcPedido.Name = "tcPedido"
        Me.tcPedido.SelectedIndex = 0
        Me.tcPedido.Size = New System.Drawing.Size(980, 442)
        Me.tcPedido.TabIndex = 184
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabPage1.Controls.Add(Me.btnGerarCobranca)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.TxtTotalIpi)
        Me.TabPage1.Controls.Add(Me.TxtTotalIcm)
        Me.TabPage1.Controls.Add(Me.TxtTotalBase)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.TxtTotalPedido)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(972, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados do Pedido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(418, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Valor do ICMS"
        '
        'TxtTotalIpi
        '
        Me.TxtTotalIpi.Enabled = False
        Me.TxtTotalIpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalIpi.Location = New System.Drawing.Point(215, 378)
        Me.TxtTotalIpi.Name = "TxtTotalIpi"
        Me.TxtTotalIpi.Size = New System.Drawing.Size(172, 29)
        Me.TxtTotalIpi.TabIndex = 187
        '
        'TxtTotalIcm
        '
        Me.TxtTotalIcm.Enabled = False
        Me.TxtTotalIcm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalIcm.Location = New System.Drawing.Point(421, 378)
        Me.TxtTotalIcm.Name = "TxtTotalIcm"
        Me.TxtTotalIcm.Size = New System.Drawing.Size(172, 29)
        Me.TxtTotalIcm.TabIndex = 189
        '
        'TxtTotalBase
        '
        Me.TxtTotalBase.Enabled = False
        Me.TxtTotalBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalBase.Location = New System.Drawing.Point(6, 378)
        Me.TxtTotalBase.Name = "TxtTotalBase"
        Me.TxtTotalBase.Size = New System.Drawing.Size(172, 29)
        Me.TxtTotalBase.TabIndex = 185
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(212, 362)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 188
        Me.Label20.Text = "Valor do IPI"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 362)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 13)
        Me.Label22.TabIndex = 186
        Me.Label22.Text = "Base de Calculo"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(626, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 13)
        Me.Label23.TabIndex = 192
        Me.Label23.Text = "Total do Pedido"
        '
        'TxtTotalPedido
        '
        Me.TxtTotalPedido.Enabled = False
        Me.TxtTotalPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPedido.Location = New System.Drawing.Point(629, 378)
        Me.TxtTotalPedido.Name = "TxtTotalPedido"
        Me.TxtTotalPedido.Size = New System.Drawing.Size(172, 29)
        Me.TxtTotalPedido.TabIndex = 191
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(6, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(960, 203)
        Me.Panel2.TabIndex = 184
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dgvPedido)
        Me.Panel4.Controls.Add(Me.TxtProduto)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtQtde)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.TxtIten)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TxtCodigo)
        Me.Panel4.Controls.Add(Me.TxtPrcVenda)
        Me.Panel4.Location = New System.Drawing.Point(6, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(947, 179)
        Me.Panel4.TabIndex = 83
        '
        'dgvPedido
        '
        Me.dgvPedido.AllowUserToAddRows = False
        Me.dgvPedido.AllowUserToDeleteRows = False
        Me.dgvPedido.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.excluir})
        Me.dgvPedido.Location = New System.Drawing.Point(8, 49)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.ReadOnly = True
        Me.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedido.Size = New System.Drawing.Size(934, 125)
        Me.dgvPedido.TabIndex = 82
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.Name = "excluir"
        Me.excluir.ReadOnly = True
        '
        'TxtProduto
        '
        Me.TxtProduto.Enabled = False
        Me.TxtProduto.Location = New System.Drawing.Point(8, 23)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(391, 20)
        Me.TxtProduto.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(845, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Qtde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Produto"
        '
        'TxtQtde
        '
        Me.TxtQtde.Enabled = False
        Me.TxtQtde.Location = New System.Drawing.Point(848, 23)
        Me.TxtQtde.Name = "TxtQtde"
        Me.TxtQtde.Size = New System.Drawing.Size(87, 20)
        Me.TxtQtde.TabIndex = 47
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(733, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(25, 13)
        Me.Label30.TabIndex = 80
        Me.Label30.Text = "Iten"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(595, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Preço de Venda"
        '
        'TxtIten
        '
        Me.TxtIten.Enabled = False
        Me.TxtIten.Location = New System.Drawing.Point(733, 23)
        Me.TxtIten.Name = "TxtIten"
        Me.TxtIten.Size = New System.Drawing.Size(93, 20)
        Me.TxtIten.TabIndex = 79
        Me.TxtIten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(420, 23)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(155, 20)
        Me.TxtCodigo.TabIndex = 34
        '
        'TxtPrcVenda
        '
        Me.TxtPrcVenda.Enabled = False
        Me.TxtPrcVenda.Location = New System.Drawing.Point(598, 23)
        Me.TxtPrcVenda.Name = "TxtPrcVenda"
        Me.TxtPrcVenda.Size = New System.Drawing.Size(110, 20)
        Me.TxtPrcVenda.TabIndex = 35
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(972, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Produtos do Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvRelacaoProdutoCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 192)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Produtos do Cliente"
        '
        'dgvRelacaoProdutoCliente
        '
        Me.dgvRelacaoProdutoCliente.AllowUserToAddRows = False
        Me.dgvRelacaoProdutoCliente.AllowUserToDeleteRows = False
        Me.dgvRelacaoProdutoCliente.AllowUserToResizeColumns = False
        Me.dgvRelacaoProdutoCliente.AllowUserToResizeRows = False
        Me.dgvRelacaoProdutoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRelacaoProdutoCliente.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvRelacaoProdutoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRelacaoProdutoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRelacaoProdutoCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnVizualizar})
        Me.dgvRelacaoProdutoCliente.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelacaoProdutoCliente.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRelacaoProdutoCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRelacaoProdutoCliente.EnableHeadersVisualStyles = False
        Me.dgvRelacaoProdutoCliente.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvRelacaoProdutoCliente.Location = New System.Drawing.Point(3, 16)
        Me.dgvRelacaoProdutoCliente.Name = "dgvRelacaoProdutoCliente"
        Me.dgvRelacaoProdutoCliente.ReadOnly = True
        Me.dgvRelacaoProdutoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRelacaoProdutoCliente.Size = New System.Drawing.Size(954, 173)
        Me.dgvRelacaoProdutoCliente.TabIndex = 11
        '
        'btnVizualizar
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.btnVizualizar.DefaultCellStyle = DataGridViewCellStyle5
        Me.btnVizualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVizualizar.HeaderText = "Opção"
        Me.btnVizualizar.Name = "btnVizualizar"
        Me.btnVizualizar.ReadOnly = True
        Me.btnVizualizar.Text = "Vizualizar"
        Me.btnVizualizar.UseColumnTextForButtonValue = True
        Me.btnVizualizar.Width = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIdCliente)
        Me.GroupBox1.Controls.Add(Me.txtPesquisarNomes)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(957, 50)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa Descrição..."
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(857, 20)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdCliente.TabIndex = 41
        '
        'txtPesquisarNomes
        '
        Me.txtPesquisarNomes.Location = New System.Drawing.Point(6, 20)
        Me.txtPesquisarNomes.Name = "txtPesquisarNomes"
        Me.txtPesquisarNomes.Size = New System.Drawing.Size(845, 20)
        Me.txtPesquisarNomes.TabIndex = 40
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabPage3.Controls.Add(Me.dgvVencimentos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(972, 416)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Vencimentos"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(972, 416)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Consulta Pedidos Emitidos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvListaPedidos)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(953, 348)
        Me.GroupBox4.TabIndex = 146
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lista de Vendas Cadastrados"
        '
        'dgvListaPedidos
        '
        Me.dgvListaPedidos.AllowUserToAddRows = False
        Me.dgvListaPedidos.AllowUserToDeleteRows = False
        Me.dgvListaPedidos.AllowUserToResizeColumns = False
        Me.dgvListaPedidos.AllowUserToResizeRows = False
        Me.dgvListaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListaPedidos.BackgroundColor = System.Drawing.Color.PaleGoldenrod
        Me.dgvListaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewButtonColumn1})
        Me.dgvListaPedidos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPedidos.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListaPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaPedidos.EnableHeadersVisualStyles = False
        Me.dgvListaPedidos.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvListaPedidos.Location = New System.Drawing.Point(3, 16)
        Me.dgvListaPedidos.Name = "dgvListaPedidos"
        Me.dgvListaPedidos.ReadOnly = True
        Me.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaPedidos.Size = New System.Drawing.Size(947, 329)
        Me.dgvListaPedidos.TabIndex = 11
        '
        'DataGridViewButtonColumn1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewButtonColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataGridViewButtonColumn1.HeaderText = "Opção"
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.ReadOnly = True
        Me.DataGridViewButtonColumn1.Text = "Vizualizar"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 45
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPesquisaGeral)
        Me.GroupBox3.Controls.Add(Me.TxtPesquisa)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(950, 50)
        Me.GroupBox3.TabIndex = 145
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pesquisa Razão Social..."
        '
        'btnPesquisaGeral
        '
        Me.btnPesquisaGeral.Image = CType(resources.GetObject("btnPesquisaGeral.Image"), System.Drawing.Image)
        Me.btnPesquisaGeral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisaGeral.Location = New System.Drawing.Point(835, 16)
        Me.btnPesquisaGeral.Name = "btnPesquisaGeral"
        Me.btnPesquisaGeral.Size = New System.Drawing.Size(96, 27)
        Me.btnPesquisaGeral.TabIndex = 82
        Me.btnPesquisaGeral.Text = "Geral"
        Me.btnPesquisaGeral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisaGeral.UseVisualStyleBackColor = True
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(6, 20)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(804, 20)
        Me.TxtPesquisa.TabIndex = 40
        '
        'dgvVencimentos
        '
        Me.dgvVencimentos.AllowUserToAddRows = False
        Me.dgvVencimentos.AllowUserToDeleteRows = False
        Me.dgvVencimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVencimentos.Location = New System.Drawing.Point(14, 14)
        Me.dgvVencimentos.Name = "dgvVencimentos"
        Me.dgvVencimentos.ReadOnly = True
        Me.dgvVencimentos.Size = New System.Drawing.Size(432, 150)
        Me.dgvVencimentos.TabIndex = 73
        '
        'btnGerarCobranca
        '
        Me.btnGerarCobranca.Image = CType(resources.GetObject("btnGerarCobranca.Image"), System.Drawing.Image)
        Me.btnGerarCobranca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGerarCobranca.Location = New System.Drawing.Point(822, 378)
        Me.btnGerarCobranca.Name = "btnGerarCobranca"
        Me.btnGerarCobranca.Size = New System.Drawing.Size(144, 29)
        Me.btnGerarCobranca.TabIndex = 193
        Me.btnGerarCobranca.Text = "Gerar Vencimentos"
        Me.btnGerarCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGerarCobranca.UseVisualStyleBackColor = True
        '
        'frmPedidoVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(987, 549)
        Me.Controls.Add(Me.tcPedido)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPedidoVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido de Venda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.tcPedido.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvRelacaoProdutoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvListaPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvVencimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnEdita As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents btnCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents btnFechar As ToolStripButton
    Friend WithEvents btnConsulta As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnImprimir As ToolStripButton
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumPedido As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents mskDataCad As MaskedTextBox
    Friend WithEvents TxtContato As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtRepresentante As TextBox
    Friend WithEvents mskCelCli As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents mskTelCli As MaskedTextBox
    Friend WithEvents cboCliente As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents txtUf As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtBairro As TextBox
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tcPedido As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvRelacaoProdutoCliente As DataGridView
    Friend WithEvents btnVizualizar As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents txtPesquisarNomes As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvListaPedidos As DataGridView
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPesquisaGeral As Button
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents TxtCondicoes As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTransporte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtTotalIpi As TextBox
    Friend WithEvents TxtTotalIcm As TextBox
    Friend WithEvents TxtTotalBase As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtTotalPedido As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvPedido As DataGridView
    Friend WithEvents excluir As DataGridViewImageColumn
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TxtIten As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtPrcVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtQtde As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvVencimentos As DataGridView
    Friend WithEvents btnGerarCobranca As Button
End Class
