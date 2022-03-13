Imports System.Math
Module Module1
    'creamos un contador con el que se llevara el control de nuestros ingresos y nuestra matriz
    Dim Contador = 0
    Dim Datos(9, 7)
    'varavles donde se aleoja los precios
    Dim PrIngles = 150
    Dim PrPortugues = 80
    Dim PrFrances = 125

    Dim Subtotal As Double
    Dim Descuento1 As Double
    Dim Descuento2 As Double
    Dim Total As Double
    'metodo agregar datos 
    Public Sub Agregar()

        'creamos unas variables locales que nos ayudaran con el calculo 


        'validamos que no se ingresen mas de 8 estudiantes 
        If Contador < 8 Then
            'guardamos los datos Ingresados en nuestra Matriz
            Datos(0, Contador) = Form1.TBNombre.Text
            Datos(1, Contador) = Form1.TBCarnet.Text
            Datos(2, Contador) = Form1.CBIdioma.SelectedItem
            Datos(3, Contador) = Form1.DATAFecha.Value
            Datos(4, Contador) = Form1.CBDias.SelectedItem
            Datos(5, Contador) = Form1.TBHoras.Text



            'validamos cuando se seleecione solo un dia 
            If (Form1.CBDias.SelectedItem = "Viernes") Or (Form1.CBDias.SelectedItem = "Sabado") Then

                'validamos para cuando se seleccione cada tipo de Idioma y relizamos los calculos

                'si se selecciona ingles 
                If Form1.CBIdioma.SelectedItem = "Ingles" Then
                    'calculamos el total cuando se seleccione la opcion de ingles
                    Subtotal = PrIngles * Form1.TBHoras.Text
                    Datos(6, Contador) = Round(Subtotal, 2)
                    'calculamos el descuento para el tipo de pago 
                    'cheque
                    If Form1.RBCheque.Checked = True Then
                        Descuento1 = Subtotal * 0.015
                        Datos(7, Contador) = Round(Descuento1, 2)
                    End If
                    'Efectivo
                    If Form1.RBEfectivo.Checked = True Then
                        Descuento1 = Subtotal * 0.02
                        Datos(7, Contador) = Round(Descuento1, 2)
                    End If
                    Total = Subtotal - Descuento1
                    Datos(9, Contador) = Round(Total, 2)
                End If

                'si se selecciona Frances
                If Form1.CBIdioma.SelectedItem = "Frances" Then
                    'calculamos el total cuando se seleccione la opcion de ingles
                    Subtotal = PrFrances * Form1.TBHoras.Text
                    Datos(6, Contador) = Round(Subtotal, 2)
                    'calculamos el descuento para el tipo de pago 
                    'cheque
                    If Form1.RBCheque.Checked = True Then
                        Descuento1 = Subtotal * 0.015
                        Datos(7, Contador) = Round(Descuento1, 2)
                    End If
                    'Efectivo
                    If Form1.RBEfectivo.Checked = True Then
                        Descuento1 = Subtotal * 0.02
                        Datos(7, Contador) = Round(Descuento1, 2)
                    End If
                    Total = Subtotal - Descuento1
                    Datos(9, Contador) = Round(Total, 2)
                End If

                'si se selecciona Portigues 
                If Form1.CBIdioma.SelectedItem = "Portugues" Then
                    'calculamos el total cuando se seleccione la opcion de ingles
                    Subtotal = PrPortugues * Form1.TBHoras.Text
                    Datos(6, Contador) = Round(Subtotal, 2)
                    'calculamos el descuento para el tipo de pago 
                    'cheque
                    If Form1.RBCheque.Checked = True Then
                        Descuento1 = Subtotal * 0.015
                        Datos(7, Contador) = Round(Descuento1, 2)
                    End If
                    'Efectivo
                    If Form1.RBEfectivo.Checked = True Then
                        Descuento1 = Subtotal * 0.02
                        Datos(7, Contador) = Round(Descuento1, 2)
                    End If
                    Total = Subtotal - Descuento1
                    Datos(9, Contador) = Round(Total, 2)
                End If

                'llenamos el contador para cuando no hay descuento por ambos dias 
                Datos(8, Contador) = 0
            End If

            'validamos cuando se seleecione ambos dias 
            If (Form1.CBDias.SelectedItem = "Ambos Dias") Then
                'validamos para cuando se seleccione cada tipo de Idioma y relizamos los calculos

                'si se selecciona ingles 
                If Form1.CBIdioma.SelectedItem = "Ingles" Then
                    'calculamos el total cuando se seleccione la opcion de ingles
                    Subtotal = PrIngles * Form1.TBHoras.Text * 2
                    Datos(6, Contador) = Round(Subtotal, 2)
                    'calculamos el descuento para el tipo de pago 
                    'cheque
                    If Form1.RBCheque.Checked = True Then
                        Descuento1 = Subtotal * 0.015
                        Datos(7, Contador) = Round(Descuento1, 2)
                        Descuento2 = Subtotal * 0.05
                        Datos(8, Contador) = Round(Descuento2, 2)
                    End If
                    'Efectivo
                    If Form1.RBEfectivo.Checked = True Then
                        Descuento1 = Subtotal * 0.02
                        Datos(7, Contador) = Round(Descuento1, 2)
                        Descuento2 = Subtotal * 0.05
                        Datos(8, Contador) = Round(Descuento2, 2)
                    End If
                    Total = Subtotal - Descuento1 - Descuento2
                    Datos(9, Contador) = Round(Total, 2)
                End If

                'si se selecciona Frances
                If Form1.CBIdioma.SelectedItem = "Frances" Then
                    'calculamos el total cuando se seleccione la opcion de ingles
                    Subtotal = PrFrances * Form1.TBHoras.Text * 2
                    Datos(6, Contador) = Round(Subtotal, 2)
                    'calculamos el descuento para el tipo de pago 
                    'cheque
                    If Form1.RBCheque.Checked = True Then
                        Descuento1 = Subtotal * 0.015
                        Datos(7, Contador) = Round(Descuento1, 2)
                        Descuento2 = Subtotal * 0.05
                        Datos(8, Contador) = Round(Descuento2, 2)
                    End If
                    'Efectivo
                    If Form1.RBEfectivo.Checked = True Then
                        Descuento1 = Subtotal * 0.02
                        Datos(7, Contador) = Round(Descuento1, 2)
                        Descuento2 = Subtotal * 0.05
                        Datos(8, Contador) = Round(Descuento2, 2)
                    End If
                    Total = Subtotal - Descuento1 - Descuento2
                    Datos(9, Contador) = Round(Total, 2)
                End If

                'si se selecciona Portigues 
                If Form1.CBIdioma.SelectedItem = "Portugues" Then
                    'calculamos el total cuando se seleccione la opcion de ingles
                    Subtotal = PrPortugues * Form1.TBHoras.Text * 2
                    Datos(6, Contador) = Round(Subtotal, 2)
                    'calculamos el descuento para el tipo de pago 
                    'cheque
                    If Form1.RBCheque.Checked = True Then
                        Descuento1 = Subtotal * 0.015
                        Datos(7, Contador) = Round(Descuento1, 2)
                        Descuento2 = Subtotal * 0.05
                        Datos(8, Contador) = Round(Descuento2, 2)
                    End If
                    'Efectivo
                    If Form1.RBEfectivo.Checked = True Then
                        Descuento1 = Subtotal * 0.02
                        Datos(7, Contador) = Round(Descuento1, 2)
                        Descuento2 = Subtotal * 0.05
                        Datos(8, Contador) = Round(Descuento2, 2)
                    End If
                    Total = Subtotal - Descuento1 - Descuento2
                    Datos(9, Contador) = Round(Total, 2)
                End If

            End If

            Form1.DTResultados.Rows.Add(Contador + 1, Datos(0, Contador), Datos(1, Contador), Datos(2, Contador), Datos(3, Contador), Datos(4, Contador), Datos(5, Contador), Datos(6, Contador), Datos(7, Contador), Datos(8, Contador), Datos(9, Contador))

            Contador = Contador + 1


            'vaciamos los textbox y las opciones seleccionadas para los nuevos ingresos que se hagan
            Form1.TBNombre.Text = ""
            Form1.TBCarnet.Text = 0
            Form1.TBHoras.Text = 0
            Form1.RBCheque.Checked = 0
            Form1.RBEfectivo.Checked = 0
            Form1.CBIdioma.SelectedIndex = -1
            Form1.CBDias.SelectedIndex = -1
            Form1.CBDias.Text = "Seleccione Los Dias"
            Form1.CBIdioma.Text = "Seleccione Un Idioma"
            Form1.TBNombre.Focus()
        Else
            'advertencia cuando se llegue al limite de estudiantes
            MsgBox("Se a Alcanzado el Limite de Estudiantes", MsgBoxStyle.Information, "Advertencia")
        End If

    End Sub


    'hacemos nuestro porceso para limpiar los datos 
    Public Sub Limpieza()
        'limpiamos nuestros datos de entrada
        Form1.TBNombre.Text = ""
        Form1.TBCarnet.Text = 0
        Form1.TBHoras.Text = 0
        Form1.RBCheque.Checked = 0
        Form1.RBEfectivo.Checked = 0
        Form1.CBIdioma.SelectedIndex = -1
        Form1.CBDias.SelectedIndex = -1
        Form1.CBDias.Text = "Seleccione Los Dias"
        Form1.CBIdioma.Text = "Seleccione Un Idioma"
        Form1.DTResultados.Rows.Clear()
        'reiniciamos nuestro contador
        Contador = 0
        'limpiamos matriz 
        ReDim Datos(9, 7)
        Form1.TBNombre.Focus()
    End Sub

End Module
