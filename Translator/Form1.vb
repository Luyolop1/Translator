Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        If ComboBox1.Text = "Dog" Then
            ComboBox2.Text = "Inja"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Dog.jpg")


        End If

        If ComboBox1.Text = "Cat" Then
            ComboBox2.Text = "Ikati"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Cat.png")
        End If

        If ComboBox1.Text = "Lion" Then
            ComboBox2.Text = "Ingonyama"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Lion.jpg")
        End If

        If ComboBox1.Text = "Chameleon" Then
            ComboBox2.Text = "Ilovane"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Chameleon.jpeg")

        End If
        If ComboBox1.Text = "Ostrich" Then
            ComboBox2.Text = "Inciniba"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Ostrich.jpg")
        End If

        If ComboBox1.Text = "Cow" Then
            ComboBox2.Text = "Inkomo"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Cow.jpg")
        End If

        If ComboBox1.Text = "Elephant" Then
            ComboBox2.Text = "Indlovu"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Elephant.jpg")
        End If

        If ComboBox1.Text = "Horse" Then
            ComboBox2.Text = "Ihashi"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Horse.jpg")
        End If

        If ComboBox1.Text = "Goat" Then
            ComboBox2.Text = "Ibhokhwe"
            PictureBox1.Image = Image.FromFile("C:\Users\mihlali\Desktop\VB PROJECTS\Translator\WinFormsApp1\ANIMALS\Goat.jpg")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
