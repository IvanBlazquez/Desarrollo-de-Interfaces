Module Module1
    Enum Cuerda
        Tenor
        Soprano
        Baritono
        Contralto
        Bajo
    End Enum

    Public Structure Coralista
        Public id As Integer
        Public Nombre As String
        Public Convocado As Boolean
        Public voz As Cuerda
        Public Sub SetConvocado(valor As Boolean)
            Convocado = valor
        End Sub
    End Structure

    Public coralistas As New Collection

    Public Function Alta(id As Integer, Nombre As String, voz As Cuerda, Optional ByVal convocado As Boolean = False) As Coralista
        Dim cor As Coralista
        cor.id = id
        cor.Nombre = Nombre
        cor.voz = voz
        cor.Convocado = convocado
        Return cor
    End Function

    Public Sub Llenarcombo(cmb As ComboBox)
        For c As Cuerda = Cuerda.Tenor To Cuerda.Bajo
            cmb.Items.Add(c.ToString)
        Next
    End Sub

    Public Function NoConvocados() As Integer()
        Dim noconv() As Integer = Nothing
        Dim cont As Integer
        For Each c As Coralista In coralistas
            If c.Convocado = False Then
                ReDim Preserve noconv(cont)
                noconv(cont) = c.id
                cont += 1
            End If
        Next
        Return noconv
    End Function

    Public Sub LlenarLista(lista As ListBox, ids() As Integer)
        For Each i As Integer In ids
            lista.Items.Add(i.ToString)
        Next
    End Sub

    Public Sub MostrarAlineacion()
        Dim t = 0, ca = 0, s = 0, b = 0, bj As Integer = 0

        Console.WriteLine("{0,2}  {1,15}  {2,9}", "Id", "Nombre", "Cuerda")
        For Each c As Coralista In coralistas
            If c.Convocado Then
                Console.WriteLine("{0,2}  {1,15}  {2,9}", c.id, c.Nombre, c.voz.ToString)
                Select Case c.voz
                    Case Cuerda.Tenor
                        t += 1
                    Case Cuerda.Baritono
                        b += 1
                    Case Cuerda.Soprano
                        s += 1
                    Case Cuerda.Bajo
                        bj += 1
                    Case Else
                        ca += 1
                End Select
            End If
        Next
        Console.WriteLine("Tenores {0}", t)
        Console.WriteLine("Sopranos {0}", s)
        Console.WriteLine("Barítonos {0}", b)
        Console.WriteLine("Bajos {0}", bj)
        Console.WriteLine("Contraltos {0}", ca)
    End Sub
End Module
