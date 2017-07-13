<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.condition = New System.Windows.Forms.ComboBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.resultView = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "星座検索"
        '
        'condition
        '
        Me.condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.condition.FormattingEnabled = True
        Me.condition.Location = New System.Drawing.Point(33, 108)
        Me.condition.MaxDropDownItems = 4
        Me.condition.Name = "condition"
        Me.condition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.condition.Size = New System.Drawing.Size(182, 20)
        Me.condition.TabIndex = 1
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(242, 101)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(86, 32)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "検索"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'resultView
        '
        Me.resultView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.resultView.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.resultView.ForeColor = System.Drawing.SystemColors.MenuText
        Me.resultView.Location = New System.Drawing.Point(53, 154)
        Me.resultView.Name = "resultView"
        Me.resultView.Size = New System.Drawing.Size(139, 164)
        Me.resultView.TabIndex = 5
        Me.resultView.UseCompatibleStateImageBehavior = False
        Me.resultView.View = System.Windows.Forms.View.List
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 392)
        Me.Controls.Add(Me.resultView)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.condition)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Search"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents condition As ComboBox
    Friend WithEvents searchButton As Button
    Friend WithEvents resultView As ListView
End Class
