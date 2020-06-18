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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.Left_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.Score_Text = New System.Windows.Forms.Label()
        Me.Repaly_Butten = New System.Windows.Forms.Button()
        Me.Speed_Text = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox1.Location = New System.Drawing.Point(52, -26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Location = New System.Drawing.Point(160, -26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox4.Location = New System.Drawing.Point(160, 75)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox3.Location = New System.Drawing.Point(52, 75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox6.Location = New System.Drawing.Point(160, 188)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox5.Location = New System.Drawing.Point(52, 188)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox8.Location = New System.Drawing.Point(160, 307)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox7.Location = New System.Drawing.Point(52, 307)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 72)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'Left_Mover
        '
        Me.Left_Mover.Interval = 10
        '
        'Right_Mover
        '
        Me.Right_Mover.Interval = 10
        '
        'Car
        '
        Me.Car.Image = CType(resources.GetObject("Car.Image"), System.Drawing.Image)
        Me.Car.Location = New System.Drawing.Point(94, 257)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(33, 74)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 9
        Me.Car.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), System.Drawing.Image)
        Me.EnemyCar2.Location = New System.Drawing.Point(82, -28)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(33, 74)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 10
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar1
        '
        Me.EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), System.Drawing.Image)
        Me.EnemyCar1.Location = New System.Drawing.Point(3, 144)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(34, 72)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 11
        Me.EnemyCar1.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), System.Drawing.Image)
        Me.EnemyCar3.Location = New System.Drawing.Point(189, 36)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(34, 72)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 12
        Me.EnemyCar3.TabStop = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.End_Text.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(46, 75)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(123, 33)
        Me.End_Text.TabIndex = 13
        Me.End_Text.Text = "Game Over"
        Me.End_Text.Visible = False
        '
        'Score_Text
        '
        Me.Score_Text.AutoSize = True
        Me.Score_Text.Location = New System.Drawing.Point(2, 9)
        Me.Score_Text.Name = "Score_Text"
        Me.Score_Text.Size = New System.Drawing.Size(44, 13)
        Me.Score_Text.TabIndex = 15
        Me.Score_Text.Text = "Score 0"
        '
        'Repaly_Butten
        '
        Me.Repaly_Butten.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repaly_Butten.ForeColor = System.Drawing.Color.Red
        Me.Repaly_Butten.Location = New System.Drawing.Point(68, 124)
        Me.Repaly_Butten.Name = "Repaly_Butten"
        Me.Repaly_Butten.Size = New System.Drawing.Size(75, 33)
        Me.Repaly_Butten.TabIndex = 16
        Me.Repaly_Butten.Text = "Replay"
        Me.Repaly_Butten.UseVisualStyleBackColor = True
        Me.Repaly_Butten.Visible = False
        '
        'Speed_Text
        '
        Me.Speed_Text.AutoSize = True
        Me.Speed_Text.Location = New System.Drawing.Point(176, 9)
        Me.Speed_Text.Name = "Speed_Text"
        Me.Speed_Text.Size = New System.Drawing.Size(47, 13)
        Me.Speed_Text.TabIndex = 17
        Me.Speed_Text.Text = "Speed 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Speed_Text)
        Me.Controls.Add(Me.Repaly_Butten)
        Me.Controls.Add(Me.Score_Text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents Left_Mover As Timer
    Friend WithEvents Right_Mover As Timer
    Friend WithEvents Car As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents End_Text As Label
    Friend WithEvents Score_Text As Label
    Friend WithEvents Repaly_Butten As Button
    Friend WithEvents Speed_Text As Label
End Class
