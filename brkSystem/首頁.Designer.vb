<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 首頁
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
        Me.Label32 = New System.Windows.Forms.Label()
        Me.btnhead = New System.Windows.Forms.Button()
        Me.btnUse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Chartreuse
        Me.Label32.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(56, 36)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(727, 114)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "甲紮等訂餐系統"
        '
        'btnhead
        '
        Me.btnhead.BackColor = System.Drawing.Color.Coral
        Me.btnhead.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnhead.Location = New System.Drawing.Point(267, 188)
        Me.btnhead.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnhead.Name = "btnhead"
        Me.btnhead.Size = New System.Drawing.Size(284, 122)
        Me.btnhead.TabIndex = 53
        Me.btnhead.Text = "開始訂餐"
        Me.btnhead.UseVisualStyleBackColor = False
        '
        'btnUse
        '
        Me.btnUse.BackColor = System.Drawing.Color.Coral
        Me.btnUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnUse.Location = New System.Drawing.Point(267, 363)
        Me.btnUse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(284, 124)
        Me.btnUse.TabIndex = 54
        Me.btnUse.Text = "使用說明"
        Me.btnUse.UseVisualStyleBackColor = False
        '
        '首頁
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.brkSystem.My.Resources.Resources.tartan_43c8c58eb9ea4d185123c81b1233c600
        Me.ClientSize = New System.Drawing.Size(822, 540)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.btnhead)
        Me.Controls.Add(Me.Label32)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "首頁"
        Me.Text = "首頁"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label32 As Label
    Friend WithEvents btnhead As Button
    Friend WithEvents btnUse As Button
End Class
