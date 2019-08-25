<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 點餐頁面
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(點餐頁面))
        Me.cmbNum1 = New System.Windows.Forms.ComboBox()
        Me.groupbox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSpecial = New System.Windows.Forms.ComboBox()
        Me.cmbFood = New System.Windows.Forms.ComboBox()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblSpecial = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbNum2 = New System.Windows.Forms.ComboBox()
        Me.lblDrink = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.cmbDrink = New System.Windows.Forms.ComboBox()
        Me.cmbTemp = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnhome = New System.Windows.Forms.Button()
        Me.點餐清單 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.groupbox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.點餐清單.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbNum1
        '
        Me.cmbNum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNum1.FormattingEnabled = True
        Me.cmbNum1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbNum1.Location = New System.Drawing.Point(496, 26)
        Me.cmbNum1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbNum1.Name = "cmbNum1"
        Me.cmbNum1.Size = New System.Drawing.Size(96, 26)
        Me.cmbNum1.TabIndex = 6
        '
        'groupbox1
        '
        Me.groupbox1.BackgroundImage = Global.brkSystem.My.Resources.Resources._22
        Me.groupbox1.Controls.Add(Me.cmbSpecial)
        Me.groupbox1.Controls.Add(Me.cmbFood)
        Me.groupbox1.Controls.Add(Me.lblNum1)
        Me.groupbox1.Controls.Add(Me.lblSpecial)
        Me.groupbox1.Controls.Add(Me.lblFood)
        Me.groupbox1.Controls.Add(Me.cmbNum1)
        Me.groupbox1.Location = New System.Drawing.Point(56, 36)
        Me.groupbox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupbox1.Name = "groupbox1"
        Me.groupbox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupbox1.Size = New System.Drawing.Size(600, 78)
        Me.groupbox1.TabIndex = 33
        Me.groupbox1.TabStop = False
        Me.groupbox1.Text = "餐點"
        '
        'cmbSpecial
        '
        Me.cmbSpecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpecial.FormattingEnabled = True
        Me.cmbSpecial.Items.AddRange(New Object() {"無", "加起司", "不加醬", "不加菜"})
        Me.cmbSpecial.Location = New System.Drawing.Point(321, 28)
        Me.cmbSpecial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSpecial.Name = "cmbSpecial"
        Me.cmbSpecial.Size = New System.Drawing.Size(116, 26)
        Me.cmbSpecial.TabIndex = 44
        '
        'cmbFood
        '
        Me.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFood.FormattingEnabled = True
        Me.cmbFood.Items.AddRange(New Object() {"不要餐點", "卡拉雞腿漢堡$50", "燻雞漢堡$40", "豬排漢堡$40", "培根漢堡$35", "卡拉雞腿蛋餅$45", "燻雞蛋餅$35", "豬排蛋餅$35", "培根蛋餅$30", "卡拉雞腿吐司$50", "燻雞吐司$40", "豬排吐司$40", "培根吐司$35"})
        Me.cmbFood.Location = New System.Drawing.Point(51, 26)
        Me.cmbFood.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFood.Name = "cmbFood"
        Me.cmbFood.Size = New System.Drawing.Size(175, 26)
        Me.cmbFood.TabIndex = 43
        '
        'lblNum1
        '
        Me.lblNum1.AutoSize = True
        Me.lblNum1.Location = New System.Drawing.Point(447, 34)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(44, 18)
        Me.lblNum1.TabIndex = 42
        Me.lblNum1.Text = "數量"
        '
        'lblSpecial
        '
        Me.lblSpecial.AutoSize = True
        Me.lblSpecial.Location = New System.Drawing.Point(234, 34)
        Me.lblSpecial.Name = "lblSpecial"
        Me.lblSpecial.Size = New System.Drawing.Size(80, 18)
        Me.lblSpecial.TabIndex = 41
        Me.lblSpecial.Text = "口味喜好"
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Location = New System.Drawing.Point(8, 34)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(44, 18)
        Me.lblFood.TabIndex = 40
        Me.lblFood.Text = "餐點"
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Coral
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(674, 142)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(195, 96)
        Me.btnContinue.TabIndex = 38
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Coral
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnExit.Location = New System.Drawing.Point(674, 248)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(195, 96)
        Me.btnExit.TabIndex = 39
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label31.Location = New System.Drawing.Point(99, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(0, 111)
        Me.Label31.TabIndex = 50
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbNum2
        '
        Me.cmbNum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNum2.FormattingEnabled = True
        Me.cmbNum2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5"})
        Me.cmbNum2.Location = New System.Drawing.Point(450, 26)
        Me.cmbNum2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbNum2.Name = "cmbNum2"
        Me.cmbNum2.Size = New System.Drawing.Size(96, 26)
        Me.cmbNum2.TabIndex = 6
        '
        'lblDrink
        '
        Me.lblDrink.AutoSize = True
        Me.lblDrink.Location = New System.Drawing.Point(8, 34)
        Me.lblDrink.Name = "lblDrink"
        Me.lblDrink.Size = New System.Drawing.Size(44, 18)
        Me.lblDrink.TabIndex = 40
        Me.lblDrink.Text = "飲料"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(194, 34)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(62, 18)
        Me.lblTemp.TabIndex = 41
        Me.lblTemp.Text = "冰溫熱"
        '
        'lblNum2
        '
        Me.lblNum2.AutoSize = True
        Me.lblNum2.Location = New System.Drawing.Point(394, 34)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(44, 18)
        Me.lblNum2.TabIndex = 42
        Me.lblNum2.Text = "數量"
        '
        'cmbDrink
        '
        Me.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDrink.FormattingEnabled = True
        Me.cmbDrink.Items.AddRange(New Object() {"不要飲料", "紅茶$20", "奶茶$20", "豆漿$20", "咖啡$20"})
        Me.cmbDrink.Location = New System.Drawing.Point(58, 26)
        Me.cmbDrink.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDrink.Name = "cmbDrink"
        Me.cmbDrink.Size = New System.Drawing.Size(126, 26)
        Me.cmbDrink.TabIndex = 43
        '
        'cmbTemp
        '
        Me.cmbTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTemp.FormattingEnabled = True
        Me.cmbTemp.Items.AddRange(New Object() {"無", "冰", "溫", "熱"})
        Me.cmbTemp.Location = New System.Drawing.Point(256, 24)
        Me.cmbTemp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTemp.Name = "cmbTemp"
        Me.cmbTemp.Size = New System.Drawing.Size(126, 26)
        Me.cmbTemp.TabIndex = 44
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImage = CType(resources.GetObject("GroupBox6.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox6.Controls.Add(Me.cmbTemp)
        Me.GroupBox6.Controls.Add(Me.cmbDrink)
        Me.GroupBox6.Controls.Add(Me.lblNum2)
        Me.GroupBox6.Controls.Add(Me.lblTemp)
        Me.GroupBox6.Controls.Add(Me.lblDrink)
        Me.GroupBox6.Controls.Add(Me.cmbNum2)
        Me.GroupBox6.Location = New System.Drawing.Point(56, 154)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(600, 78)
        Me.GroupBox6.TabIndex = 44
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "飲料"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Coral
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(674, 36)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(195, 96)
        Me.btnAdd.TabIndex = 52
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(957, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 53
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(868, 550)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 55
        Me.Label5.Visible = False
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Coral
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnhome.Location = New System.Drawing.Point(674, 352)
        Me.btnhome.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(195, 96)
        Me.btnhome.TabIndex = 56
        Me.btnhome.Text = "返回"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        '點餐清單
        '
        Me.點餐清單.Controls.Add(Me.ListBox1)
        Me.點餐清單.Location = New System.Drawing.Point(56, 250)
        Me.點餐清單.Name = "點餐清單"
        Me.點餐清單.Size = New System.Drawing.Size(600, 244)
        Me.點餐清單.TabIndex = 57
        Me.點餐清單.TabStop = False
        Me.點餐清單.Text = "點餐清單"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(26, 27)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(553, 202)
        Me.ListBox1.TabIndex = 54
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 502)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(600, 200)
        Me.DataGridView1.TabIndex = 58
        Me.DataGridView1.Visible = False
        '
        '點餐頁面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.brkSystem.My.Resources.Resources.tartan_43c8c58eb9ea4d185123c81b1233c600
        Me.ClientSize = New System.Drawing.Size(874, 506)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.點餐清單)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.groupbox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "點餐頁面"
        Me.Text = "點餐頁面"
        Me.groupbox1.ResumeLayout(False)
        Me.groupbox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.點餐清單.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbNum1 As ComboBox
    Friend WithEvents groupbox1 As GroupBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblSpecial As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents cmbFood As ComboBox
    Friend WithEvents cmbSpecial As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents cmbNum2 As ComboBox
    Friend WithEvents lblDrink As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents cmbDrink As ComboBox
    Friend WithEvents cmbTemp As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnhome As Button
    Friend WithEvents 點餐清單 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
