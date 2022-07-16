<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.outerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.innerTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.header = New System.Windows.Forms.Label()
        Me.submission = New System.Windows.Forms.Label()
        Me.temp = New System.Windows.Forms.Label()
        Me.name = New System.Windows.Forms.Label()
        Me.gender = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.contacts = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.left = New System.Windows.Forms.Button()
        Me.right = New System.Windows.Forms.Button()
        Me.pages = New System.Windows.Forms.Label()
        Me.outerTable.SuspendLayout()
        Me.innerTable.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'outerTable
        '
        Me.outerTable.ColumnCount = 3
        Me.outerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.outerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.Controls.Add(Me.innerTable, 1, 1)
        Me.outerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.outerTable.Location = New System.Drawing.Point(0, 0)
        Me.outerTable.Name = "outerTable"
        Me.outerTable.RowCount = 3
        Me.outerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.outerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.outerTable.Size = New System.Drawing.Size(780, 457)
        Me.outerTable.TabIndex = 0
        '
        'innerTable
        '
        Me.innerTable.BackColor = System.Drawing.SystemColors.Control
        Me.innerTable.ColumnCount = 3
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.innerTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.innerTable.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.innerTable.Controls.Add(Me.GroupBox1, 0, 1)
        Me.innerTable.Controls.Add(Me.GroupBox2, 2, 1)
        Me.innerTable.Controls.Add(Me.GroupBox3, 0, 2)
        Me.innerTable.Controls.Add(Me.GroupBox4, 2, 2)
        Me.innerTable.Controls.Add(Me.GroupBox5, 0, 3)
        Me.innerTable.Controls.Add(Me.GroupBox6, 0, 4)
        Me.innerTable.Controls.Add(Me.GroupBox7, 1, 4)
        Me.innerTable.Controls.Add(Me.header, 0, 0)
        Me.innerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.innerTable.Location = New System.Drawing.Point(23, 23)
        Me.innerTable.Name = "innerTable"
        Me.innerTable.RowCount = 6
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.innerTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.innerTable.Size = New System.Drawing.Size(734, 411)
        Me.innerTable.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel2.Controls.Add(Me.left, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.right, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.pages, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(247, 343)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(238, 65)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.innerTable.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.submission)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 62)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date and Time of Submission"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.temp)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(491, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 62)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Temperature"
        '
        'GroupBox3
        '
        Me.innerTable.SetColumnSpan(Me.GroupBox3, 2)
        Me.GroupBox3.Controls.Add(Me.name)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 62)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Full Name"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.gender)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(491, 139)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 62)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gender"
        '
        'GroupBox5
        '
        Me.innerTable.SetColumnSpan(Me.GroupBox5, 3)
        Me.GroupBox5.Controls.Add(Me.address)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 207)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(728, 62)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Complete Address"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.contacts)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 275)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(238, 62)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Contacts"
        '
        'GroupBox7
        '
        Me.innerTable.SetColumnSpan(Me.GroupBox7, 2)
        Me.GroupBox7.Controls.Add(Me.status)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Location = New System.Drawing.Point(247, 275)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(484, 62)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Status"
        '
        'header
        '
        Me.header.AutoSize = True
        Me.innerTable.SetColumnSpan(Me.header, 3)
        Me.header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.header.Font = New System.Drawing.Font("Century Gothic", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.header.Location = New System.Drawing.Point(3, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(728, 68)
        Me.header.TabIndex = 8
        Me.header.Text = "CT Database"
        Me.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'submission
        '
        Me.submission.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.submission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.submission.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.submission.Location = New System.Drawing.Point(3, 18)
        Me.submission.Name = "submission"
        Me.submission.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.submission.Size = New System.Drawing.Size(476, 41)
        Me.submission.TabIndex = 0
        Me.submission.Text = "Loading..."
        Me.submission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'temp
        '
        Me.temp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.temp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.temp.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.temp.Location = New System.Drawing.Point(3, 18)
        Me.temp.Name = "temp"
        Me.temp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.temp.Size = New System.Drawing.Size(234, 41)
        Me.temp.TabIndex = 0
        Me.temp.Text = "Loading..."
        Me.temp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'name
        '
        Me.name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.name.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.name.Location = New System.Drawing.Point(3, 18)
        Me.name.Name = "name"
        Me.name.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.name.Size = New System.Drawing.Size(476, 41)
        Me.name.TabIndex = 0
        Me.name.Text = "Loading..."
        Me.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gender
        '
        Me.gender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gender.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.gender.Location = New System.Drawing.Point(3, 18)
        Me.gender.Name = "gender"
        Me.gender.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.gender.Size = New System.Drawing.Size(234, 41)
        Me.gender.TabIndex = 0
        Me.gender.Text = "Loading..."
        Me.gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'address
        '
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.Dock = System.Windows.Forms.DockStyle.Fill
        Me.address.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.address.Location = New System.Drawing.Point(3, 18)
        Me.address.Name = "address"
        Me.address.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.address.Size = New System.Drawing.Size(722, 41)
        Me.address.TabIndex = 0
        Me.address.Text = "Loading..."
        Me.address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'contacts
        '
        Me.contacts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contacts.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.contacts.Location = New System.Drawing.Point(3, 18)
        Me.contacts.Name = "contacts"
        Me.contacts.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.contacts.Size = New System.Drawing.Size(232, 41)
        Me.contacts.TabIndex = 0
        Me.contacts.Text = "Loading..."
        Me.contacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'status
        '
        Me.status.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.status.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.status.Location = New System.Drawing.Point(3, 18)
        Me.status.Name = "status"
        Me.status.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.status.Size = New System.Drawing.Size(478, 41)
        Me.status.TabIndex = 0
        Me.status.Text = "Loading..."
        Me.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'left
        '
        Me.left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.left.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.left.Location = New System.Drawing.Point(3, 13)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(73, 39)
        Me.left.TabIndex = 0
        Me.left.Text = "<"
        Me.left.UseVisualStyleBackColor = True
        '
        'right
        '
        Me.right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.right.Font = New System.Drawing.Font("Century Gothic", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.right.Location = New System.Drawing.Point(161, 13)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(74, 39)
        Me.right.TabIndex = 1
        Me.right.Text = ">"
        Me.right.UseVisualStyleBackColor = True
        '
        'pages
        '
        Me.pages.AutoSize = True
        Me.pages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pages.Location = New System.Drawing.Point(82, 10)
        Me.pages.Name = "pages"
        Me.pages.Size = New System.Drawing.Size(73, 45)
        Me.pages.TabIndex = 2
        Me.pages.Text = "Loading..."
        Me.pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(780, 457)
        Me.Controls.Add(Me.outerTable)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "Form1"
        Me.Text = "Contact Tracing Viewer"
        Me.outerTable.ResumeLayout(False)
        Me.innerTable.ResumeLayout(False)
        Me.innerTable.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outerTable As TableLayoutPanel
    Friend WithEvents innerTable As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents left As Button
    Friend WithEvents right As Button
    Friend WithEvents pages As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents submission As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents temp As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents name As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gender As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents address As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents contacts As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents status As Label
    Friend WithEvents header As Label
End Class
