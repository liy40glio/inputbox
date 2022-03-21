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
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(483, 245)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(197, 23)
        Me.btnClick.TabIndex = 0
        Me.btnClick.Text = "CLICK HERE"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(207, 148)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(473, 23)
        Me.txtName.TabIndex = 1
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(93, 156)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(96, 15)
        Me.LabelName.TabIndex = 2
        Me.LabelName.Text = "Enter Your Name"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(93, 317)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 15)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Result"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(93, 198)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(93, 15)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "Enter Your State "
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(207, 198)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(473, 23)
        Me.txtState.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 450)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClick)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As MaskedTextBox
End Class
