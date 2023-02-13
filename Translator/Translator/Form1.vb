Imports System.Data.Common
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.Logging

Public Class Form1



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Dog" Then
            ComboBox2.Text = "Inja"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Dog.jfif")

        End If

        If ComboBox1.Text = "Cat" Then
            ComboBox2.Text = "Ikati"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\cat.jpg")

        End If

        If ComboBox1.Text = "Elephant" Then
            ComboBox2.Text = "Indlovu"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Elephant.jfif")

        End If

        If ComboBox1.Text = "Chicken" Then
            ComboBox2.Text = "Inkukhu"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Chicken.jpg")

        End If

        If ComboBox1.Text = "Ostrich" Then
            ComboBox2.Text = "Inciniba"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Ostrich.jfif")

        End If

        If ComboBox1.Text = "Horse" Then
            ComboBox2.Text = "Ihashi"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Horse.jpg")

        End If

        If ComboBox1.Text = "Lion" Then
            ComboBox2.Text = "Ingonyama"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Lion.jfif")

        End If

        If ComboBox1.Text = "Sheep" Then
            ComboBox2.Text = "Igusha"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Sheep.jpg")

        End If

        If ComboBox1.Text = "Rhino" Then
            ComboBox2.Text = "Umkhombe"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Rhino.jpg")

        End If

        If ComboBox1.Text = "Turtle" Then
            ComboBox2.Text = "Ifudo"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Turtle.jfif")

        End If

        If ComboBox1.Text = "Goat" Then
            ComboBox2.Text = "Ibhokwe"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Goat.jfif")

        End If

        If ComboBox1.Text = "Cow" Then
            ComboBox2.Text = "Inkomo"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Cow.jpg")

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.Text = "Inja" Then
            ComboBox1.Text = "Dog"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Dog.jfif")

        End If

        If ComboBox2.Text = "Ikati" Then
            ComboBox1.Text = "Cat"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\cat.jpg")

        End If

        If ComboBox2.Text = "Indlovu" Then
            ComboBox1.Text = "Elephant"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Elephant.jfif")

        End If

        If ComboBox2.Text = "Inkukhu" Then
            ComboBox1.Text = "Chicken"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Chicken.jpg")

        End If

        If ComboBox2.Text = "Inciniba" Then
            ComboBox1.Text = "Ostrich"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Ostrich.jfif")

        End If

        If ComboBox2.Text = "Ihashi" Then
            ComboBox1.Text = "Horse"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Horse.jpg")

        End If

        If ComboBox2.Text = "Ingonyama" Then
            ComboBox1.Text = "Lion"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Lion.jfif")

        End If

        If ComboBox2.Text = "Igusha" Then
            ComboBox1.Text = "Sheep"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Sheep.jpg")

        End If

        If ComboBox2.Text = "Umkhombe" Then
            ComboBox1.Text = "Rhino"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Rhino.jpg")

        End If

        If ComboBox2.Text = "Ifudo" Then
            ComboBox1.Text = "Turtle"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Turtle.jfif")

        End If

        If ComboBox2.Text = "Ibhokwe" Then
            ComboBox1.Text = "Goat"
            PictureBox1.Image = New Bitmap("C:\Users\Admin 2.0\Pictures\Animal\Goat.jfif")

        End If
    End Sub




End Class
