Module Module1

    Sub Main()
        Dim mesas(,) As String = New String(19, 3) {}
        Dim filas As Integer = mesas.GetLength(0)
        Dim columnas As Integer = mesas.GetLength(1)
        Dim salirBucle As Integer
        Dim salirPrograma As Integer
        Dim opcion As Integer
        ' tamaño de cada mesa
        Dim tableSize4 As Integer = 4
        Dim tableSize8 As Integer = 8
        Dim tableSize12 As Integer = 12
        Do
            ' Falta un bucle para que el programa no termine
            Console.WriteLine("1. Agregar Reservas.
2. Mostrar Reservas.
3. Buscar Reserrvas
4. Eliminar o cancelar reservas
5. Mostrar distribucion de mesas
6. Reportes")
            Console.Write("Ingrese una opcion: ")
            opcion = Console.ReadLine()
            Select Case opcion
                Case 1
                    Console.WriteLine("------------------")
                    Console.WriteLine("Agregar Reservas")
                    ' Va rellenandose las filas "i" y se va a detener cuando llegue a 20 o el usuario quiera
                    For i As Integer = 0 To filas - 1
                        Console.WriteLine("Filas " & i & " Columnas ")
                        Console.Write("Ingrese su nombre: ")
                        mesas(i, 0) = Console.ReadLine()
                        Console.Write("Ingrese su telefono: ")
                        mesas(i, 1) = Console.ReadLine()
                        Console.Write("Ingrese numero de comensales: ")
                        mesas(i, 2) = Console.ReadLine()
                        Console.Write("Ingrese el rut: ")
                        mesas(i, 3) = Console.ReadLine()
                        Console.WriteLine("¿Desea continuar?
1. Continuar
2. Salir")
                        Console.Write("Opcion: ")
                        salirBucle = Console.ReadLine()
                        If salirBucle = 1 Then
                            Continue For
                        ElseIf salirBucle = 2 Then
                            Exit For
                        End If
                    Next
                Case 2
                    ' Mostrar todas las reservas
                    For i As Integer = 0 To filas - 1
                        For t As Integer = 0 To columnas - 1
                            Console.WriteLine(mesas(i, t))
                        Next
                    Next
                ' Falta asignar la mesa al usuario depeniendo la cantidad 
                ' de comensales ingresados
                Case 3

                ' buscar reserva
                Case 4
                ' Eliminar o cancelar reserva
                Case 5
                ' Mostara distribucion de mesas
                Case 6
                ' Reportes
                Case 7
                    salirPrograma = opcion
                    ' Salir del programa
            End Select
        Loop While (opcion >= 7)
    End Sub

End Module