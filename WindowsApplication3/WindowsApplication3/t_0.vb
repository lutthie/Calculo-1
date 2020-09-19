Public Class t_0

    'RESTRINGIENDO TEXTBOX (SOLO NUMEROS)
    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        'NUMEROS
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
            'TECLA DE CONTROL
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
            'SEPARADOR
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
            'NEGATIVOS
        ElseIf Asc(e.KeyChar) = 45 Then 'alt+45 = -
            e.Handled = False
            'ALFABETO
        Else
            e.Handled = True
        End If
    End Sub

    'DERIVADA
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = "" Then
            MsgBox("Ingrese un valor.", vbOKOnly, "Error")
        Else
            BunifuMetroTextbox2.Text = "f'(x) = 0"
        End If
    End Sub

    'LIMPIAR TEXTBOX2
    Private Sub BunifuMetroTextbox1_Click(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
        If BunifuMetroTextbox1.Text = "" Then
            'DO NOTHING
        Else
            BunifuMetroTextbox2.Text = ""
        End If
    End Sub

    'BOTON SALIR
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuMetroTextbox1.Text = ""
        BunifuMetroTextbox2.Text = ""
        BunifuMetroTextbox1.Focus()
        Me.Hide()
    End Sub

End Class