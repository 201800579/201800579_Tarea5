Public Class Form1
    'validamos que se ingresen solo numeros en el textbox para el carnet
    Private Sub TBCarnet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCarnet.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'validamos que se ingresen solo numeros en el textbox para el Horas
    Private Sub TBHoras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBHoras.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'iniciamos con la codificacion de para nuestro programa validando qu se ingresen los datos 
    Private Sub TSAgregar_Click(sender As Object, e As EventArgs) Handles TSAgregar.Click
        'validamos que se ingresen un nombre del alumno
        If TBNombre.Text = "" Then
            MsgBox("Usted no a Ingresado el Nombre del alumno", MsgBoxStyle.Information, "Advertencia")
            TBNombre.Focus()
        Else
            'validamos que se ingrese el carnet del alumno
            If TBCarnet.Text = 0 Then
                MsgBox("Usted no a Ingresado el Carnet del alumno", MsgBoxStyle.Information, "Advertencia")
                TBCarnet.Focus()
            Else
                'validamos que se seleccione un idioma
                If CBIdioma.SelectedIndex = -1 Then
                    MsgBox("Usted no a Seleccionado un Idioma", MsgBoxStyle.Information, "Advertencia")
                Else
                    'validamos que se selecione los dias a recibir el curso
                    If CBDias.SelectedIndex = -1 Then
                        MsgBox("Usted no a Seleccionado los Dias a Recibir el Curso", MsgBoxStyle.Information, "Advertencia")
                    Else
                        'validamos que se ingrese el numero de horas
                        If TBHoras.Text = 0 Then
                            MsgBox("Usted no a Ingresado una cantidad de Horas valida", MsgBoxStyle.Information, "Advertencia")
                            TBHoras.Focus()
                        Else
                            'validamos que se seleccione un metodo de pago
                            If ((RBCheque.Checked = True) Or (RBEfectivo.Checked = True)) Then
                                'llamamos a nuestro metodo agregar donde se alonjan los calculos 
                                Agregar()
                            Else
                                MsgBox("Usted no a Seleccionado una Forma de Pago", MsgBoxStyle.Information, "Advertencia")
                            End If
                        End If
                        End If
                End If
            End If
        End If
    End Sub

    Private Sub TSLimpiar_Click(sender As Object, e As EventArgs) Handles TSLimpiar.Click
        If MsgBox("¿Desea eliminar todos los registros?", vbQuestion + vbYesNo, "Limpieza") = vbYes Then
            Limpieza()
        Else
            TBNombre.Focus()
        End If
    End Sub

    Private Sub TSSalir_Click(sender As Object, e As EventArgs) Handles TSSalir.Click
        If MsgBox("¿Desea sali del sistema?", vbQuestion + vbYesNo, "Salida") = vbYes Then
            Limpieza()
            Close()
        Else
            TBNombre.Focus()
        End If

    End Sub
End Class
