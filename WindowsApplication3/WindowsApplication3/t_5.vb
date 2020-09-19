Public Class t_5

    'BOTON CALCULAR
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim res As Double
        Dim mul As Double

        BunifuCustomLabel13.Show()

        If BunifuMetroTextbox1.Text = "" And BunifuMetroTextbox2.Text = "" Then
            '4,5,11
            BunifuMetroTextbox4.Text = ""
            BunifuMetroTextbox5.Text = ""
            BunifuCustomLabel11.Hide()
        Else
            a = BunifuMetroTextbox1.Text
            b = BunifuMetroTextbox2.Text
            c = BunifuMetroTextbox3.Text


            mul = a * b
            res = b - 1

            BunifuMetroTextbox4.Text = mul

            If res = 0 Then
                BunifuCustomLabel11.Hide()
                BunifuMetroTextbox5.Text = ""

            Else
                BunifuCustomLabel11.Show()
                BunifuMetroTextbox5.Text = res

            End If
        End If


        'SEN c(X)
        If Not BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox6.Text = BunifuMetroTextbox3.Text
            BunifuMetroTextbox7.Text = BunifuMetroTextbox3.Text
        Else
            BunifuMetroTextbox6.Text = ""
            BunifuMetroTextbox7.Text = ""
        End If
    End Sub

    'CAMBIAR LABEL MAS/MENOS
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                BunifuCustomLabel12.Text = "-"
            Case 1
                BunifuCustomLabel12.Text = "+"
        End Select
    End Sub

    'BOTON SALIR
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BunifuMetroTextbox1.Text = ""
        BunifuMetroTextbox2.Text = ""
        BunifuMetroTextbox3.Text = ""
        BunifuMetroTextbox4.Text = ""
        BunifuMetroTextbox5.Text = ""
        BunifuMetroTextbox6.Text = ""
        BunifuMetroTextbox7.Text = ""
        BunifuCustomLabel12.Text = "±"
        BunifuCustomLabel13.Hide()
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

    'TEXTBOX5 NUMERICO
    Private Sub BunifuMetroTextbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox5.KeyPress
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

    'TEXTBOX6 NUMERICO
    Private Sub BunifuMetroTextbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox6.KeyPress
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

    'OCULTANDO LABEL
    Private Sub t_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomLabel13.Hide()
    End Sub

End Class