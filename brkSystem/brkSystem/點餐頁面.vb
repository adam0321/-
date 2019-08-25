Imports System.Data
Imports System.Data.SqlClient

Public Class 點餐頁面
    Public aa As String
    Public moneyfood As Integer
    Public moneydrink As Integer
    Public numfood As Integer
    Public numdrink As Integer
    Public total As Integer
    Dim cnStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
              "AttachDbFilename=|DataDirectory|\OrderDB.mdf;" &
              "Integrated Security=True;Connect Timeout=30"

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        首頁.Close()
        客戶資料.Close()
        使用說明.Close()

    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If aa = "" Then
            MsgBox("請輸入餐點", MsgBoxStyle.OkOnly, "請輸入餐點")
        Else
            Me.Hide()
            客戶資料.ShowDialog()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbNum2.SelectedIndex = 0 And cmbNum1.SelectedIndex = 0 Then
            MsgBox("請輸入餐點", MsgBoxStyle.OkOnly, "請輸入餐點")
        Else
            If cmbNum2.SelectedIndex = 0 Then
                MsgBox("你沒有選飲料,可繼續加點", MsgBoxStyle.OkOnly, "叮嚀")
                ListBox1.Items.Add(cmbFood.SelectedItem & cmbSpecial.SelectedItem & "   " & cmbNum1.SelectedItem & "份")
            ElseIf cmbNum1.SelectedIndex = 0 Then
                MsgBox("你沒有餐點,可繼續加點", MsgBoxStyle.OkOnly, "叮嚀")
                ListBox1.Items.Add(cmbDrink.SelectedItem & cmbTemp.SelectedItem & "   " & cmbNum2.SelectedItem & "份")
            Else
                ListBox1.Items.Add(cmbFood.SelectedItem & cmbSpecial.SelectedItem & "   " & cmbNum1.SelectedItem & "份" &
                               ControlChars.NewLine & cmbDrink.SelectedItem & cmbTemp.SelectedItem & "   " & cmbNum2.SelectedItem & "份")
            End If

            If cmbFood.SelectedIndex = 0 Then
                cmbSpecial.SelectedIndex = 0
                cmbNum1.SelectedIndex = 0
            End If
            If cmbDrink.SelectedIndex = 0 Then
                cmbTemp.SelectedIndex = 0
                cmbNum2.SelectedIndex = 0
            End If

            If cmbFood.SelectedIndex <> -1 Or cmbDrink.SelectedIndex <> -1 Or cmbNum1.SelectedIndex <> -1 Or cmbNum2.SelectedIndex <> -1 Then
                aa = aa & " "
                aa = aa & Me.cmbFood.SelectedItem
                aa = aa & " "
                aa = aa & Me.cmbSpecial.SelectedItem
                aa = aa & " "
                aa = aa & Me.cmbNum1.SelectedItem
                aa = aa & " " & "  "
                aa = aa & Me.cmbDrink.SelectedItem
                aa = aa & " "
                aa = aa & Me.cmbTemp.SelectedItem
                aa = aa & " "
                aa = aa & Me.cmbNum2.SelectedItem & "  "
                aa = aa & vbCrLf

                Label4.Text = aa & ControlChars.Tab




                If cmbFood.SelectedIndex = 0 Then
                    moneyfood = 0
                ElseIf cmbFood.SelectedIndex = 1 Then
                    moneyfood = 50
                ElseIf cmbFood.SelectedIndex = 2 Then
                    moneyfood = 40
                ElseIf cmbFood.SelectedIndex = 3 Then
                    moneyfood = 40
                ElseIf cmbFood.SelectedIndex = 4 Then
                    moneyfood = 35
                ElseIf cmbFood.SelectedIndex = 5 Then
                    moneyfood = 45
                ElseIf cmbFood.SelectedIndex = 6 Then
                    moneyfood = 35
                ElseIf cmbFood.SelectedIndex = 7 Then
                    moneyfood = 35
                ElseIf cmbFood.SelectedIndex = 8 Then
                    moneyfood = 30
                ElseIf cmbFood.SelectedIndex = 9 Then
                    moneyfood = 50
                ElseIf cmbFood.SelectedIndex = 10 Then
                    moneyfood = 40
                ElseIf cmbFood.SelectedIndex = 11 Then
                    moneyfood = 40
                ElseIf cmbFood.SelectedIndex = 12 Then
                    moneyfood = 35
                End If

                If cmbDrink.SelectedIndex = 0 Then
                    moneydrink = 0
                ElseIf cmbDrink.SelectedIndex = 1 Then
                    moneydrink = 20
                ElseIf cmbDrink.SelectedIndex = 2 Then
                    moneydrink = 20
                ElseIf cmbDrink.SelectedIndex = 3 Then
                    moneydrink = 20
                ElseIf cmbDrink.SelectedIndex = 4 Then
                    moneydrink = 20
                End If

                If cmbNum1.SelectedIndex = 0 Then
                    numfood = 0
                ElseIf cmbNum1.SelectedIndex = 1 Then
                    numfood = 1
                ElseIf cmbNum1.SelectedIndex = 2 Then
                    numfood = 2
                ElseIf cmbNum1.SelectedIndex = 3 Then
                    numfood = 3
                ElseIf cmbNum1.SelectedIndex = 4 Then
                    numfood = 4
                ElseIf cmbNum1.SelectedIndex = 5 Then
                    numfood = 5
                End If

                If cmbNum2.SelectedIndex = 0 Then
                    numdrink = 0
                ElseIf cmbNum2.SelectedIndex = 1 Then
                    numdrink = 1
                ElseIf cmbNum2.SelectedIndex = 2 Then
                    numdrink = 2
                ElseIf cmbNum2.SelectedIndex = 3 Then
                    numdrink = 3
                ElseIf cmbNum2.SelectedIndex = 4 Then
                    numdrink = 4
                ElseIf cmbNum2.SelectedIndex = 5 Then
                    numdrink = 5
                End If

                total += moneyfood * numfood + moneydrink * numdrink
                Label5.Text = total.ToString

                Try
                    Dim cn As New SqlConnection(cnStr)
                    cn.Open()
                    Dim cmd As New SqlCommand
                    cmd.CommandText = ("INSERT INTO 訂單資料表(主餐,口味喜好,主餐數量,飲料,冰溫熱,飲料數量,小計) VALUES(
                N'" & cmbFood.SelectedItem.ToString.Replace("'", "''") &
            "',N'" & cmbSpecial.SelectedItem.ToString.Replace("'", "''") &
            "','" & cmbNum1.SelectedItem.ToString.Replace("'", "''") &
            "',N'" & cmbDrink.SelectedItem.ToString.Replace("'", "''") &
            "',N'" & cmbTemp.SelectedItem.ToString.Replace("'", "''") &
            "',N'" & cmbNum2.SelectedItem.ToString.Replace("'", "''") &
            "',N'" & Label5.Text.Replace("'", "''") & "')")

                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    點餐頁面_Load(sender, e)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


                cmbDrink.SelectedIndex = 0
                cmbFood.SelectedIndex = 0
                cmbNum1.SelectedIndex = 0
                cmbNum2.SelectedIndex = 0
                cmbSpecial.SelectedIndex = 0
                cmbTemp.SelectedIndex = 0
            End If


        End If


    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        cmbDrink.SelectedIndex = 0
        cmbFood.SelectedIndex = 0
        cmbNum1.SelectedIndex = 0
        cmbNum2.SelectedIndex = 0
        cmbSpecial.SelectedIndex = 0
        cmbTemp.SelectedIndex = 0
        aa = ""
        moneydrink = 0
        moneyfood = 0
        numdrink = 0
        numfood = 0
        total = 0
        ListBox1.Items.Clear()
        Try
            Dim cn As New SqlConnection(cnStr)
            cn.Open()
            Dim cmd As New SqlCommand
            cmd.CommandText = ("DELETE FROM 訂單資料表")

            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            cn.Close()
            點餐頁面_Load(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Hide()
        首頁.Show()
    End Sub

    Private Sub 點餐頁面_Load(sender As Object, e As EventArgs) Handles Me.Load
        cmbDrink.SelectedIndex = 0
        cmbFood.SelectedIndex = 0
        cmbNum1.SelectedIndex = 0
        cmbNum2.SelectedIndex = 0
        cmbSpecial.SelectedIndex = 0
        cmbTemp.SelectedIndex = 0
        Dim cn As New SqlConnection(cnStr)
        Dim da As New SqlDataAdapter("SELECT * From 訂單資料表", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
    End Sub


End Class
