<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUIDesktop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUIDesktop))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiniNoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserSystemBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickOpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserCoreShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutUserOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToShellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitUserOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationsToolStripMenuItem, Me.SystemToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 365)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(590, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 35)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(544, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(49, 35)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.UserOS.My.Resources.Resources.Shortcuts
        Me.PictureBox4.Location = New System.Drawing.Point(12, 125)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.UserOS.My.Resources.Resources.Configure_alt_1
        Me.PictureBox3.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UserOS.My.Resources.Resources.Command_Prompt
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiniNoteToolStripMenuItem, Me.UserSystemBrowserToolStripMenuItem, Me.QuickOpenToolStripMenuItem})
        Me.ApplicationsToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Windows_alt
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'MiniNoteToolStripMenuItem
        '
        Me.MiniNoteToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Notepad
        Me.MiniNoteToolStripMenuItem.Name = "MiniNoteToolStripMenuItem"
        Me.MiniNoteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MiniNoteToolStripMenuItem.Text = "MiniNote"
        '
        'UserSystemBrowserToolStripMenuItem
        '
        Me.UserSystemBrowserToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Blank_Folder
        Me.UserSystemBrowserToolStripMenuItem.Name = "UserSystemBrowserToolStripMenuItem"
        Me.UserSystemBrowserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserSystemBrowserToolStripMenuItem.Text = "UserSystem Browser"
        '
        'QuickOpenToolStripMenuItem
        '
        Me.QuickOpenToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Shortcuts
        Me.QuickOpenToolStripMenuItem.Name = "QuickOpenToolStripMenuItem"
        Me.QuickOpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuickOpenToolStripMenuItem.Text = "QuickOpen"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsPanelToolStripMenuItem, Me.UserCoreShellToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutUserOSToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToShellToolStripMenuItem, Me.ExitUserOSToolStripMenuItem})
        Me.SystemToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Tasks
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'SettingsPanelToolStripMenuItem
        '
        Me.SettingsPanelToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Configure_alt_1
        Me.SettingsPanelToolStripMenuItem.Name = "SettingsPanelToolStripMenuItem"
        Me.SettingsPanelToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SettingsPanelToolStripMenuItem.Text = "Settings Panel"
        '
        'UserCoreShellToolStripMenuItem
        '
        Me.UserCoreShellToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Command_Prompt
        Me.UserCoreShellToolStripMenuItem.Name = "UserCoreShellToolStripMenuItem"
        Me.UserCoreShellToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.UserCoreShellToolStripMenuItem.Text = "UserCore Shell"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'AboutUserOSToolStripMenuItem
        '
        Me.AboutUserOSToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Windows1
        Me.AboutUserOSToolStripMenuItem.Name = "AboutUserOSToolStripMenuItem"
        Me.AboutUserOSToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AboutUserOSToolStripMenuItem.Text = "About UserOS"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(147, 6)
        '
        'ExitToShellToolStripMenuItem
        '
        Me.ExitToShellToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Command_Prompt
        Me.ExitToShellToolStripMenuItem.Name = "ExitToShellToolStripMenuItem"
        Me.ExitToShellToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToShellToolStripMenuItem.Text = "Exit to Shell"
        '
        'ExitUserOSToolStripMenuItem
        '
        Me.ExitUserOSToolStripMenuItem.Image = Global.UserOS.My.Resources.Resources.Power___Shut_Down
        Me.ExitUserOSToolStripMenuItem.Name = "ExitUserOSToolStripMenuItem"
        Me.ExitUserOSToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitUserOSToolStripMenuItem.Text = "Exit UserOS"
        '
        'GUIDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(650, 389)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "GUIDesktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserOS Graphical Desktop"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MiniNoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickOpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents UserSystemBrowserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsPanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserCoreShellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AboutUserOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToShellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitUserOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
