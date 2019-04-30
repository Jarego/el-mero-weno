Public Class Form1
    Dim res As String
    Dim cont = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += " "
        q0()


    End Sub



    Sub q0()


        If TextBox1.Text(cont) = Form3.TextBox1.Text Then

            Timer1.Enabled = True
            res += Form3.TextBox1.Text
            cont += 1
            Label1.Text = res
            PictureBox1.Image = ImageList1.Images(1)
            ListBox1.Items.Add("Se encuentra " + Form3.TextBox1.Text + ", se cambia a  " + Form3.TextBox1.Text + ", y se mueve a la derecha")
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(3000)
            q0()


        ElseIf TextBox1.Text(cont) = " " Then
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(3000)
            q1()
        ElseIf TextBox1.Text(cont) <> Form3.TextBox1.Text Then
            MsgBox("NO SE ACEPTA LA CADENA, solo se aceptan las cadenas formadas por '" + Form3.TextBox1.Text + "'")
            ListBox1.Items.Add("NO SE ACEPTA LA CADENA, solo se aceptan las cadenas formadas por '" + Form3.TextBox1.Text + "'")
            Label1.Text = ""
            TextBox1.Text = ""
            res = ""
            cont = 0
            PictureBox1.Image = ImageList1.Images(0)
        End If

    End Sub

    Sub q1()


        res += Form3.TextBox1.Text
        Label1.Text = res
        PictureBox1.Image = ImageList1.Images(2)
        ListBox1.Items.Add("Se encuentra b, se cambia a  " + Form3.TextBox1.Text)
        System.Windows.Forms.Application.DoEvents()
        System.Threading.Thread.Sleep(3000)
        MsgBox("Estado Final")
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ""
        TextBox1.Text = ""
        res = ""
        cont = 0
        Button1.Enabled = True
        Button2.Enabled = False
        PictureBox1.Image = ImageList1.Images(0)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.TextBox1.Text = ""
        Form3.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form3.TextBox1.Text
        Label4.Text = Form3.TextBox1.Text
        Label5.Text = Form3.TextBox1.Text
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label3.Text = Form3.TextBox1.Text
        Label4.Text = Form3.TextBox1.Text
        Label5.Text = Form3.TextBox1.Text
    End Sub
End Class

