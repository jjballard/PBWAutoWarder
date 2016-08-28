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
        Me.butWard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoardID = New System.Windows.Forms.TextBox()
        Me.txtCharID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstPostIDs = New System.Windows.Forms.ListBox()
        Me.btnGetPosts = New System.Windows.Forms.Button()
        Me.cbxBoards = New System.Windows.Forms.ComboBox()
        Me.cbxChars = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'butWard
        '
        Me.butWard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butWard.Location = New System.Drawing.Point(98, 226)
        Me.butWard.Name = "butWard"
        Me.butWard.Size = New System.Drawing.Size(75, 23)
        Me.butWard.TabIndex = 0
        Me.butWard.Text = "Ward"
        Me.butWard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Board ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBoardID
        '
        Me.txtBoardID.Location = New System.Drawing.Point(67, 9)
        Me.txtBoardID.Name = "txtBoardID"
        Me.txtBoardID.Size = New System.Drawing.Size(158, 20)
        Me.txtBoardID.TabIndex = 2
        Me.txtBoardID.Text = "16412"
        '
        'txtCharID
        '
        Me.txtCharID.Location = New System.Drawing.Point(67, 35)
        Me.txtCharID.Name = "txtCharID"
        Me.txtCharID.Size = New System.Drawing.Size(205, 20)
        Me.txtCharID.TabIndex = 4
        Me.txtCharID.Text = "133861"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Char ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Post IDs"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(67, 123)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(205, 20)
        Me.txtTitle.TabIndex = 8
        Me.txtTitle.Text = "Reaper Ward"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Title"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBody
        '
        Me.txtBody.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBody.Location = New System.Drawing.Point(67, 149)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(205, 71)
        Me.txtBody.TabIndex = 10
        Me.txtBody.Text = "Standard Warding"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Body"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lstPostIDs
        '
        Me.lstPostIDs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstPostIDs.FormattingEnabled = True
        Me.lstPostIDs.HorizontalScrollbar = True
        Me.lstPostIDs.Items.AddRange(New Object() {"112649", "112687", "112720"})
        Me.lstPostIDs.Location = New System.Drawing.Point(67, 61)
        Me.lstPostIDs.Name = "lstPostIDs"
        Me.lstPostIDs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstPostIDs.Size = New System.Drawing.Size(205, 56)
        Me.lstPostIDs.TabIndex = 11
        '
        'btnGetPosts
        '
        Me.btnGetPosts.Location = New System.Drawing.Point(231, 9)
        Me.btnGetPosts.Name = "btnGetPosts"
        Me.btnGetPosts.Size = New System.Drawing.Size(41, 23)
        Me.btnGetPosts.TabIndex = 12
        Me.btnGetPosts.Text = "..."
        Me.btnGetPosts.UseVisualStyleBackColor = True
        '
        'cbxBoards
        '
        Me.cbxBoards.FormattingEnabled = True
        Me.cbxBoards.Location = New System.Drawing.Point(278, 8)
        Me.cbxBoards.Name = "cbxBoards"
        Me.cbxBoards.Size = New System.Drawing.Size(121, 21)
        Me.cbxBoards.TabIndex = 14
        '
        'cbxChars
        '
        Me.cbxChars.FormattingEnabled = True
        Me.cbxChars.Location = New System.Drawing.Point(278, 35)
        Me.cbxChars.Name = "cbxChars"
        Me.cbxChars.Size = New System.Drawing.Size(121, 21)
        Me.cbxChars.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 261)
        Me.Controls.Add(Me.cbxChars)
        Me.Controls.Add(Me.cbxBoards)
        Me.Controls.Add(Me.btnGetPosts)
        Me.Controls.Add(Me.lstPostIDs)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCharID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBoardID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butWard)
        Me.Name = "Form1"
        Me.Text = "Auto Warder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butWard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoardID As TextBox
    Friend WithEvents txtCharID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBody As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstPostIDs As ListBox
    Friend WithEvents btnGetPosts As Button
    Friend WithEvents cbxBoards As ComboBox
    Friend WithEvents cbxChars As ComboBox
End Class
