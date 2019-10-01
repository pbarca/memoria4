﻿Public Class Form1
    Dim Matriz(12) As Integer
    Dim Ajogar = 1
    Dim Anterior As Integer
    Dim Quadros() As PictureBox
    Private Sub Inicializa()
        Dim i As Integer
        For i = 0 To 11
            Matriz(i) = 0
            Quadros(i).BackgroundImage = My.Resources.Nada
        Next

        For par = 0 To 5
            For x = 0 To 1
                Do : i = Int(Rnd() * 12)
                Loop While Matriz(i) > 0
                Matriz(i) = par
            Next
        Next
    End Sub
    Private Sub Imagem(quadro)
        Dim fig As New PictureBox
        Select Case Matriz(quadro)
            Case 0 : fig.BackgroundImage = My.Resources.aries
            Case 1 : fig.BackgroundImage = My.Resources.aquarius
            Case 2 : fig.BackgroundImage = My.Resources.pisces
            Case 3 : fig.BackgroundImage = My.Resources.gemini
            Case 4 : fig.BackgroundImage = My.Resources.leo
            Case 5 : fig.BackgroundImage = My.Resources.libra
        End Select
        Quadros(quadro).BackgroundImage = fig.BackgroundImage
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P2.Click, P4.Click, P3.Click, P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P12.Click, P11.Click, P10.Click
        Dim quadro
        Select Case sender.name
            Case "P1" : quadro = 0
            Case "P2" : quadro = 1
            Case "P3" : quadro = 2
            Case "P4" : quadro = 3
            Case "P5" : quadro = 4
            Case "P6" : quadro = 5
            Case "P7" : quadro = 6
            Case "P8" : quadro = 7
            Case "P9" : quadro = 8
            Case "P10" : quadro = 9
            Case "P11" : quadro = 10
            Case "P12" : quadro = 11
        End Select
        Imagem(quadro)
        If Ajogar = 1 Then : Anterior = quadro
        ElseIf Matriz(Anterior) <> Matriz(quadro) Then
            Threading.Thread.Sleep(1500)
            Quadros(quadro).BackgroundImage = My.Resources.Nada
            Quadros(Anterior).BackgroundImage = My.Resources.Nada
        End If

        If Ajogar = 1 Then : Ajogar = 2
        Else : Ajogar = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inicializa()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quadros = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12}
        Call Inicializa()
    End Sub
End Class
