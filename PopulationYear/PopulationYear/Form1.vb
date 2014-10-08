Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click

        Dim Pop As Double = 7000000000
        Dim Year As Integer = 2014

        Do While Pop >= 6000000
            Pop = Pop / 2
            Year -= 50
        Loop

        MessageBox.Show("The population was under 6 million in " & Year)

    End Sub
End Class
