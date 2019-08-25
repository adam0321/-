Imports System.Data
Imports System.Data.SqlClient
Public Class manager
    Dim cnStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
              "AttachDbFilename=|DataDirectory|\OrderDB.mdf;" &
              "Integrated Security=True;Connect Timeout=30"

    Private Sub 訂單資料表BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles 訂單資料表BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.訂單資料表BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OrderDBDataSet)

    End Sub

    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TODO: 這行程式碼會將資料載入 'OrderDBDataSet1.客戶資料表' 資料表。您可以視需要進行移動或移除。
        Me.客戶資料表TableAdapter.Fill(Me.OrderDBDataSet1.客戶資料表)
        'TODO: 這行程式碼會將資料載入 'OrderDBDataSet.訂單資料表' 資料表。您可以視需要進行移動或移除。
        Me.訂單資料表TableAdapter.Fill(Me.OrderDBDataSet.訂單資料表)
        Dim cn As New SqlConnection(cnStr)
        Dim da As New SqlDataAdapter("SELECT * From 訂單資料表", cn)
        Dim ds As New DataSet
        da.Fill(ds)
        訂單資料表DataGridView.DataSource = ds.Tables(0)

        Dim cnn As New SqlConnection(cnStr)
        Dim daa As New SqlDataAdapter("SELECT * From 客戶資料表", cnn)
        Dim dss As New DataSet
        da.Fill(dss)
        訂單資料表DataGridView.DataSource = ds.Tables(0)
    End Sub

    Private Sub 訂單資料表BindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles 訂單資料表BindingNavigator.RefreshItems

    End Sub

    Private Sub manager_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Hide()
        首頁.Show()
    End Sub
End Class