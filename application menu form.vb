Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public Class Form1

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Add menu items to menu strip
            Dim localDishes As New ToolStripMenuItem("Local Dishes")
            localDishes.ForeColor = Color.White
            localDishes.BackColor = Color.Red

            localDishes.DropDownItems.Add("Matooke and Beans")
            localDishes.DropDownItems.Add("Posho and Groundnuts")
            localDishes.DropDownItems.Add("Rice and Beef Stew")

            Dim internationalDishes As New ToolStripMenuItem("International Dishes")
            internationalDishes.ForeColor = Color.White
            internationalDishes.BackColor = Color.Red

            internationalDishes.DropDownItems.Add("Spaghetti Bolognese")
            internationalDishes.DropDownItems.Add("Chicken Tikka Masala")
            internationalDishes.DropDownItems.Add("Fish and Chips")

            Dim softDrinks As New ToolStripMenuItem("Soft Drinks")
            softDrinks.ForeColor = Color.White
            softDrinks.BackColor = Color.Red

            softDrinks.DropDownItems.Add("Coca-Cola")
            softDrinks.DropDownItems.Add("Sprite")
            softDrinks.DropDownItems.Add("Fanta Orange")

            Dim hardDrinks As New ToolStripMenuItem("Hard Drinks")
            hardDrinks.ForeColor = Color.White
            hardDrinks.BackColor = Color.Red

            hardDrinks.DropDownItems.Add("Nile Special Beer")
            hardDrinks.DropDownItems.Add("Uganda Waragi")
            hardDrinks.DropDownItems.Add("Johnnie Walker Whisky")

            Dim fruitsAndVegetables As New ToolStripMenuItem("Fruits and Vegetables")
            fruitsAndVegetables.ForeColor = Color.White
            fruitsAndVegetables.BackColor = Color.Red

            fruitsAndVegetables.DropDownItems.Add("Fresh Fruit Salad")
            fruitsAndVegetables.DropDownItems.Add("Mixed Vegetable Salad")
            fruitsAndVegetables.DropDownItems.Add("Avocado and Tomato Salad")

            MenuStrip1.Items.Add(localDishes)
            MenuStrip1.Items.Add(internationalDishes)
            MenuStrip1.Items.Add(softDrinks)
            MenuStrip1.Items.Add(hardDrinks)
            MenuStrip1.Items.Add(fruitsAndVegetables)
        End Sub

        Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
            'Display item price when clicked on
            Dim price As Double = 0.0

            Select Case e.ClickedItem.Text
                Case "Matooke and Beans"
                    price = 5000
                Case "Posho and Groundnuts"
                    price = 4000
                Case "Rice and Beef Stew"
                    price = 7000
                Case "Spaghetti Bolognese"
                    price = 8000
                Case "Chicken Tikka Masala"
                    price = 9000
                Case "Fish and Chips"
                    price = 10000
                Case "Coca-Cola"
                    price = 2000
                Case "Sprite"
                    price = 2000
                Case "Fanta Orange"
                    price = 2000
                Case "Nile Special Beer"
                    price = 5000
                Case "Uganda Waragi"
                    price = 7000
                Case "Johnnie Walker Whisky"
                    price = 15000
                Case "Fresh Fruit Salad"
                    price = 5000
                Case "Mixed Vegetable Salad"
                    price = 4000
                Case "Avocado and Tomato Salad"
                    price = 6000
            End Select

            lblPrice.Text = "Price: UGX " & price
        End Sub
End Class
