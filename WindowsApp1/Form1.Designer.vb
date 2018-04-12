<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.variableNameLabel = New System.Windows.Forms.Label()
        Me.variableLabel = New System.Windows.Forms.Label()
        Me.vehicleTaxLabel = New System.Windows.Forms.Label()
        Me.distanceText = New System.Windows.Forms.TextBox()
        Me.yearTaxButton = New System.Windows.Forms.Button()
        Me.yearTaxLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(264, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 0
        '
        'variableNameLabel
        '
        Me.variableNameLabel.AutoSize = True
        Me.variableNameLabel.Location = New System.Drawing.Point(173, 87)
        Me.variableNameLabel.Name = "variableNameLabel"
        Me.variableNameLabel.Size = New System.Drawing.Size(34, 12)
        Me.variableNameLabel.TabIndex = 1
        Me.variableNameLabel.Tag = ""
        Me.variableNameLabel.Text = "Name"
        '
        'variableLabel
        '
        Me.variableLabel.AutoSize = True
        Me.variableLabel.Location = New System.Drawing.Point(325, 136)
        Me.variableLabel.Name = "variableLabel"
        Me.variableLabel.Size = New System.Drawing.Size(0, 12)
        Me.variableLabel.TabIndex = 2
        '
        'vehicleTaxLabel
        '
        Me.vehicleTaxLabel.AutoSize = True
        Me.vehicleTaxLabel.Location = New System.Drawing.Point(327, 184)
        Me.vehicleTaxLabel.Name = "vehicleTaxLabel"
        Me.vehicleTaxLabel.Size = New System.Drawing.Size(0, 12)
        Me.vehicleTaxLabel.TabIndex = 3
        '
        'distanceText
        '
        Me.distanceText.Location = New System.Drawing.Point(264, 261)
        Me.distanceText.Name = "distanceText"
        Me.distanceText.Size = New System.Drawing.Size(121, 19)
        Me.distanceText.TabIndex = 4
        '
        'yearTaxButton
        '
        Me.yearTaxButton.Location = New System.Drawing.Point(442, 82)
        Me.yearTaxButton.Name = "yearTaxButton"
        Me.yearTaxButton.Size = New System.Drawing.Size(133, 23)
        Me.yearTaxButton.TabIndex = 5
        Me.yearTaxButton.Text = "年間納税額計算"
        Me.yearTaxButton.UseVisualStyleBackColor = True
        '
        'yearTaxLabel
        '
        Me.yearTaxLabel.AutoSize = True
        Me.yearTaxLabel.Location = New System.Drawing.Point(262, 24)
        Me.yearTaxLabel.Name = "yearTaxLabel"
        Me.yearTaxLabel.Size = New System.Drawing.Size(0, 12)
        Me.yearTaxLabel.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.yearTaxLabel)
        Me.Controls.Add(Me.yearTaxButton)
        Me.Controls.Add(Me.distanceText)
        Me.Controls.Add(Me.vehicleTaxLabel)
        Me.Controls.Add(Me.variableLabel)
        Me.Controls.Add(Me.variableNameLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents variableNameLabel As Label
    Friend WithEvents variableLabel As Label
    Friend WithEvents vehicleTaxLabel As Label
    Friend WithEvents distanceText As TextBox
    Friend WithEvents yearTaxButton As Button
    Friend WithEvents yearTaxLabel As Label
End Class
