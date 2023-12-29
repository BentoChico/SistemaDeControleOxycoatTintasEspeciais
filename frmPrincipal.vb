Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTempo.Text = DateTime.Now
    End Sub

    Private Sub EncerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarToolStripMenuItem.Click
        End
    End Sub
    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Shell("calc.exe", vbNormalFocus)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BlocoDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeNotasToolStripMenuItem.Click
        Try
            Shell("notepad.exe", vbNormalFocus)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PedidoDeVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoDeVendaToolStripMenuItem.Click
        Using frm As New frmPedidoVenda
            frm.ShowDialog()
        End Using
    End Sub
End Class
