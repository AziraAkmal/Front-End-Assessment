<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.create = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.n = New System.Windows.Forms.TextBox()
        Me.gender = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.updation = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.display = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'create
        '
        Me.create.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.create.Location = New System.Drawing.Point(160, 349)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(88, 35)
        Me.create.TabIndex = 0
        Me.create.Text = "CREATE"
        Me.create.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.Label1.Location = New System.Drawing.Point(194, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FRONT-END ASSESSMENT"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(325, 103)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 22)
        Me.id.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(269, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(247, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(223, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "GENDER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(247, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "EMAIL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(227, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "STATUS"
        '
        'n
        '
        Me.n.Location = New System.Drawing.Point(325, 139)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(263, 22)
        Me.n.TabIndex = 8
        '
        'gender
        '
        Me.gender.Location = New System.Drawing.Point(325, 204)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(100, 22)
        Me.gender.TabIndex = 9
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(325, 173)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(263, 22)
        Me.email.TabIndex = 10
        '
        'status
        '
        Me.status.BackColor = System.Drawing.SystemColors.Window
        Me.status.Location = New System.Drawing.Point(325, 241)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(138, 22)
        Me.status.TabIndex = 11
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.search.Location = New System.Drawing.Point(294, 349)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(89, 35)
        Me.search.TabIndex = 12
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = False
        '
        'updation
        '
        Me.updation.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.updation.Location = New System.Drawing.Point(424, 349)
        Me.updation.Name = "updation"
        Me.updation.Size = New System.Drawing.Size(91, 35)
        Me.updation.TabIndex = 13
        Me.updation.Text = "UPDATE"
        Me.updation.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Location = New System.Drawing.Point(556, 349)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(142, 35)
        Me.delete.TabIndex = 14
        Me.delete.Text = "DELETE DATA"
        Me.delete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(74, 414)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(675, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Location = New System.Drawing.Point(789, 92)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(46, 17)
        Me.label7.TabIndex = 16
        Me.label7.Text = "POST"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Location = New System.Drawing.Point(757, 281)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(78, 17)
        Me.label8.TabIndex = 17
        Me.label8.Text = "COMMENT"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Location = New System.Drawing.Point(777, 490)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(58, 17)
        Me.label9.TabIndex = 18
        Me.label9.Text = "TODOS"
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.clear.Location = New System.Drawing.Point(356, 605)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(91, 35)
        Me.clear.TabIndex = 22
        Me.clear.Text = "CLEAR"
        Me.clear.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.SystemColors.ControlDark
        Me.logout.Location = New System.Drawing.Point(175, 605)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(91, 35)
        Me.logout.TabIndex = 23
        Me.logout.Text = "EXIT"
        Me.logout.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(853, 92)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(394, 150)
        Me.DataGridView2.TabIndex = 24
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(853, 281)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(394, 150)
        Me.DataGridView3.TabIndex = 25
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(853, 490)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(394, 150)
        Me.DataGridView4.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(48, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 119)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "P/S:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO SEARCH, UPDATE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND DELETE, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SIMPLY INSERT THE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID NUMBER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OR CLICKED " &
    "ON" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE DATAGRIDVIEW"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Label12.Location = New System.Drawing.Point(469, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "new user don't need to fill this part"
        '
        'display
        '
        Me.display.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.display.Location = New System.Drawing.Point(533, 605)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(142, 35)
        Me.display.TabIndex = 37
        Me.display.Text = "DISPLAY DATA"
        Me.display.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1290, 723)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.updation)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.create)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents create As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents n As TextBox
    Friend WithEvents gender As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents status As TextBox
    Friend WithEvents search As Button
    Friend WithEvents updation As Button
    Friend WithEvents delete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents label7 As Label
    Friend WithEvents label8 As Label
    Friend WithEvents label9 As Label
    Friend WithEvents clear As Button
    Friend WithEvents logout As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents display As Button
End Class
