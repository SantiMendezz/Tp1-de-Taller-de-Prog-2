Public Class Form1
    Dim nombre, apellido As String

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TBCompleto.Clear()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim concatenar As String
        nombre = TBNombre.Text
        apellido = TBApellido.Text
        concatenar = nombre & " " & apellido
        TBCompleto.Text = concatenar
    End Sub
End Class
