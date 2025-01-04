# MiVinculoWeb

# Descripcion

 Este proyecto consiste en una aplicacion que le permite a Visual Basic
 abrir un vinculo web a un sitio Online .
 
 # Actualizacion: 03/01/2025
 # Hora: 23:03

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# MyWebLink

# Description

This project consists of an application that allows Visual Basic
to open a web link to an online site.

# Update: 01/03/2025
# Time: 23:03

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/ac6e6526-4467-4dcc-94ee-81b4bdb42dda)

Code of the Project:

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
