Imports System.Data.OleDb

Module mdlConecta
    Public intPergunta As Integer
    Public Function GetConnection() As OleDbConnection
        'Obtem a string de conexão
        'Dim caminhoBD As String = "|DataDirectory|\dbconecta.accdb"
        'Dim strConexao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminhoBD & ";Jet OLEDB:Database Password=dbconecta!@#)(*"

        Dim strConexao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema de Controle Oxycoat Tintas Especiais\BD\dbDados.accdb;Persist Security Info=True;Jet OLEDB:Database Password=dbconecta!@#)(*"
        'Dim strConexao As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Settings.ConexaoBanco
        'Retorna uma conexão.
        Return New OleDbConnection(strConexao)
    End Function
End Module
