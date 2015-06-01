<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSCCITest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInsertCase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInsertCase
        '
        Me.btnInsertCase.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnInsertCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertCase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnInsertCase.Location = New System.Drawing.Point(172, 40)
        Me.btnInsertCase.Name = "btnInsertCase"
        Me.btnInsertCase.Size = New System.Drawing.Size(140, 30)
        Me.btnInsertCase.TabIndex = 0
        Me.btnInsertCase.Text = "Test"
        Me.btnInsertCase.UseVisualStyleBackColor = False
        '
        'FormSCCITest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 111)
        Me.Controls.Add(Me.btnInsertCase)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormSCCITest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Testing Purposes Only"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsertCase As System.Windows.Forms.Button
End Class
