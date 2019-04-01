Public Class mainfrm

    Private Sub btnfood_Click(sender As Object, e As EventArgs) Handles btnfood.Click
        layer.Height = btnfood.Height
        layer.Top = btnfood.Top
        layer.BringToFront()
        '-------------------------------
        Foodpnl.Visible = True
        drinkpnl.Visible = False
        dessert.Visible = False
        mycart.Visible = False
        aboutus.Visible = False

        '--------------------------------
        foodfast.Visible = False
        chinese.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        layer.Height = Button1.Height
        layer.Top = Button1.Top
        layer.BringToFront()

        Foodpnl.Visible = False
        drinkpnl.Visible = True
        dessert.Visible = False
        mycart.Visible = False
        aboutus.Visible = False

        '--------------------------------
        foodfast.Visible = False
        chinese.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        layer.Height = Button2.Height
        layer.Top = Button2.Top
        layer.BringToFront()

        Foodpnl.Visible = False
        drinkpnl.Visible = False
        dessert.Visible = True
        mycart.Visible = False
        aboutus.Visible = False

        '--------------------------------
        chinese.Visible = False
        foodfast.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        layer.Height = Button3.Height
        layer.Top = Button3.Top
        layer.BringToFront()

        Foodpnl.Visible = False
        drinkpnl.Visible = False
        dessert.Visible = False
        mycart.Visible = True
        aboutus.Visible = False

        '--------------------------------
        chinese.Visible = False
        foodfast.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        layer.Height = Button4.Height
        layer.Top = Button4.Top
        layer.BringToFront()

        Foodpnl.Visible = False
        drinkpnl.Visible = False
        dessert.Visible = False
        mycart.Visible = False
        aboutus.Visible = True

        '--------------------------------
        chinese.Visible = False
        foodfast.Visible = False
    End Sub

    Private Sub fastfood_Click(sender As Object, e As EventArgs) Handles fastfood.Click
        foodfast.Visible = True
        foodfast.BringToFront()

        layer.Height = btnfood.Height
        layer.Top = btnfood.Top
        layer.BringToFront()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class
