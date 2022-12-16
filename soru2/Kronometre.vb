Public Class Kronometre
    Dim saniye, dakika, saat As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        saniye = saniye + 1

        If saniye = 60 Then
            dakika = dakika + 1
            saniye = 0
        End If
        If dakika = 60 Then
            saat = saat + 1
            dakika = 0
        End If

        If saat = 24 Then saat = 0

        Label5.Text = saniye
        Label6.Text = dakika
        Label7.Text = saat


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Stop()

        saat = 0
        dakika = 0
        saniye = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Enabled = True

    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        saat = 0
        dakika = 0
        saniye = 0

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Start()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Stop()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Add("Saat")
        ListBox1.Items.Add(Label7.Text)
        ListBox1.Items.Add("Dakika")
        ListBox1.Items.Add(Label6.Text)
        ListBox1.Items.Add("Saniye")
        ListBox1.Items.Add(Label5.Text)
        ListBox1.Items.Add("-----------")

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Button1.Enabled Then
            saat = 0
            dakika = 0
            saniye = 0
            Label5.Text = 0
            Label6.Text = 0
            Label7.Text = 0
            Timer1.Stop()
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using SW As New IO.StreamWriter(TextBox1.Text, True)
            For Each itm As String In Me.ListBox1.Items
                SW.WriteLine(itm)
            Next
        End Using
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim oku As SaveFileDialog = New SaveFileDialog

        oku.Title = "Dosya Seç"

        oku.ShowDialog()
        If oku.FileName <> "" Then
            Dim Yol() As String

            Yol = oku.FileNames

            For Each yolgoster As String In Yol

                TextBox1.Text = yolgoster

            Next

        End If
    End Sub

End Class
