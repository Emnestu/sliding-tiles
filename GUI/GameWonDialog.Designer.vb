<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameWonDialog
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
        Me.PlayExitPrompt = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PlayAgainBtn = New System.Windows.Forms.Button()
        Me.myFlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContinueBtn = New System.Windows.Forms.Button()
        Me.myGroupBox = New System.Windows.Forms.GroupBox()
        Me.SponsorPicture = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.myFlowLayout.SuspendLayout()
        Me.myGroupBox.SuspendLayout()
        CType(Me.SponsorPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlayExitPrompt
        '
        Me.PlayExitPrompt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayExitPrompt.AutoSize = True
        Me.PlayExitPrompt.Location = New System.Drawing.Point(3, 3)
        Me.PlayExitPrompt.Margin = New System.Windows.Forms.Padding(3)
        Me.PlayExitPrompt.Name = "PlayExitPrompt"
        Me.PlayExitPrompt.Size = New System.Drawing.Size(150, 48)
        Me.PlayExitPrompt.TabIndex = 0
        Me.PlayExitPrompt.Text = "What would you like to do next?"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.PlayExitPrompt)
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(167, 55)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'ExitBtn
        '
        Me.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ExitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ExitBtn.Location = New System.Drawing.Point(84, 3)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(78, 23)
        Me.ExitBtn.TabIndex = 1
        Me.ExitBtn.Text = "&Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'PlayAgainBtn
        '
        Me.PlayAgainBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PlayAgainBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayAgainBtn.Location = New System.Drawing.Point(3, 3)
        Me.PlayAgainBtn.Name = "PlayAgainBtn"
        Me.PlayAgainBtn.Size = New System.Drawing.Size(75, 23)
        Me.PlayAgainBtn.TabIndex = 0
        Me.PlayAgainBtn.Text = "Play &Again"
        Me.PlayAgainBtn.UseVisualStyleBackColor = True
        '
        'myFlowLayout
        '
        Me.myFlowLayout.Controls.Add(Me.PlayAgainBtn)
        Me.myFlowLayout.Controls.Add(Me.ExitBtn)
        Me.myFlowLayout.Controls.Add(Me.ContinueBtn)
        Me.myFlowLayout.Location = New System.Drawing.Point(0, 56)
        Me.myFlowLayout.Name = "myFlowLayout"
        Me.myFlowLayout.Size = New System.Drawing.Size(167, 65)
        Me.myFlowLayout.TabIndex = 0
        '
        'ContinueBtn
        '
        Me.ContinueBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ContinueBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ContinueBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ContinueBtn.Location = New System.Drawing.Point(3, 32)
        Me.ContinueBtn.Name = "ContinueBtn"
        Me.ContinueBtn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ContinueBtn.Size = New System.Drawing.Size(159, 23)
        Me.ContinueBtn.TabIndex = 2
        Me.ContinueBtn.Text = "&Continue"
        Me.ContinueBtn.UseVisualStyleBackColor = True
        '
        'myGroupBox
        '
        Me.myGroupBox.Controls.Add(Me.SponsorPicture)
        Me.myGroupBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.myGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.myGroupBox.Location = New System.Drawing.Point(168, 0)
        Me.myGroupBox.Name = "myGroupBox"
        Me.myGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.myGroupBox.Size = New System.Drawing.Size(166, 121)
        Me.myGroupBox.TabIndex = 2
        Me.myGroupBox.TabStop = False
        Me.myGroupBox.Text = "Message from our sponsors.."
        '
        'SponsorPicture
        '
        Me.SponsorPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SponsorPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SponsorPicture.Image = Global.GUI.My.Resources.Resources.Horns_and_hooves_caption
        Me.SponsorPicture.Location = New System.Drawing.Point(3, 16)
        Me.SponsorPicture.Name = "SponsorPicture"
        Me.SponsorPicture.Size = New System.Drawing.Size(160, 102)
        Me.SponsorPicture.TabIndex = 0
        Me.SponsorPicture.TabStop = False
        '
        'GameWonDialog
        '
        Me.AcceptButton = Me.PlayAgainBtn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.ContinueBtn
        Me.ClientSize = New System.Drawing.Size(334, 121)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.myGroupBox)
        Me.Controls.Add(Me.myFlowLayout)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 160)
        Me.MinimumSize = New System.Drawing.Size(350, 160)
        Me.Name = "GameWonDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Congratulations, you won!"
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.myFlowLayout.ResumeLayout(False)
        Me.myGroupBox.ResumeLayout(False)
        CType(Me.SponsorPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayExitPrompt As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents PlayAgainBtn As System.Windows.Forms.Button
    Friend WithEvents myFlowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents myGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ContinueBtn As System.Windows.Forms.Button
    Friend WithEvents SponsorPicture As System.Windows.Forms.PictureBox

    Public Event ButtonClicked(s As String)

    Private Sub PlayAgainBtn_Click(sender As Object, e As EventArgs) Handles PlayAgainBtn.Click
        RaiseEvent ButtonClicked("Play")
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        RaiseEvent ButtonClicked("Exit")
    End Sub

    Private Sub SponsorPicture_Click(sender As Object, e As EventArgs) Handles SponsorPicture.Click
        RaiseEvent ButtonClicked("Sponsor")
    End Sub

    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        RaiseEvent ButtonClicked("Continue")
    End Sub

    Private Sub GameWonDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub GameWonDialog_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        RaiseEvent ButtonClicked("Continue")
    End Sub
End Class
