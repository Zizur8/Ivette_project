Imports System

Module Program
    Sub Main()
        Console.Title = "Ejercicios del While"
        Ejercicio1()
        Ejercicio2()
        Ejercicio3()
        Ejercicio4()
        Ejercicio5()
        Ejercicio6()
        Ejercicio7()
        Ejercicio8()
        Ejercicio9()
        Ejercicio10()
        Console.ReadKey()

    End Sub
    Sub Ejercicio1()
        Console.WriteLine("Imprimir por pantalla los primeros: 20 numeros negativos par")
        Dim cont As Integer = 1
        Dim num As Integer = 0

        While cont <= 20
            num = num - 2
            Console.WriteLine(cont & "--->" & num)
            cont = cont + 1
        End While


    End Sub
    Sub Ejercicio2()
        Console.WriteLine("Imprimir por pantalla los primeros 40 numeros positivos impares")
        Dim cont As Integer = 1
        Dim num As Integer = 1
        While cont <= 40
            Console.WriteLine(cont & "--->" & num)
            num = num + 2
            cont = cont + 1
        End While
    End Sub
    Sub Ejercicio3()
        Console.WriteLine("Imprimir por pantalla los primeros: 30 numeros positivos impares de forma descendente")
        Dim num As Integer = 59
        Dim cont As Integer = 1
        While cont <= 30
            Console.WriteLine(cont & "--->" & num)
            num = num - 2
            cont = cont + 1
        End While
    End Sub
    Sub Ejercicio4()
        Console.WriteLine("Imprimir por pantalla los primeros: 50 numeros multiplos de 5")
        Dim num As Integer = 5
        Dim cont As Integer = 1
        While cont <= 50
            Console.WriteLine(cont & "--->" & num)
            cont = cont + 1
            num = 5 * cont
        End While
    End Sub
    Sub Ejercicio5()
        Console.WriteLine("Imprimir por pantalla los primeros 75 numeros multiplos de 7 a partir del numero 50")
        Dim num As Integer = 56
        Dim cont As Integer = 1
        While cont <= 75
            Console.WriteLine(cont & "--->" & num)
            num = num + 7
            cont = cont + 1
        End While
    End Sub
    Sub Ejercicio6()
        Console.WriteLine("Imprimir por pantalla 100 veces tu nombre")
        Dim name As String = " "
        Dim cont As Integer = 1
        Console.WriteLine("Ingresa tu nombre: ")
        name = Console.ReadLine()
        While cont <= 100
            Console.WriteLine(cont & "--->" & name)
            cont = cont + 1
        End While

    End Sub
    Sub Ejercicio7()
        Console.WriteLine("---------------------------------------------------")
        Console.WriteLine("Imprmir en pantalla la suma de los 50 primeros numeros positivos.")
        Dim cont As Integer = 1
        Dim num As Integer = 1
        Dim acum As Integer = 0
        While cont <= 50
            acum = acum + num
            Console.WriteLine(cont & ".----> " & acum)

            num = num + 1
            cont = cont + 1
        End While
        Console.WriteLine("La suma es de: " & acum)
        Console.ReadKey()
    End Sub
    Sub Ejercicio8()
        Console.WriteLine("Imprimir por pantalla la suma de los 20 primeros numeros impares a partir de 100")
        Dim num As Integer = 101
        Dim cont As Integer = 1
        Dim acum As Integer = 0
        While cont <= 20
            Console.WriteLine(cont & "--->" & num)
            cont = cont + 1
            acum = acum + num
            num = num + 7
        End While
    End Sub
    Sub Ejercicio9()
        Console.WriteLine("imprimir por pantalla la suma de los 50 primeros numeros positivos al cuadrado")
        Dim num As Integer = 1
        Dim cont As Integer = 1
        Dim acum As Integer = 0
        While cont <= 50
            acum = acum + (num ^ 2)
            Console.WriteLine(cont & "--->" & acum)
            cont = cont + 1
            num = num + 1
        End While
    End Sub
    Sub Ejercicio10()
        Console.WriteLine("Imprimir por pantalla la suma de los 60 primeros numeros")
        Dim num As Integer = 1
        Dim cont As Integer = 1
        Dim acum As Integer = 0
        While cont <= 50
            acum = acum + num

            Console.WriteLine(cont & "--->" & num)
            cont = cont + 1
            num = num + 1
        End While
        Console.WriteLine("La suma es de: " & acum)
    End Sub
End Module
