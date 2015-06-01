<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTesting2
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
        Me.lvTest = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnTest = New System.Windows.Forms.Button()
        Me.dtpTesting = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'lvTest
        '
        Me.lvTest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvTest.Location = New System.Drawing.Point(12, 12)
        Me.lvTest.Name = "lvTest"
        Me.lvTest.Size = New System.Drawing.Size(1160, 402)
        Me.lvTest.TabIndex = 0
        Me.lvTest.UseCompatibleStateImageBehavior = False
        Me.lvTest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 245
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Age"
        Me.ColumnHeader2.Width = 105
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Date"
        Me.ColumnHeader3.Width = 805
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(914, 623)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(258, 26)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'dtpTesting
        '
        Me.dtpTesting.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTesting.Location = New System.Drawing.Point(12, 629)
        Me.dtpTesting.Name = "dtpTesting"
        Me.dtpTesting.Size = New System.Drawing.Size(96, 20)
        Me.dtpTesting.TabIndex = 2
        '
        'FormTesting2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.dtpTesting)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lvTest)
        Me.Name = "FormTesting2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvTest As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents dtpTesting As System.Windows.Forms.DateTimePicker
End Class
