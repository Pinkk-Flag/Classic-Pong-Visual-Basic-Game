<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.pnlGameArea = New System.Windows.Forms.Panel()
        Me.picBall = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.Label235R = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlGameArea.SuspendLayout()
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(64, 29)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(231, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Classic Pong"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 51)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player 1"
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("Papyrus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScore1.Location = New System.Drawing.Point(42, 211)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(41, 51)
        Me.lblScore1.TabIndex = 3
        Me.lblScore1.Text = "0"
        '
        'pnlGameArea
        '
        Me.pnlGameArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlGameArea.Controls.Add(Me.picBall)
        Me.pnlGameArea.Controls.Add(Me.picPlayer2)
        Me.pnlGameArea.Controls.Add(Me.picPlayer1)
        Me.pnlGameArea.Location = New System.Drawing.Point(147, 112)
        Me.pnlGameArea.Name = "pnlGameArea"
        Me.pnlGameArea.Size = New System.Drawing.Size(518, 326)
        Me.pnlGameArea.TabIndex = 4
        '
        'picBall
        '
        Me.picBall.Image = CType(resources.GetObject("picBall.Image"), System.Drawing.Image)
        Me.picBall.Location = New System.Drawing.Point(233, 139)
        Me.picBall.Name = "picBall"
        Me.picBall.Size = New System.Drawing.Size(27, 31)
        Me.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBall.TabIndex = 2
        Me.picBall.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.Image = Global.Classic_Pong.My.Resources.Resources.download
        Me.picPlayer2.Location = New System.Drawing.Point(476, 99)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(22, 106)
        Me.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer2.TabIndex = 1
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.Image = Global.Classic_Pong.My.Resources.Resources.download
        Me.picPlayer1.Location = New System.Drawing.Point(15, 99)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(22, 106)
        Me.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer1.TabIndex = 0
        Me.picPlayer1.TabStop = False
        '
        'Label235R
        '
        Me.Label235R.AutoSize = True
        Me.Label235R.Font = New System.Drawing.Font("Papyrus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label235R.Location = New System.Drawing.Point(671, 160)
        Me.Label235R.Name = "Label235R"
        Me.Label235R.Size = New System.Drawing.Size(141, 51)
        Me.Label235R.TabIndex = 5
        Me.Label235R.Text = "Player 2"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Font = New System.Drawing.Font("Papyrus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScore2.Location = New System.Drawing.Point(721, 211)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(41, 51)
        Me.lblScore2.TabIndex = 6
        Me.lblScore2.Text = "0"
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 76)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Player 1 - A and Z" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Player 2 - K and M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.Label235R)
        Me.Controls.Add(Me.pnlGameArea)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlGameArea.ResumeLayout(False)
        CType(Me.picBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents picBall As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents Label235R As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents tmrGame As Timer
    Friend WithEvents Label3 As Label
End Class
