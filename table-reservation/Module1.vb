Module Module1

    Sub Main()
        ' tamaño de cada mesa
        Dim tableSize4 As Integer = 4
        Dim tableSize8 As Integer = 8
        Dim tableSize12 As Integer = 12
        ' Reservas
        Dim reserva1() As String
        ReDim Preserve reserva1(4)

        ' Falta un bucle para que el programa no termine
        Console.WriteLine("1. Agregar Reservas.
2. Mostrar Reservas.
3. Buscar Reserrvas
4. Eliminar o cancelar reservas
5. Mostrar distribucion de mesas
6. Reportes")
        Console.WriteLine("Ingrese una opcion: ")
        Dim opcion As Integer = Console.ReadLine()
        Select Case opcion
            Case 1
                Console.WriteLine("Agregar Reservas")
                ' Crear un funcion que agrege las revervas
                Console.Write("Ingrese su nombre: ")
                reserva1(0) = Console.ReadLine()
                Console.Write("Ingrese su telefono: ")
                reserva1(1) = Console.ReadLine()
                Console.Write("Ingrese la cantidad de personas: ")
                reserva1(2) = Console.ReadLine()
                Console.Write("Ingrese numero de comensales: ")
                reserva1(3) = Console.ReadLine()
                Console.Write("Ingrese el rut: ")
                reserva1(4) = Console.ReadLine()
            Case 2
                Console.WriteLine("Mostrar Reservas")
                Console.WriteLine("Nombre: " & reserva1(0))
                Console.WriteLine("Telefono: " & reserva1(1))
                Console.WriteLine("Cantidad de personas: " & reserva1(2))
                Console.WriteLine("Numero de comensales: " & reserva1(3))
                Console.WriteLine("Rut: " & reserva1(4))
                ' Falta asignar la mesa al usuario depeniendo la cantidad 
                ' de comensales ingresados
                Console.WriteLine("Numero de mesa: ")
            Case 3
                ' buscar reserva
            Case 4
                ' Eliminar o cancelar reserva
            Case 5
                ' Mostara distribucion de mesas
            Case 6
                ' Reportes
            Case 7
                ' Salir del programa
        End Select

    End Sub

End Module
