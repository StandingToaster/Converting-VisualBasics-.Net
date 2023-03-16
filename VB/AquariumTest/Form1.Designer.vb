Namespace AquariumTest
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.button1 = New System.Windows.Forms.Button()
            Me.radioButtonUS = New System.Windows.Forms.RadioButton()
            Me.radioButtonUK = New System.Windows.Forms.RadioButton()
            Me.label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(105, 35)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 23)
            Me.button1.TabIndex = 0
            Me.button1.Text = "TEST"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' radioButtonUS
            ' 
            Me.radioButtonUS.AutoSize = True
            Me.radioButtonUS.Checked = True
            Me.radioButtonUS.Location = New System.Drawing.Point(122, 103)
            Me.radioButtonUS.Name = "radioButtonUS"
            Me.radioButtonUS.Size = New System.Drawing.Size(40, 17)
            Me.radioButtonUS.TabIndex = 2
            Me.radioButtonUS.TabStop = True
            Me.radioButtonUS.Text = "US"
            Me.radioButtonUS.UseVisualStyleBackColor = True
            ' 
            ' radioButtonUK
            ' 
            Me.radioButtonUK.AutoSize = True
            Me.radioButtonUK.Location = New System.Drawing.Point(122, 126)
            Me.radioButtonUK.Name = "radioButtonUK"
            Me.radioButtonUK.Size = New System.Drawing.Size(40, 17)
            Me.radioButtonUK.TabIndex = 3
            Me.radioButtonUK.Text = "UK"
            Me.radioButtonUK.UseVisualStyleBackColor = True
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(117, 84)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(51, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Location:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 262)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.radioButtonUK)
            Me.Controls.Add(Me.radioButtonUS)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents button1 As System.Windows.Forms.Button
        Private radioButtonUS As System.Windows.Forms.RadioButton
        Private radioButtonUK As System.Windows.Forms.RadioButton
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace

