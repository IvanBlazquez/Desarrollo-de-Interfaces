Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To Cont - 1
            Dim emp As Empleado = Tabla(i)
            If Emp.DNI = txtDNI.Text Then
                txtNombre.Text = Emp.Nombre
                txtApellido.Text = Emp.Apellido
                Emp.Horas += CInt(txtHoras.Text)
                txtHoras.Text = Emp.Horas.ToString
                Exit Sub
            End If
        Next
        ReDim Preserve Tabla(Cont)
        With Tabla(Cont)
            .Nombre = InputBox("Nombre")
            txtNombre.Text = .Nombre
            .Apellido = InputBox("Apellido")
            txtApellido.Text = .Apellido
            .DNI = txtDNI.Text
            .Horas = CInt(txtHoras.Text)
        End With

        Cont += 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Using salida As New StreamWriter("SALIDA.TXT")
            salida.WriteLine("{0,10}  {1,20}  {2,20}  {3,5}  {4,7}", "DNI", "NOMBRE", "APELLIDO", "HORAS", "IMPORTE")
            Dim i, suma As Integer
            suma = 0
            For i = 0 To Cont - 1
                Dim emp As Empleado = Tabla(i)
                salida.WriteLine("{0,10}  {1,20}  {2,20}  {3,5}  {4,7}", emp.DNI, emp.Nombre, emp.Apellido, emp.Horas.ToString, (emp.Horas * 30).ToString)
                suma += emp.Horas
            Next
            salida.WriteLine("Total Horas: {0} Total Importe: {1}", suma, suma * 30)
            salida.Close()
        End Using

    End Sub
End Class
