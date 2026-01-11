<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Goku = New PictureBox()
        Esfera2 = New PictureBox()
        Esfera1 = New PictureBox()
        playGame = New Button()
        TimerGoku = New Timer(components)
        TimerEsfera2 = New Timer(components)
        TimerEsfera1 = New Timer(components)
        Timer4 = New Timer(components)
        lblScore = New Label()
        Esfera3 = New PictureBox()
        Esfera4 = New PictureBox()
        TimerEsfera3 = New Timer(components)
        TimerEsfera4 = New Timer(components)
        lblnivel = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Goku, ComponentModel.ISupportInitialize).BeginInit()
        CType(Esfera2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Esfera1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Esfera3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Esfera4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(642, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 163)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Goku
        ' 
        Goku.BackColor = Color.Transparent
        Goku.BackgroundImage = CType(resources.GetObject("Goku.BackgroundImage"), Image)
        Goku.BackgroundImageLayout = ImageLayout.Stretch
        Goku.Location = New Point(642, 382)
        Goku.Name = "Goku"
        Goku.Size = New Size(116, 180)
        Goku.SizeMode = PictureBoxSizeMode.Zoom
        Goku.TabIndex = 1
        Goku.TabStop = False
        ' 
        ' Esfera2
        ' 
        Esfera2.BackColor = Color.Transparent
        Esfera2.BackgroundImage = CType(resources.GetObject("Esfera2.BackgroundImage"), Image)
        Esfera2.BackgroundImageLayout = ImageLayout.Stretch
        Esfera2.Cursor = Cursors.AppStarting
        Esfera2.Location = New Point(1240, 413)
        Esfera2.Margin = New Padding(1)
        Esfera2.Name = "Esfera2"
        Esfera2.Padding = New Padding(0, 1, 1, 1)
        Esfera2.Size = New Size(55, 53)
        Esfera2.TabIndex = 2
        Esfera2.TabStop = False
        ' 
        ' Esfera1
        ' 
        Esfera1.BackColor = Color.Transparent
        Esfera1.BackgroundImage = CType(resources.GetObject("Esfera1.BackgroundImage"), Image)
        Esfera1.BackgroundImageLayout = ImageLayout.Stretch
        Esfera1.Location = New Point(23, 484)
        Esfera1.Name = "Esfera1"
        Esfera1.Padding = New Padding(5, 0, 0, 0)
        Esfera1.Size = New Size(54, 55)
        Esfera1.TabIndex = 3
        Esfera1.TabStop = False
        ' 
        ' playGame
        ' 
        playGame.BackColor = Color.Transparent
        playGame.BackgroundImage = CType(resources.GetObject("playGame.BackgroundImage"), Image)
        playGame.BackgroundImageLayout = ImageLayout.Stretch
        playGame.FlatStyle = FlatStyle.Flat
        playGame.Location = New Point(661, 655)
        playGame.Name = "playGame"
        playGame.Size = New Size(84, 86)
        playGame.TabIndex = 5
        playGame.UseVisualStyleBackColor = False
        ' 
        ' TimerGoku
        ' 
        ' 
        ' TimerEsfera2
        ' 
        ' 
        ' TimerEsfera1
        ' 
        ' 
        ' lblScore
        ' 
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Segoe UI", 20F)
        lblScore.Image = My.Resources.Resources.descargar_removebg_preview
        lblScore.Location = New Point(1119, 1)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(214, 194)
        lblScore.TabIndex = 6
        lblScore.Text = "SCORE:"
        lblScore.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Esfera3
        ' 
        Esfera3.BackColor = Color.Transparent
        Esfera3.BackgroundImage = CType(resources.GetObject("Esfera3.BackgroundImage"), Image)
        Esfera3.BackgroundImageLayout = ImageLayout.Stretch
        Esfera3.Cursor = Cursors.AppStarting
        Esfera3.Location = New Point(424, 29)
        Esfera3.Margin = New Padding(1)
        Esfera3.Name = "Esfera3"
        Esfera3.Padding = New Padding(0, 1, 1, 1)
        Esfera3.Size = New Size(55, 53)
        Esfera3.TabIndex = 7
        Esfera3.TabStop = False
        ' 
        ' Esfera4
        ' 
        Esfera4.BackColor = Color.Transparent
        Esfera4.BackgroundImage = CType(resources.GetObject("Esfera4.BackgroundImage"), Image)
        Esfera4.BackgroundImageLayout = ImageLayout.Stretch
        Esfera4.Cursor = Cursors.AppStarting
        Esfera4.Location = New Point(860, 29)
        Esfera4.Margin = New Padding(1)
        Esfera4.Name = "Esfera4"
        Esfera4.Padding = New Padding(0, 1, 1, 1)
        Esfera4.Size = New Size(55, 53)
        Esfera4.TabIndex = 8
        Esfera4.TabStop = False
        ' 
        ' TimerEsfera3
        ' 
        ' 
        ' TimerEsfera4
        ' 
        ' 
        ' lblnivel
        ' 
        lblnivel.BackColor = Color.Transparent
        lblnivel.Font = New Font("Segoe UI", 20F)
        lblnivel.Image = My.Resources.Resources.descargar_removebg_preview
        lblnivel.Location = New Point(-5, 1)
        lblnivel.Name = "lblnivel"
        lblnivel.Size = New Size(214, 194)
        lblnivel.TabIndex = 9
        lblnivel.Text = "NIVEL:"
        lblnivel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1326, 753)
        Controls.Add(lblnivel)
        Controls.Add(Esfera4)
        Controls.Add(Esfera3)
        Controls.Add(lblScore)
        Controls.Add(playGame)
        Controls.Add(Esfera1)
        Controls.Add(Esfera2)
        Controls.Add(Goku)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Goku, ComponentModel.ISupportInitialize).EndInit()
        CType(Esfera2, ComponentModel.ISupportInitialize).EndInit()
        CType(Esfera1, ComponentModel.ISupportInitialize).EndInit()
        CType(Esfera3, ComponentModel.ISupportInitialize).EndInit()
        CType(Esfera4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Goku As PictureBox
    Friend WithEvents Esfera2 As PictureBox
    Friend WithEvents Esfera1 As PictureBox
    Friend WithEvents playGame As Button
    Friend WithEvents TimerGoku As Timer
    Friend WithEvents TimerEsfera2 As Timer
    Friend WithEvents TimerEsfera1 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents Esfera3 As PictureBox
    Friend WithEvents Esfera4 As PictureBox
    Friend WithEvents TimerEsfera3 As Timer
    Friend WithEvents TimerEsfera4 As Timer
    Friend WithEvents lblnivel As Label

End Class
