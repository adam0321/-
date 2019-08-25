Imports System.Data
Imports System.Data.SqlClient

Public Class 客戶資料
    Public aa As String
    Public money As Integer
    Public month As Integer
    Dim cnStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
              "AttachDbFilename=|DataDirectory|\OrderDB.mdf;" &
              "Integrated Security=True;Connect Timeout=30"

    Private Sub 客戶資料_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intYear As Integer = 2018 To 2021 Step 1
            cmbYear.Items.Add(intYear)
        Next intYear
        cmbYear.SelectedIndex = 0

        For intMon As Integer = 1 To 12 Step 1
            cmbMonth.Items.Add(intMon)
        Next intMon
        cmbMonth.SelectedIndex = 0


        For intDay As Integer = 1 To 31 Step 1
            cmbDay.Items.Add(intDay)
        Next intDay
        cmbDay.SelectedIndex = 0


        For intHour As Integer = 4 To 12 Step 1
            cmbHour.Items.Add(intHour)
        Next intHour
        cmbHour.SelectedIndex = 0

        For intMin As Integer = 0 To 59 Step 10
            cmbMinute.Items.Add(intMin)
        Next intMin
        cmbMinute.SelectedIndex = 0

        Label10.Text = 點餐頁面.Label5.Text
        Label9.Text = 點餐頁面.Label4.Text
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        cmbDay.Items.Clear()
        cmbHour.Items.Clear()
        cmbMinute.Items.Clear()
        cmbMonth.Items.Clear()
        cmbYear.Items.Clear()
        Me.Hide()
        點餐頁面.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        點餐頁面.Close()
        首頁.Close()
        使用說明.Close()

    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim Dates As String = cmbYear.SelectedItem.ToString & "/" & cmbMonth.SelectedItem.ToString & "/" & cmbDay.SelectedItem.ToString
        Dim times As String = cmbHour.SelectedItem.ToString & ":" & cmbMinute.SelectedItem.ToString

        If (cmbDay.SelectedIndex = -1 OrElse cmbHour.SelectedIndex = -1 OrElse cmbMinute.SelectedIndex = -1 OrElse cmbMonth.SelectedIndex = -1 OrElse cmbYear.SelectedIndex = -1) Then
            MsgBox("請輸入日期", MsgBoxStyle.OkOnly, "請輸入日期")
        End If
        If txtName.Text = "" Then
            MsgBox("請輸入姓名", MsgBoxStyle.OkOnly, "請輸入姓名")
        End If
        If txtPhone.Text = "" Then
            MsgBox("請輸入電話號碼", MsgBoxStyle.OkOnly, "請輸入電話")
        End If
        If (txtName.Text <> "" And txtPhone.Text <> "" And cmbDay.SelectedIndex <> -1 And cmbHour.SelectedIndex <> -1 And cmbMinute.SelectedIndex <> -1 And cmbMonth.SelectedIndex <> -1 And cmbYear.SelectedIndex <> -1) Then

            MessageBox.Show("姓名" & ControlChars.Tab & txtName.Text &
               ControlChars.NewLine & "電話:" & ControlChars.Tab & txtPhone.Text &
               ControlChars.NewLine & "取餐時間為:" & ControlChars.Tab & cmbYear.Text & ControlChars.Tab & "年" & ControlChars.Tab & cmbMonth.Text & ControlChars.Tab & "月" & ControlChars.Tab & cmbDay.Text & ControlChars.Tab & "日" &
               ControlChars.NewLine & ControlChars.Tab & cmbHour.Text & ControlChars.Tab & "時" & ControlChars.Tab & cmbMinute.Text & ControlChars.Tab & "分" &
               ControlChars.NewLine & "總金額為:" & ControlChars.Tab & Label10.Text &
               ControlChars.NewLine & "這是你的項目:" & ControlChars.Tab & vbCrLf & Label9.Text)


            Select Case MessageBox.Show("確定要送出訂單了?", "叮嚀", MessageBoxButtons.YesNo)
                Case MsgBoxResult.Yes

                    Try
                        Dim cn As New SqlConnection(cnStr)
                        cn.Open()
                        Dim cmd As New SqlCommand
                        cmd.CommandText = ("INSERT INTO 客戶資料表(姓名,手機號碼,訂餐日期,取餐時間) VALUES(
                N'" & txtName.Text.Replace("'", "''") &
            "',N'" & txtPhone.Text.Replace("'", "''") &
            "',N'" & Dates.Replace("'", "''") &
            "',N'" & times.Replace("'", "''") & "')")


                        cmd.Connection = cn
                        cmd.ExecuteNonQuery()
                        cn.Close()
                        客戶資料_Load(sender, e)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try


                    點餐頁面.aa = ""
                    點餐頁面.moneydrink = 0
                    點餐頁面.moneyfood = 0
                    點餐頁面.numdrink = 0
                    點餐頁面.numfood = 0
                    點餐頁面.total = 0
                    點餐頁面.ListBox1.Items.Clear()
                    Label10.Text = ""
                    Label9.Text = ""
                    點餐頁面.cmbDrink.SelectedIndex = -1
                    點餐頁面.cmbFood.SelectedIndex = -1
                    點餐頁面.cmbNum1.SelectedIndex = -1
                    點餐頁面.cmbNum2.SelectedIndex = -1
                    點餐頁面.cmbSpecial.SelectedIndex = -1
                    點餐頁面.cmbTemp.SelectedIndex = -1
                    cmbMonth.SelectedIndex = -1
                    cmbHour.SelectedIndex = -1
                    cmbDay.SelectedIndex = -1
                    cmbMinute.SelectedIndex = -1
                    cmbYear.SelectedIndex = -1
                    cmbDay.Items.Clear()
                    cmbHour.Items.Clear()
                    cmbMinute.Items.Clear()
                    cmbMonth.Items.Clear()
                    cmbYear.Items.Clear()
                    txtName.Text = ""
                    txtPhone.Text = ""
                    Me.Close()
                    首頁.Show()
                Case MsgBoxResult.No
                    Label10.Text = ""
                    cmbDay.Items.Clear()
                    cmbHour.Items.Clear()
                    cmbMinute.Items.Clear()
                    cmbMonth.Items.Clear()
                    cmbYear.Items.Clear()
                    Me.Close()
                    點餐頁面.Show()
            End Select
        End If
    End Sub


    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9" OrElse e.KeyChar = "") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            MsgBox("請輸入正確電話號碼")
        End If

    End Sub
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (e.KeyChar = Chr(48) Or e.KeyChar = Chr(49) Or e.KeyChar = Chr(50) Or e.KeyChar = Chr(51) Or e.KeyChar = Chr(52) Or e.KeyChar = Chr(53) Or e.KeyChar = Chr(54) Or e.KeyChar = Chr(55) Or e.KeyChar = Chr(56) Or e.KeyChar = Chr(57) OrElse e.KeyChar = "") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
            MsgBox("請輸入正確中文或英文名字")
        End If

    End Sub

End Class