Public Class GenProGeo
    Private Sub BT_CalcDatos_Click(sender As Object, e As EventArgs) Handles BT1_CalcDatos.Click
        Dim x, n, num As Integer
        Dim r As Single

        'Datos que vendran de los TEXTBOXES'
        x = TB1_PrimerNumero.Text
        r = TB2_RadioComun.Text
        num = TB3_NoTerminos.Text

        'Datos que se mostraran en el LISTBOX'
        LBOX1_VistaGenerada.Items.Add("n" & vbTab & "x")
        LBOX1_VistaGenerada.Items.Add("_______________")

        'Proceso del como se crean los calculos'
        n = 1
        Do
            x = x * r
            LBOX1_VistaGenerada.Items.Add(n & vbTab & x)
            n = n + 1

        Loop Until n = num + 1

    End Sub
End Class
