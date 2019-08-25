<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addResult
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.endTerm = New System.Windows.Forms.TextBox()
        Me.midTerm = New System.Windows.Forms.TextBox()
        Me.term = New System.Windows.Forms.ComboBox()
        Me.academicYear = New System.Windows.Forms.ComboBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD EXAM RESULT"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.endTerm)
        Me.Panel2.Controls.Add(Me.midTerm)
        Me.Panel2.Controls.Add(Me.term)
        Me.Panel2.Controls.Add(Me.academicYear)
        Me.Panel2.Controls.Add(Me.lastName)
        Me.Panel2.Controls.Add(Me.firstName)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(466, 323)
        Me.Panel2.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(160, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'endTerm
        '
        Me.endTerm.Location = New System.Drawing.Point(186, 261)
        Me.endTerm.Name = "endTerm"
        Me.endTerm.Size = New System.Drawing.Size(270, 20)
        Me.endTerm.TabIndex = 3
        '
        'midTerm
        '
        Me.midTerm.Location = New System.Drawing.Point(186, 218)
        Me.midTerm.Name = "midTerm"
        Me.midTerm.Size = New System.Drawing.Size(270, 20)
        Me.midTerm.TabIndex = 3
        '
        'term
        '
        Me.term.FormattingEnabled = True
        Me.term.Items.AddRange(New Object() {"ONE ", "TWO", "THREE"})
        Me.term.Location = New System.Drawing.Point(186, 171)
        Me.term.Name = "term"
        Me.term.Size = New System.Drawing.Size(270, 21)
        Me.term.TabIndex = 2
        '
        'academicYear
        '
        Me.academicYear.FormattingEnabled = True
        Me.academicYear.Items.AddRange(New Object() {"2012/13"})
        Me.academicYear.Location = New System.Drawing.Point(186, 126)
        Me.academicYear.Name = "academicYear"
        Me.academicYear.Size = New System.Drawing.Size(270, 21)
        Me.academicYear.TabIndex = 2
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(186, 76)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(270, 20)
        Me.lastName.TabIndex = 1
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(186, 27)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(270, 20)
        Me.firstName.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "EndTerm:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "MidTerm:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Term:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Academic Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(33, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Previous page"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(287, 297)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Logout"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'addResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 384)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "addResult"
        Me.Text = "addResult"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents endTerm As System.Windows.Forms.TextBox
    Friend WithEvents midTerm As System.Windows.Forms.TextBox
    Friend WithEvents term As System.Windows.Forms.ComboBox
    Friend WithEvents academicYear As System.Windows.Forms.ComboBox
    Friend WithEvents lastName As System.Windows.Forms.TextBox
    Friend WithEvents firstName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
