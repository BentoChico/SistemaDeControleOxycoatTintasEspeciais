<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelVenda
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelVenda))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetBanco = New Sistema_de_Controle_Oxycoat_Tintas_Especiais.DataSetBanco()
        Me.qryVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryVendaTableAdapter = New Sistema_de_Controle_Oxycoat_Tintas_Especiais.DataSetBancoTableAdapters.qryVendaTableAdapter()
        Me.qryDetalheVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryDetalheVendaTableAdapter = New Sistema_de_Controle_Oxycoat_Tintas_Especiais.DataSetBancoTableAdapters.qryDetalheVendaTableAdapter()
        Me.qryParcelasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.qryParcelasTableAdapter = New Sistema_de_Controle_Oxycoat_Tintas_Especiais.DataSetBancoTableAdapters.qryParcelasTableAdapter()
        CType(Me.DataSetBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qryVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qryDetalheVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qryParcelasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "DataSetVenda"
        ReportDataSource4.Value = Me.qryVendaBindingSource
        ReportDataSource5.Name = "DataSetItenVenda"
        ReportDataSource5.Value = Me.qryDetalheVendaBindingSource
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.qryParcelasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_de_Controle_Oxycoat_Tintas_Especiais.rptPedidoVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetBanco
        '
        Me.DataSetBanco.DataSetName = "DataSetBanco"
        Me.DataSetBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'qryVendaBindingSource
        '
        Me.qryVendaBindingSource.DataMember = "qryVenda"
        Me.qryVendaBindingSource.DataSource = Me.DataSetBanco
        '
        'qryVendaTableAdapter
        '
        Me.qryVendaTableAdapter.ClearBeforeFill = True
        '
        'qryDetalheVendaBindingSource
        '
        Me.qryDetalheVendaBindingSource.DataMember = "qryDetalheVenda"
        Me.qryDetalheVendaBindingSource.DataSource = Me.DataSetBanco
        '
        'qryDetalheVendaTableAdapter
        '
        Me.qryDetalheVendaTableAdapter.ClearBeforeFill = True
        '
        'qryParcelasBindingSource
        '
        Me.qryParcelasBindingSource.DataMember = "qryParcelas"
        Me.qryParcelasBindingSource.DataSource = Me.DataSetBanco
        '
        'qryParcelasTableAdapter
        '
        Me.qryParcelasTableAdapter.ClearBeforeFill = True
        '
        'frmRelVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRelVenda"
        Me.Text = "Pedido de Venda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSetBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qryVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qryDetalheVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qryParcelasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents qryVendaBindingSource As BindingSource
    Friend WithEvents DataSetBanco As DataSetBanco
    Friend WithEvents qryDetalheVendaBindingSource As BindingSource
    Friend WithEvents qryParcelasBindingSource As BindingSource
    Friend WithEvents qryVendaTableAdapter As DataSetBancoTableAdapters.qryVendaTableAdapter
    Friend WithEvents qryDetalheVendaTableAdapter As DataSetBancoTableAdapters.qryDetalheVendaTableAdapter
    Friend WithEvents qryParcelasTableAdapter As DataSetBancoTableAdapters.qryParcelasTableAdapter
End Class
