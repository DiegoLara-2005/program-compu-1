Module Module1

    Sub Main()

        Dim opcion As Integer

        Do

            Console.WriteLine("Seleccione la opcion que desea utilizar: ")
            Console.WriteLine("1. Si el numero es positivo o negativo")
            Console.WriteLine("2. Tabla de multiplicar")
            Console.WriteLine("3. Suma de numeros")
            Console.WriteLine("4. Determinar si un numero es primo")
            Console.WriteLine("5. Sacar promedio de numeros")
            Console.WriteLine("0. para salir del programa")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    PositivoONegativo()
                Case 2
                    TablaDeMultiplicar()
                Case 3
                    SumadeNumeros()
                Case 4
                    SiEsPrimo()
                Case 5
                    CalcularPromedio()
                Case 0
                    Console.WriteLine("Saliendo del programa...")
                Case Else
                    Console.WriteLine("No puedo realizar eso :c")

            End Select


        Loop While opcion <> 0


    End Sub

    Sub PositivoONegativo()
        Dim numero As Int16 = 1

        While numero <> 0


            Console.WriteLine("Ingrese un numero: ")
            numero = Console.ReadLine()

            If numero > 0 Then
                Console.WriteLine("El numero es Positivo")

            ElseIf numero < 0 Then
                Console.WriteLine("El numero es Negativo")

            End If

        End While

    End Sub

    Sub TablaDeMultiplicar()
        Dim numero As Integer
        Do

            Console.WriteLine("Porfavor ingrese un numero entre 1 y 10 (0 para cerrar): ")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero > 0 And numero <= 10 Then
                For x As Integer = 1 To 10
                    Console.WriteLine(numero & " x " & x & " = " & numero * x)
                Next
            ElseIf numero <> 0 Then
                Console.WriteLine("Numero no valido :c")


            End If
        Loop While numero <> 0
    End Sub

    Sub SumadeNumeros()
        Dim numero As Integer
        Dim suma As Integer = 0

        Do
            Console.WriteLine("Por favor ingrese unicamente positivos para sumar (0 para cerrar): ")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero > 0 Then
                suma += numero
            End If
        Loop While numero > 0

        Console.WriteLine("La suma resultante es: " & suma)
    End Sub

    Sub SiEsPrimo()
        Console.WriteLine("Ingrese su numero deseado: ")
        Dim numero As Integer = Convert.ToInt32(Console.ReadLine())
        Dim esPrimo As Boolean = True



        If numero <= 1 Then
                esPrimo = False

            Else

                For x As Integer = 2 To Math.Sqrt(numero)
                    If numero Mod x = 0 Then
                        esPrimo = False
                        Exit For
                    End If
                Next
            End If

            If esPrimo Then
                Console.WriteLine(numero & " es un numero Primo")
            Else
                Console.WriteLine(numero & " no es un numero Primo")
            End If


    End Sub

    Sub CalcularPromedio()
        Dim numero As Integer
        Dim suma As Integer = 0
        Dim contador As Integer = 0

        Do

            Console.WriteLine("Ingrese un numero (0 para cerrar): ")
            numero = Convert.ToInt32(Console.ReadLine())

            If numero <> 0 Then
                suma += numero
                contador += 1

            End If
        Loop While numero <> 0

        If contador > 0 Then
            Dim promedio As Double = suma / contador
            Console.WriteLine("El promedio de los numeros seleccionados es: " & promedio)
        Else
            Console.WriteLine("No se ingresaron numeros validos")

        End If
    End Sub

End Module
