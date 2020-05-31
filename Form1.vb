Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim PrecioUnitario, Cantidad As Integer
        Dim Descuento, Subtotal, Total As Double
        Dim aplicaDescuento As Boolean

        If txt.Numero.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)

        ElseIf Not IsNumeric(textNumero.Text) Then
            MsgBox("Escriba un valor numerico", vbInformation)
            txtNumero.Text = ""

        ElseIf IsNumeric(PrecioUnitario) Then
            PrecioUnitario = Val(txtPreciounitario.Text)

        ElseIf IsNumeric(Cantidad) Then
            Cantidad = Val(txtCantidad.Text)

        ElseIf CBprivilegio.Text = "" Then
            MsgBox("Casilla vacia ingrese un valor")

        End If
        If PrecioUnitario < 0 Then
            MsgBox("Numero negativo")

        ElseIf Cantidad < 0 Then
            MsgBox("Numero negativo")
        End If
        If txtPrecioUnitario.Text = "" Then
            MsgBox("Ingrese un precio")

        ElseIf txtCantidad.Text = "" Then
            MsgBox("ingrese una cantidad")

        ElseIf CBprivilegio.Text = "" Then
            MsgBox("Casilla vacia ingrese un valor")
        End If


        Subtotal = PrecioUnitario * Cantidad
        If aplicaDescuento = True Then
            Descuento = Subtotal * 0.05
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Bloquear checkbox en caso de no ser elegido
        If CheckBox1.Checked = True Then
            CheckBox1.Enabled = False
        ElseIf CheckBox1.Enabled = True Then

        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'Bloquear checkbox en caso de no ser elegido
        If CheckBox2.Checked = True Then
            CheckBox2.Checked = False
        ElseIf CheckBox2.Enabled = True Then
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Descuento
        ComboBox1.Items.Add("Tercera Edad")
        ComboBox1.Items.Add("Estudiante")
        ComboBox1.Items.Add("Promocional")
        ComboBox1.Items.Add("Por Cantidad")
        ComboBox1.Items.Add("Empleado")
        ComboBox1.Items.Add("Por temporada")

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        'Impuesto
        ComboBox2.Items.Add("15%")
        ComboBox2.Items.Add("17%")
    End Sub



    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated

    End Sub
End Class