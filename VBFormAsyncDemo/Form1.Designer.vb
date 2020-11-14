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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWorking = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(35, 23)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(173, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Do some work one at a time"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lbCount
        '
        Me.lbCount.AutoSize = True
        Me.lbCount.Location = New System.Drawing.Point(90, 94)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(13, 15)
        Me.lbCount.TabIndex = 1
        Me.lbCount.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Progress: "
        '
        'lblWorking
        '
        Me.lblWorking.AutoSize = True
        Me.lblWorking.Location = New System.Drawing.Point(37, 120)
        Me.lblWorking.Name = "lblWorking"
        Me.lblWorking.Size = New System.Drawing.Size(66, 15)
        Me.lblWorking.TabIndex = 3
        Me.lblWorking.Text = "Not started"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 164)
        Me.Controls.Add(Me.lblWorking)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents lbCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWorking As Label
End Class
