Public Class FrmClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ArfinDS.Clientes_ARFIN' Puede moverla o quitarla según sea necesario.
        Me.Clientes_ARFINTableAdapter.Fill(Me.ArfinDS.Clientes_ARFIN)

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            Me.Clientes_ARFINBindingSource.EndEdit()
            Me.Clientes_ARFINTableAdapter.Update(Me.ArfinDS.Clientes_ARFIN)
            Me.ArfinDS.GetChanges()
            MsgBox("Actualización existosa...",, "")
        Catch ex As Exception
            MsgBox("Actualización fallida..." + vbNewLine + ex.ToString,, "")
        End Try
    End Sub

    Private Sub FrmClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Me.Clientes_ARFINTableAdapter.FillBy(Me.ArfinDS.Clientes_ARFIN, txtBuscar.Text)
            Me.RFCTextBox.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Me.Clientes_ARFINTableAdapter.FillBy(Me.ArfinDS.Clientes_ARFIN, txtBuscar.Text)
                Me.RFCTextBox.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class