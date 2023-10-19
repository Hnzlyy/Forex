Public Class Form1

    Dim num As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxList1.Items.Add("US DOLLAR")
        ComboBoxList1.Items.Add("HKG DOLLAR")
        ComboBoxList1.Items.Add("CND DOLLAR")
        ComboBoxList1.Items.Add("IND RUPEE")
        ComboBoxList1.Items.Add("SRL RUPEE")
        ComboBoxList1.Items.Add("UAE DINAR")
        ComboBoxList1.Items.Add("PHP PESO")
        ComboBoxList1.Items.Add("UK POUND")
        ComboBoxList1.Items.Add("JPN YEN")
        ComboBoxList1.Items.Add("EURO")

        ComboBoxList2.Items.Add("US DOLLAR")
        ComboBoxList2.Items.Add("HKG DOLLAR")
        ComboBoxList2.Items.Add("CND DOLLAR")
        ComboBoxList2.Items.Add("IND RUPEE")
        ComboBoxList2.Items.Add("SRL RUPEE")
        ComboBoxList2.Items.Add("UAE DINAR")
        ComboBoxList2.Items.Add("PHP PESO")
        ComboBoxList2.Items.Add("UK POUND")
        ComboBoxList2.Items.Add("JPN YEN")
        ComboBoxList2.Items.Add("EURO")

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSum.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxList1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxList2.SelectedIndexChanged

    End Sub

    Private Sub ButtonCompute_Click(sender As Object, e As EventArgs) Handles ButtonCompute.Click

        Try

            If ComboBoxList1.Text = ComboBoxList2.Text Then

                TextBoxAmount.Text = 1
                PictureBox1.Image = Nothing
                PictureBox2.Image = Nothing
            TextBoxSum.Text = Nothing
            ComboBoxList1.Text = Nothing
            ComboBoxList2.Text = Nothing

        End If

            If ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 7.83
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.13
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 1.37
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.73
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 83.27
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.012
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 325.29
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.0031
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 3.67
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.27
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 56.88
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.018
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.82
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 1.21
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 149.78
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 0.0067
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.jpg")

            ElseIf ComboBoxList1.Text = "US DOLLAR" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.95
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "US DOLLAR" Then

                num = TextBoxAmount.Text * 1.05
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\US.png")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 0.18
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 5.7
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 10.64
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 0.094
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 41.57
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 0.02
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 0.47
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 2.13
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 7.27
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 0.14
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.11
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 9.5
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 19.14
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 0.052
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "HKG DOLLAR" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.12
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "HKG DOLLAR" Then

                num = TextBoxAmount.Text * 8.25
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\HK.jpg")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 60.67
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 0.016
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 237.13
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 0.0042
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 2.68
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 0.37
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 41.46
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 0.024
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.6
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 1.66
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 109.2
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 0.0092
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "CND DOLLAR" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.69
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "CND DOLLAR" Then

                num = TextBoxAmount.Text * 1.45
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\C.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 3.91
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 0.26
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 0.044
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 22.66
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 0.68
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 1.46
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.0099
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 100.91
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 1.8
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 0.56
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "IND RUPEE" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.011
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "IND RUPEE" Then

                num = TextBoxAmount.Text * 87.87
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\INDIA.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 0.011
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 88.56
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 0.18
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 5.72
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.0025
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 394.28
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 0.46
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 2.17
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "SRL RUPEE" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.0029
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "SRL RUPEE" Then

                num = TextBoxAmount.Text * 342.91
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\SRL.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 15.47
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 0.065
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.22
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 4.45
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 40.79
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 0.025
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "UAE DINAR" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.26
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "UAE DINAR" Then

                num = TextBoxAmount.Text * 3.88
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UAE.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.015
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 68.89
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 2.64
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 0.38
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "PHP PESO" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.017
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "PHP PESO" Then

                num = TextBoxAmount.Text * 60.01
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\PH.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 181.63
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.0055
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "UK POUND" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 1.15
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "UK POUND" Then

                num = TextBoxAmount.Text * 0.87
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\UK.png")

            ElseIf ComboBoxList1.Text = "JPN YEN" And ComboBoxList2.Text = "EURO" Then

                num = TextBoxAmount.Text * 0.0063
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")

            ElseIf ComboBoxList1.Text = "EURO" And ComboBoxList2.Text = "JPN YEN" Then

                num = TextBoxAmount.Text * 158.21
                TextBoxSum.Text = num
                PictureBox1.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\EU.jpg")
                PictureBox2.Image = Image.FromFile("C:\Users\Hnz\Desktop\Hnz-Forex\Flags\JAPAN.png")

            End If

        Catch ex As Exception
            MessageBox.Show(String.Format("Input Amount!", ex.Message))
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBoxAmount.Text = 1
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        TextBoxSum.Text = Nothing
        ComboBoxList1.Text = Nothing
        ComboBoxList2.Text = Nothing

    End Sub
End Class
