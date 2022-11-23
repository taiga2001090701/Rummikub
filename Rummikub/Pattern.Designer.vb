<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pattern
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
        Me.RT = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RT
        '
        Me.RT.BackColor = System.Drawing.Color.White
        Me.RT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RT.Font = New System.Drawing.Font("MS UI Gothic", 32.0!)
        Me.RT.Location = New System.Drawing.Point(0, 0)
        Me.RT.Name = "RT"
        Me.RT.ReadOnly = True
        Me.RT.Size = New System.Drawing.Size(484, 761)
        Me.RT.TabIndex = 0
        Me.RT.Text = ""
        '
        'Pattern
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 761)
        Me.Controls.Add(Me.RT)
        Me.Name = "Pattern"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pattern"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RT As Windows.Forms.RichTextBox
End Class
