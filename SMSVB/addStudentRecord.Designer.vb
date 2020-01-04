<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudentRecord
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.studentClass = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.studentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.GroupBox()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.admission = New System.Windows.Forms.TextBox()
        Me.graduation = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.studentId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.studentOtherName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.studentLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.studentFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fatherAddress = New System.Windows.Forms.RichTextBox()
        Me.fatherEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fatherTelephone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.motherLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fatherFirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.motherEmail = New System.Windows.Forms.TextBox()
        Me.motherAddress = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.motherFirstName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.motherTelephone = New System.Windows.Forms.TextBox()
        Me.fatherLastName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Gender.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.studentClass)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.studentDate)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.admission)
        Me.GroupBox1.Controls.Add(Me.graduation)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.studentId)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.studentOtherName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.studentLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.studentFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1214, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Details"
        '
        'studentClass
        '
        Me.studentClass.FormattingEnabled = True
        Me.studentClass.Items.AddRange(New Object() {"ONE ", "TWO ", "THREE", "FOUR"})
        Me.studentClass.Location = New System.Drawing.Point(700, 128)
        Me.studentClass.Name = "studentClass"
        Me.studentClass.Size = New System.Drawing.Size(175, 24)
        Me.studentClass.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(575, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 16)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Class"
        '
        'studentDate
        '
        Me.studentDate.Location = New System.Drawing.Point(382, 136)
        Me.studentDate.Name = "studentDate"
        Me.studentDate.Size = New System.Drawing.Size(171, 22)
        Me.studentDate.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(284, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 16)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Date of Birth"
        '
        'Gender
        '
        Me.Gender.Controls.Add(Me.radioMale)
        Me.Gender.Controls.Add(Me.radioFemale)
        Me.Gender.Location = New System.Drawing.Point(9, 118)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(200, 100)
        Me.Gender.TabIndex = 15
        Me.Gender.TabStop = False
        Me.Gender.Text = "Gender"
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioMale.Location = New System.Drawing.Point(20, 21)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(59, 20)
        Me.radioMale.TabIndex = 16
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Location = New System.Drawing.Point(20, 54)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(78, 20)
        Me.radioFemale.TabIndex = 17
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'admission
        '
        Me.admission.Location = New System.Drawing.Point(382, 80)
        Me.admission.Name = "admission"
        Me.admission.ReadOnly = True
        Me.admission.Size = New System.Drawing.Size(171, 22)
        Me.admission.TabIndex = 14
        '
        'graduation
        '
        Me.graduation.Location = New System.Drawing.Point(700, 77)
        Me.graduation.Name = "graduation"
        Me.graduation.ReadOnly = True
        Me.graduation.Size = New System.Drawing.Size(175, 22)
        Me.graduation.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(575, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 16)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Graduation"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(285, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Admission"
        '
        'studentId
        '
        Me.studentId.Location = New System.Drawing.Point(95, 77)
        Me.studentId.Name = "studentId"
        Me.studentId.Size = New System.Drawing.Size(171, 22)
        Me.studentId.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Student ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(881, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 242)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Profile Picture"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 5
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(215, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 26)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "UPLOAD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 5
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(119, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(19, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SELECT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(82, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 176)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 6
        '
        'studentOtherName
        '
        Me.studentOtherName.Location = New System.Drawing.Point(700, 32)
        Me.studentOtherName.Name = "studentOtherName"
        Me.studentOtherName.Size = New System.Drawing.Size(175, 22)
        Me.studentOtherName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(575, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Other Name"
        '
        'studentLastName
        '
        Me.studentLastName.Location = New System.Drawing.Point(382, 32)
        Me.studentLastName.Name = "studentLastName"
        Me.studentLastName.Size = New System.Drawing.Size(171, 22)
        Me.studentLastName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'studentFirstName
        '
        Me.studentFirstName.Location = New System.Drawing.Point(95, 32)
        Me.studentFirstName.Name = "studentFirstName"
        Me.studentFirstName.Size = New System.Drawing.Size(171, 22)
        Me.studentFirstName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.fatherAddress)
        Me.GroupBox3.Controls.Add(Me.fatherEmail)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.fatherTelephone)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.motherLastName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.fatherFirstName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 343)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(560, 260)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mothe's Details"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Address"
        '
        'fatherAddress
        '
        Me.fatherAddress.Location = New System.Drawing.Point(95, 118)
        Me.fatherAddress.Name = "fatherAddress"
        Me.fatherAddress.Size = New System.Drawing.Size(156, 70)
        Me.fatherAddress.TabIndex = 8
        Me.fatherAddress.Text = ""
        '
        'fatherEmail
        '
        Me.fatherEmail.Location = New System.Drawing.Point(389, 76)
        Me.fatherEmail.Name = "fatherEmail"
        Me.fatherEmail.Size = New System.Drawing.Size(156, 22)
        Me.fatherEmail.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(301, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Email"
        '
        'fatherTelephone
        '
        Me.fatherTelephone.Location = New System.Drawing.Point(95, 73)
        Me.fatherTelephone.Name = "fatherTelephone"
        Me.fatherTelephone.Size = New System.Drawing.Size(156, 22)
        Me.fatherTelephone.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Telephone"
        '
        'motherLastName
        '
        Me.motherLastName.Location = New System.Drawing.Point(389, 30)
        Me.motherLastName.Name = "motherLastName"
        Me.motherLastName.Size = New System.Drawing.Size(156, 22)
        Me.motherLastName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Name"
        '
        'fatherFirstName
        '
        Me.fatherFirstName.Location = New System.Drawing.Point(95, 30)
        Me.fatherFirstName.Name = "fatherFirstName"
        Me.fatherFirstName.Size = New System.Drawing.Size(156, 22)
        Me.fatherFirstName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "First Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.motherEmail)
        Me.GroupBox4.Controls.Add(Me.motherAddress)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.motherFirstName)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.motherTelephone)
        Me.GroupBox4.Controls.Add(Me.fatherLastName)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(584, 344)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(636, 260)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Father's Details"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Address"
        '
        'motherEmail
        '
        Me.motherEmail.Location = New System.Drawing.Point(399, 73)
        Me.motherEmail.Name = "motherEmail"
        Me.motherEmail.Size = New System.Drawing.Size(156, 22)
        Me.motherEmail.TabIndex = 7
        '
        'motherAddress
        '
        Me.motherAddress.Location = New System.Drawing.Point(105, 115)
        Me.motherAddress.Name = "motherAddress"
        Me.motherAddress.Size = New System.Drawing.Size(156, 70)
        Me.motherAddress.TabIndex = 8
        Me.motherAddress.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "First Name"
        '
        'motherFirstName
        '
        Me.motherFirstName.Location = New System.Drawing.Point(105, 27)
        Me.motherFirstName.Name = "motherFirstName"
        Me.motherFirstName.Size = New System.Drawing.Size(156, 22)
        Me.motherFirstName.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(311, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(311, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Last Name"
        '
        'motherTelephone
        '
        Me.motherTelephone.Location = New System.Drawing.Point(105, 70)
        Me.motherTelephone.Name = "motherTelephone"
        Me.motherTelephone.Size = New System.Drawing.Size(156, 22)
        Me.motherTelephone.TabIndex = 5
        '
        'fatherLastName
        '
        Me.fatherLastName.Location = New System.Drawing.Point(399, 27)
        Me.fatherLastName.Name = "fatherLastName"
        Me.fatherLastName.Size = New System.Drawing.Size(156, 22)
        Me.fatherLastName.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Telephone"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 10
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(238, 609)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(279, 44)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "SUBMIT DATA"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(342, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(429, 33)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "ADD NEW STUDENT RECORD"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(628, 610)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(279, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "CLEAR DATA"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'addStudentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1238, 661)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "addStudentRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student Record"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gender.ResumeLayout(False)
        Me.Gender.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents studentId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents studentOtherName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents studentLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents studentFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents fatherAddress As RichTextBox
    Friend WithEvents fatherEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents fatherTelephone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents motherLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents fatherFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents motherEmail As TextBox
    Friend WithEvents motherAddress As RichTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents motherFirstName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents motherTelephone As TextBox
    Friend WithEvents fatherLastName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents admission As TextBox
    Friend WithEvents graduation As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Gender As GroupBox
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents radioFemale As RadioButton
    Friend WithEvents studentClass As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents studentDate As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Button5 As Button
End Class
