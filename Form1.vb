Imports System.Diagnostics

Public Class Form1
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ' Cambiar el color del vínculo al configurar LinkVisited como True
        LinkLabel1.LinkVisited = True
        ' Usar el método Process.Start para abrir el explorador predeterminado
        System.Diagnostics.Process.Start _
        ("http://www.mcgraw-hill.com.mx/Mexico/Default.htm")

        ' Si el explorador predeterminado no es Internet Explorer, se puede abrir el sitio web en Internet Explorer
        ' System.Diagnostics.Process.Start("iexplore.exe", "http://www.mcgraw-hill.com.mx/Mexico/Default.htm")
    End Sub
End Class
