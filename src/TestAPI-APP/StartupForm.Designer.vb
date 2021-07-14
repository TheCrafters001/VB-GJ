<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gameID_txtBox = New System.Windows.Forms.TextBox()
        Me.privAPIKey_txtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.userToken_txtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userName_txtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game ID"
        '
        'gameID_txtBox
        '
        Me.gameID_txtBox.Location = New System.Drawing.Point(67, 12)
        Me.gameID_txtBox.Name = "gameID_txtBox"
        Me.gameID_txtBox.Size = New System.Drawing.Size(100, 20)
        Me.gameID_txtBox.TabIndex = 1
        Me.gameID_txtBox.Text = "607194"
        '
        'privAPIKey_txtBox
        '
        Me.privAPIKey_txtBox.Location = New System.Drawing.Point(99, 38)
        Me.privAPIKey_txtBox.Name = "privAPIKey_txtBox"
        Me.privAPIKey_txtBox.Size = New System.Drawing.Size(245, 20)
        Me.privAPIKey_txtBox.TabIndex = 3
        Me.privAPIKey_txtBox.Text = "2f1222b54cb623b7ad8fb55eea58869c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Private API Key"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 239)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(859, 523)
        Me.WebBrowser1.TabIndex = 4
        '
        'userToken_txtBox
        '
        Me.userToken_txtBox.Location = New System.Drawing.Point(81, 90)
        Me.userToken_txtBox.Name = "userToken_txtBox"
        Me.userToken_txtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.userToken_txtBox.Size = New System.Drawing.Size(100, 20)
        Me.userToken_txtBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "User Token"
        '
        'userName_txtBox
        '
        Me.userName_txtBox.Location = New System.Drawing.Point(73, 64)
        Me.userName_txtBox.Name = "userName_txtBox"
        Me.userName_txtBox.Size = New System.Drawing.Size(100, 20)
        Me.userName_txtBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Username"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Do The Thing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StartupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 774)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.userToken_txtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.userName_txtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.privAPIKey_txtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gameID_txtBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StartupForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gameID_txtBox As TextBox
    Friend WithEvents privAPIKey_txtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents userToken_txtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents userName_txtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
