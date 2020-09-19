Public Class t_3

    'CALCULAR
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim d As Double
        Dim res As Double
        Dim sus As Double
        Dim mul As Double
        Dim por As Double

        a = BunifuMetroTextbox1.Text
        b = BunifuMetroTextbox2.Text
        c = BunifuMetroTextbox3.Text
        d = BunifuMetroTextbox4.Text

        If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" And BunifuMetroTextbox3.Text = "" And BunifuMetroTextbox4.Text = "" Then
            MsgBox("Ingrese un valor.", vbOKOnly, "Error")
        Else
            mul = a * b
            res = b - 1

            por = c * d
            sus = d - 1

            BunifuMetroTextbox6.Text = mul
            BunifuMetroTextbox8.Text = por
            If res = 0 Then
                'BunifuCustomLabel12.Hide()
                BunifuMetroTextbox5.Text = ""
                BunifuMetroTextbox7.Text = ""
            Else
                'BunifuCustomLabel7.Show()
                BunifuMetroTextbox5.Text = res
                BunifuMetroTextbox7.Text = sus
            End If
        End If
    End Sub

    'COMBOBOX
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                BunifuCustomLabel14.Text = "+"
            Case 1
                BunifuCustomLabel14.Text = "-"
        End Select
    End Sub

    'SALIR
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuMetroTextbox1.Text = ""
        BunifuMetroTextbox2.Text = ""
        BunifuMetroTextbox3.Text = ""
        BunifuMetroTextbox4.Text = ""
        BunifuMetroTextbox5.Text = ""
        BunifuMetroTextbox6.Text = ""
        BunifuMetroTextbox7.Text = ""
        BunifuMetroTextbox8.Text = ""
        BunifuCustomLabel14.Text = "±"
        BunifuMetroTextbox1.Focus()
        Me.Hide()
    End Sub

    'TEXTBOX1 NUMERICO
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

    'TEXTBOX2 NUMERICO
    Private Sub BunifuMetroTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
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

    'TEXTBOX3 NUMERICO
    Private Sub BunifuMetroTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox3.KeyPress
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

    'TEXTBOX4 NUMERICO
    Private Sub BunifuMetroTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox4.KeyPress
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

End Class