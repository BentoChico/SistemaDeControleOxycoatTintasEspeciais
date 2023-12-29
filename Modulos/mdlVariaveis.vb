Module mdlVariaveis
    Public venc As String
    Public vlr As String
    Public datainicio As String
    Public datafim As String

    Public status As String

    Public SQL As String
    Public _IDDETALHEPRODCLI As String
    Public _IDDETALHE As String
    Public _IDPROD As String
    Public _IDFORMULA As String
    Public _IDETAPA As Integer
    Public _ITEN As String
    Public _IDMP As String
    Public _QTDEFORMULA As String
    Public _PE As String
    Public _NV As String
    Public _CODMP As String
    Public _CUSTODMP As String
    Public _IDDETALHEPROCESSO As String

    Public ID_PEDIDOVENDA As String
    Public ID_PEDIDOCOMPRA As String
    Public ID_CLIENTE As String
    Public ID_FORNECEDOR As String
    Public ID_PRAZO As String
    Public DIAS_1 As Integer
    Public DIAS_2 As Integer
    Public DIAS_3 As Integer
    Public _NDias As Integer
    Public _ICMS As String
    Public _IPI As String
    Public _PIS As String
    Public _COFINS As String
    Public _CSLL As String
    Public _IRPJ As String
    Public _ISS As String

    Public _Vpis As String
    Public _Vcofins As String
    Public _calcCSL As String
    Public _Vcsl As String
    Public _Virpj As String
    Public _Viss As String
    Public _VTotalcmv As String
    Public _VComis As String

    Public _PARCELAS As Integer
    Public NDias As Integer
    Public _Custos As Double
    Public _percencustos As Double
    Public _Faturamento As Double

    Public ID_CENTROCUSTO As Integer

    Public _IDPAG As Integer

    Public _IDTIPOESPEC As Integer
    Public _IDDETBOLETIN As Integer
    Public _IDBOLETIN As Integer

    Public _IDOP As String
    Public _IDESPEC As String
    Public _IDLAUDO As String

    Public _PERDAPROCESSO As String
    Public _TOTALPERDA As String

    Public Declare Function GetSystemMenu Lib "user32" (a As Integer, b As Integer) As Integer
    Public Declare Function RemoveMenu Lib "user32" (a As Integer, b As Integer, c As Integer) As Integer
    Public Const SC_CLOSE = &HF060&
    Public Const MF_BYCOMMAND = &H0&

    Public Function RemoveXButton(e As Integer) As Integer
        Dim f As Integer
        f = GetSystemMenu(e, False)
        Return RemoveMenu(f, SC_CLOSE, MF_BYCOMMAND)
    End Function

    Public Campo(10) As String

    Public Function Moeda(ByVal txt As TextBox)
        Dim n As String = String.Empty
        Dim v As Double = 0
        Try
            n = txt.Text.Replace(",", "").Replace(".", "")
            If n.Equals("") Then n = ""
            n = n.PadLeft(3, "0")
            If n.Length > 3 And n.Substring(0, 1) = "0" Then n = n.Substring(1, n.Length - 1)
            v = Convert.ToDouble(n) / 100
            txt.Text = String.Format("{0:N}", v)
            txt.SelectionStart = txt.Text.Length
        Catch ex As Exception

        End Try
        Return True
    End Function
End Module
