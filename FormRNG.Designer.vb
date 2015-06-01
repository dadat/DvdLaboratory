<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRNG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRNG))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnEnc = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtGenRNG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenRNG = New System.Windows.Forms.Button()
        Me.lvPkmn = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 45)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(397, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numbers:"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(82, 45)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(100, 30)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'txtNumbers
        '
        Me.txtNumbers.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumbers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtNumbers.Location = New System.Drawing.Point(82, 14)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(100, 25)
        Me.txtNumbers.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtOutput)
        Me.Panel2.Controls.Add(Me.btnEnc)
        Me.Panel2.Controls.Add(Me.txtNumbers)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnGenerate)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 130)
        Me.Panel2.TabIndex = 4
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtOutput.Location = New System.Drawing.Point(189, 14)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(237, 97)
        Me.txtOutput.TabIndex = 5
        '
        'btnEnc
        '
        Me.btnEnc.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnEnc.Location = New System.Drawing.Point(82, 81)
        Me.btnEnc.Name = "btnEnc"
        Me.btnEnc.Size = New System.Drawing.Size(100, 30)
        Me.btnEnc.TabIndex = 4
        Me.btnEnc.Text = "Encrypt"
        Me.btnEnc.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lvPkmn)
        Me.Panel3.Controls.Add(Me.txtGenRNG)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnGenRNG)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(12, 187)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(460, 198)
        Me.Panel3.TabIndex = 6
        '
        'txtGenRNG
        '
        Me.txtGenRNG.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.txtGenRNG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenRNG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtGenRNG.Location = New System.Drawing.Point(82, 14)
        Me.txtGenRNG.Name = "txtGenRNG"
        Me.txtGenRNG.Size = New System.Drawing.Size(100, 25)
        Me.txtGenRNG.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Numbers:"
        '
        'btnGenRNG
        '
        Me.btnGenRNG.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGenRNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenRNG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnGenRNG.Location = New System.Drawing.Point(82, 45)
        Me.btnGenRNG.Name = "btnGenRNG"
        Me.btnGenRNG.Size = New System.Drawing.Size(100, 30)
        Me.btnGenRNG.TabIndex = 2
        Me.btnGenRNG.Text = "Generate"
        Me.btnGenRNG.UseVisualStyleBackColor = False
        '
        'lvPkmn
        '
        Me.lvPkmn.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvPkmn.Location = New System.Drawing.Point(189, 14)
        Me.lvPkmn.Name = "lvPkmn"
        Me.lvPkmn.Size = New System.Drawing.Size(237, 171)
        Me.lvPkmn.TabIndex = 4
        Me.lvPkmn.UseCompatibleStateImageBehavior = False
        Me.lvPkmn.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Class"
        '
        'FormRNG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 397)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Leelawadee UI Semilight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRNG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormRNG"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumbers As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEnc As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtGenRNG As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenRNG As System.Windows.Forms.Button
    Friend WithEvents lvPkmn As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
