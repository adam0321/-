<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 使用說明
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbluse = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbluse
        '
        Me.lbluse.AutoSize = True
        Me.lbluse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbluse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbluse.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbluse.Location = New System.Drawing.Point(53, 28)
        Me.lbluse.Name = "lbluse"
        Me.lbluse.Size = New System.Drawing.Size(602, 468)
        Me.lbluse.TabIndex = 0
        Me.lbluse.Text = "餐點: 選擇想要吃的餐點" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "飲料: 選擇想要喝的飲料" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add按鈕 : 加入購物車" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "continue 按鈕: 進入下一頁" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "返回:回到首頁" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "結帳: 訂單完成" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "繼續點餐: 返回前頁 繼續點餐" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exit按鈕:離開程式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "資料請輸入完整!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Coral
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnback.Location = New System.Drawing.Point(280, 545)
        Me.btnback.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(144, 94)
        Me.btnback.TabIndex = 54
        Me.btnback.Text = "返回"
        Me.btnback.UseVisualStyleBackColor = False
        '
        '使用說明
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.brkSystem.My.Resources.Resources.tartan_43c8c58eb9ea4d185123c81b1233c600
        Me.ClientSize = New System.Drawing.Size(729, 662)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lbluse)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "使用說明"
        Me.Text = "使用說明"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbluse As Label
    Friend WithEvents btnback As Button
End Class
