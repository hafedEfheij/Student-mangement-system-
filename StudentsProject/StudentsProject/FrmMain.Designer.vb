<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.الطللبةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnadd = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnstudents = New System.Windows.Forms.ToolStripMenuItem()
        Me.الموادToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btncourses = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnmarks = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnabout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsstudents = New System.Windows.Forms.ToolStripButton()
        Me.tscourses = New System.Windows.Forms.ToolStripButton()
        Me.tdmarks = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ssname = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.الطللبةToolStripMenuItem, Me.الموادToolStripMenuItem, Me.مساعدةToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnexit})
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'btnexit
        '
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(180, 22)
        Me.btnexit.Text = "تسجيل الخروج"
        '
        'الطللبةToolStripMenuItem
        '
        Me.الطللبةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnadd, Me.btnstudents})
        Me.الطللبةToolStripMenuItem.Name = "الطللبةToolStripMenuItem"
        Me.الطللبةToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.الطللبةToolStripMenuItem.Text = "الطلبة"
        '
        'btnadd
        '
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(180, 22)
        Me.btnadd.Text = "اضافة "
        '
        'btnstudents
        '
        Me.btnstudents.Name = "btnstudents"
        Me.btnstudents.Size = New System.Drawing.Size(180, 22)
        Me.btnstudents.Text = "سجل الطلبة"
        '
        'الموادToolStripMenuItem
        '
        Me.الموادToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncourses, Me.btnmarks})
        Me.الموادToolStripMenuItem.Name = "الموادToolStripMenuItem"
        Me.الموادToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.الموادToolStripMenuItem.Text = "المواد"
        '
        'btncourses
        '
        Me.btncourses.Name = "btncourses"
        Me.btncourses.Size = New System.Drawing.Size(180, 22)
        Me.btncourses.Text = "المواد"
        '
        'btnmarks
        '
        Me.btnmarks.Name = "btnmarks"
        Me.btnmarks.Size = New System.Drawing.Size(180, 22)
        Me.btnmarks.Text = "درجات"
        '
        'مساعدةToolStripMenuItem
        '
        Me.مساعدةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnabout})
        Me.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem"
        Me.مساعدةToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.مساعدةToolStripMenuItem.Text = "مساعدة"
        '
        'btnabout
        '
        Me.btnabout.Name = "btnabout"
        Me.btnabout.Size = New System.Drawing.Size(180, 22)
        Me.btnabout.Text = "حول"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsstudents, Me.tscourses, Me.tdmarks})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsstudents
        '
        Me.tsstudents.Image = CType(resources.GetObject("tsstudents.Image"), System.Drawing.Image)
        Me.tsstudents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsstudents.Name = "tsstudents"
        Me.tsstudents.Size = New System.Drawing.Size(58, 22)
        Me.tsstudents.Text = "الطلبة"
        '
        'tscourses
        '
        Me.tscourses.Image = CType(resources.GetObject("tscourses.Image"), System.Drawing.Image)
        Me.tscourses.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tscourses.Name = "tscourses"
        Me.tscourses.Size = New System.Drawing.Size(56, 22)
        Me.tscourses.Text = "المواد"
        '
        'tdmarks
        '
        Me.tdmarks.Image = CType(resources.GetObject("tdmarks.Image"), System.Drawing.Image)
        Me.tdmarks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tdmarks.Name = "tdmarks"
        Me.tdmarks.Size = New System.Drawing.Size(66, 22)
        Me.tdmarks.Text = "الدرجات"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssname})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ssname
        '
        Me.ssname.Name = "ssname"
        Me.ssname.Size = New System.Drawing.Size(37, 17)
        Me.ssname.Text = "الاسم "
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الصفحة الرئيسية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ملفToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnexit As ToolStripMenuItem
    Friend WithEvents الطللبةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnadd As ToolStripMenuItem
    Friend WithEvents btnstudents As ToolStripMenuItem
    Friend WithEvents الموادToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btncourses As ToolStripMenuItem
    Friend WithEvents btnmarks As ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnabout As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsstudents As ToolStripButton
    Friend WithEvents tscourses As ToolStripButton
    Friend WithEvents tdmarks As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ssname As ToolStripStatusLabel
End Class
