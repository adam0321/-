<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manager
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manager))
        Me.OrderDBDataSet = New brkSystem.OrderDBDataSet()
        Me.訂單資料表BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.訂單資料表TableAdapter = New brkSystem.OrderDBDataSetTableAdapters.訂單資料表TableAdapter()
        Me.TableAdapterManager = New brkSystem.OrderDBDataSetTableAdapters.TableAdapterManager()
        Me.訂單資料表BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.訂單資料表BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.訂單資料表DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDBDataSet1 = New brkSystem.OrderDBDataSet1()
        Me.客戶資料表BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.客戶資料表TableAdapter = New brkSystem.OrderDBDataSet1TableAdapters.客戶資料表TableAdapter()
        Me.TableAdapterManager1 = New brkSystem.OrderDBDataSet1TableAdapters.TableAdapterManager()
        Me.客戶資料表DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OrderDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂單資料表BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.訂單資料表BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.訂單資料表BindingNavigator.SuspendLayout()
        CType(Me.訂單資料表DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.客戶資料表BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.客戶資料表DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderDBDataSet
        '
        Me.OrderDBDataSet.DataSetName = "OrderDBDataSet"
        Me.OrderDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '訂單資料表BindingSource
        '
        Me.訂單資料表BindingSource.DataMember = "訂單資料表"
        Me.訂單資料表BindingSource.DataSource = Me.OrderDBDataSet
        '
        '訂單資料表TableAdapter
        '
        Me.訂單資料表TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = brkSystem.OrderDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.訂單資料表TableAdapter = Me.訂單資料表TableAdapter
        '
        '訂單資料表BindingNavigator
        '
        Me.訂單資料表BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.訂單資料表BindingNavigator.BindingSource = Me.訂單資料表BindingSource
        Me.訂單資料表BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.訂單資料表BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.訂單資料表BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.訂單資料表BindingNavigatorSaveItem})
        Me.訂單資料表BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.訂單資料表BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.訂單資料表BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.訂單資料表BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.訂單資料表BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.訂單資料表BindingNavigator.Name = "訂單資料表BindingNavigator"
        Me.訂單資料表BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.訂單資料表BindingNavigator.Size = New System.Drawing.Size(882, 25)
        Me.訂單資料表BindingNavigator.TabIndex = 0
        Me.訂單資料表BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "加入新的"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(27, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '訂單資料表BindingNavigatorSaveItem
        '
        Me.訂單資料表BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.訂單資料表BindingNavigatorSaveItem.Image = CType(resources.GetObject("訂單資料表BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.訂單資料表BindingNavigatorSaveItem.Name = "訂單資料表BindingNavigatorSaveItem"
        Me.訂單資料表BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.訂單資料表BindingNavigatorSaveItem.Text = "儲存資料"
        '
        '訂單資料表DataGridView
        '
        Me.訂單資料表DataGridView.AutoGenerateColumns = False
        Me.訂單資料表DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.訂單資料表DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.訂單資料表DataGridView.DataSource = Me.訂單資料表BindingSource
        Me.訂單資料表DataGridView.Location = New System.Drawing.Point(12, 28)
        Me.訂單資料表DataGridView.Name = "訂單資料表DataGridView"
        Me.訂單資料表DataGridView.RowTemplate.Height = 24
        Me.訂單資料表DataGridView.Size = New System.Drawing.Size(850, 163)
        Me.訂單資料表DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "訂單編號"
        Me.DataGridViewTextBoxColumn1.HeaderText = "訂單編號"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "主餐"
        Me.DataGridViewTextBoxColumn2.HeaderText = "主餐"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "口味喜好"
        Me.DataGridViewTextBoxColumn3.HeaderText = "口味喜好"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "主餐數量"
        Me.DataGridViewTextBoxColumn4.HeaderText = "主餐數量"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "飲料"
        Me.DataGridViewTextBoxColumn5.HeaderText = "飲料"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "冰溫熱"
        Me.DataGridViewTextBoxColumn6.HeaderText = "冰溫熱"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "飲料數量"
        Me.DataGridViewTextBoxColumn7.HeaderText = "飲料數量"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "小計"
        Me.DataGridViewTextBoxColumn8.HeaderText = "小計"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'OrderDBDataSet1
        '
        Me.OrderDBDataSet1.DataSetName = "OrderDBDataSet1"
        Me.OrderDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '客戶資料表BindingSource
        '
        Me.客戶資料表BindingSource.DataMember = "客戶資料表"
        Me.客戶資料表BindingSource.DataSource = Me.OrderDBDataSet1
        '
        '客戶資料表TableAdapter
        '
        Me.客戶資料表TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = brkSystem.OrderDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.客戶資料表TableAdapter = Me.客戶資料表TableAdapter
        '
        '客戶資料表DataGridView
        '
        Me.客戶資料表DataGridView.AutoGenerateColumns = False
        Me.客戶資料表DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.客戶資料表DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.客戶資料表DataGridView.DataSource = Me.客戶資料表BindingSource
        Me.客戶資料表DataGridView.Location = New System.Drawing.Point(12, 197)
        Me.客戶資料表DataGridView.Name = "客戶資料表DataGridView"
        Me.客戶資料表DataGridView.RowTemplate.Height = 24
        Me.客戶資料表DataGridView.Size = New System.Drawing.Size(547, 198)
        Me.客戶資料表DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "客戶編號"
        Me.DataGridViewTextBoxColumn9.HeaderText = "客戶編號"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "姓名"
        Me.DataGridViewTextBoxColumn10.HeaderText = "姓名"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "手機號碼"
        Me.DataGridViewTextBoxColumn11.HeaderText = "手機號碼"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "訂餐日期"
        Me.DataGridViewTextBoxColumn12.HeaderText = "訂餐日期"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "取餐時間"
        Me.DataGridViewTextBoxColumn13.HeaderText = "取餐時間"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 513)
        Me.Controls.Add(Me.客戶資料表DataGridView)
        Me.Controls.Add(Me.訂單資料表DataGridView)
        Me.Controls.Add(Me.訂單資料表BindingNavigator)
        Me.Name = "manager"
        Me.Text = "Form1"
        CType(Me.OrderDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂單資料表BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.訂單資料表BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.訂單資料表BindingNavigator.ResumeLayout(False)
        Me.訂單資料表BindingNavigator.PerformLayout()
        CType(Me.訂單資料表DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.客戶資料表BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.客戶資料表DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OrderDBDataSet As OrderDBDataSet
    Friend WithEvents 訂單資料表BindingSource As BindingSource
    Friend WithEvents 訂單資料表TableAdapter As OrderDBDataSetTableAdapters.訂單資料表TableAdapter
    Friend WithEvents TableAdapterManager As OrderDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 訂單資料表BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents 訂單資料表BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents 訂單資料表DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents OrderDBDataSet1 As OrderDBDataSet1
    Friend WithEvents 客戶資料表BindingSource As BindingSource
    Friend WithEvents 客戶資料表TableAdapter As OrderDBDataSet1TableAdapters.客戶資料表TableAdapter
    Friend WithEvents TableAdapterManager1 As OrderDBDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents 客戶資料表DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
