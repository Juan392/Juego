Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
        playGame.Visible = False ' Oculta playGame al inicio
        Me.KeyPreview = True ' Permite que el formulario capture eventos de teclado
        Esfera3.Visible = False
        Esfera4.Visible = False
    End Sub

    Dim saltando As Boolean = False ' Para controlar si está en medio de un salto
    Dim bajando As Boolean = False 'Controla si baja
    Dim score As Integer = 0
    Dim nivel As Integer = 1
    Dim velocidadY As Integer = 0
    Dim alturaBase As Integer = 140
    Dim alturaInicial As Integer = 10
    Dim alturaMaxima As Integer = 160
    Dim velocidadAvance As Integer
    Dim direccion As Integer = -1 ' -1 para subir, 1 para bajar
    Dim movimientoHorizontal As Integer = 0 ' Controla la dirección horizontal (-1 para retroceder, 1 para avanzar)
    Dim velocidadHorizontal As Integer = 8

    Dim velocidadEsferas As Integer = 15

    Dim persiguiendo As Boolean = True ' Controla si Esfera1 está persiguiendo al personaje
    Dim juegoActivo As Boolean = False ' Controla si el juego está activo
    Dim juegoIniciado As Boolean = False ' Controla si el juego ya ha sido iniciado al menos una vez

    ' Manejo de teclas para controlar el salto
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Not juegoIniciado Then
            IniciarJuego()
        End If
        Select Case e.KeyCode
            Case Keys.A ' Desplazamiento hacia la izquirda
                Goku.Left -= velocidadHorizontal
                If Goku.Left < 0 Then Goku.Left = 0 'Es un marco para que no salga del juego

            Case Keys.D ' Salto hacia la derecha
                Goku.Left += velocidadHorizontal
                If Goku.Right > Me.ClientSize.Width Then 'Aqui evita que se pase del borde derecho
                    Goku.Left = Me.ClientSize.Width - Goku.Width
                End If

            Case Keys.W ' Salto
                If Not saltando Then
                    Saltar()
                End If

            Case Keys.S
                If Not bajando Then
                    Bajar()
                End If
        End Select
    End Sub

    ' Salto (gestiona el movimiento vertical y horizontal)
    Private Sub Saltar()
        If Not saltando Then
            alturaInicial = Goku.Top
            direccion = -1
            TimerGoku.Start()
            saltando = True
        End If
    End Sub

    Private Sub Bajar()
        If Not saltando Then
            bajando = True
            direccion = 1
            alturaInicial = Goku.Top
            TimerGoku.Start()
        End If
    End Sub

    ' Método para iniciar el juego
    Private Sub IniciarJuego()
        juegoActivo = True
        juegoIniciado = True
        playGame.Visible = False
        TimerGoku.Start()
        TimerEsfera2.Start()
        TimerEsfera1.Start()
        lblScore.Text = "SCORE: " & score
        lblnivel.Text = "NIVEL: " & nivel
    End Sub

    Private Sub SiguienteNivel()
        If score.Equals(10) AndAlso nivel = 1 Then
            nivel = 2
            Me.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\images (1).jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Goku.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\descarga-23-removebg-preview.png")
            Goku.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\8290c072c498d86394d68311e02cc991-removebg-preview.png")

            velocidadHorizontal = 15
            velocidadEsferas = 25

            Esfera1.Left += 25
            Esfera2.Left -= 25
            Esfera3.Visible = True
            Esfera4.Visible = True
            Esfera3.Top = -Esfera3.Height
            Esfera4.Top = Me.Height
            TimerEsfera3.Start()
            TimerEsfera4.Start()
            lblnivel.Text = "NIVEL: " & nivel

        ElseIf score.Equals(50) AndAlso nivel = 2 Then
            nivel = 3

            velocidadHorizontal = 20
            velocidadEsferas = 35
            Me.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\images (1).jpg")
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Goku.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\descarga-23-removebg-preview.png")
            Goku.BackgroundImageLayout = ImageLayout.Stretch
            PictureBox1.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\8290c072c498d86394d68311e02cc991-removebg-preview.png")

            Esfera1.Left += 25
            Esfera2.Left -= 25
        End If
    End Sub

    ' Movimiento del personaje en salto
    Private Sub TimerGoku_Tick(sender As Object, e As EventArgs) Handles TimerGoku.Tick
        ' Movimiento horizontal
        Goku.Left += velocidadAvance * movimientoHorizontal

        ' Movimiento vertical (salto)
        If saltando Then
            If direccion = -1 Then
                Goku.Top -= 15
                If Goku.Top <= alturaInicial - alturaMaxima Then
                    direccion = 1
                End If
            ElseIf direccion = 1 Then
                Goku.Top += 15
                If Goku.Top >= alturaInicial Then
                    Goku.Top = alturaInicial
                    direccion = -1
                    TimerGoku.Stop()
                    saltando = False
                End If
            End If

            'Movimiento vertical(bajar)
        ElseIf bajando Then
            If direccion = 1 Then ' Baja
                Goku.Top += 15
                If Goku.Top >= alturaInicial + 140 Then
                    direccion = -1
                End If
            ElseIf direccion = -1 Then
                Goku.Top -= 15
                If Goku.Top <= alturaInicial Then
                    Goku.Top = alturaInicial
                    bajando = False
                    TimerGoku.Stop()
                End If
            End If
        End If
    End Sub

    ' Movimiento continuo de Esfera1 desde la izquierda hacia la derecha
    Private Sub TimerEsfera1_Tick(sender As Object, e As EventArgs) Handles TimerEsfera2.Tick
        Esfera1.Left += velocidadEsferas
        If Esfera1.Bounds.IntersectsWith(Goku.Bounds) Then
            DetenerAnimaciones()
        End If
        If Esfera1.Left > Me.Width Then
            Esfera1.Left = -Esfera1.Width
            score += 1
            lblScore.Text = "SCORE: " & score
            SiguienteNivel()
        End If
    End Sub

    ' Movimiento continuo de Esfera2 desde la derecha hacia la izquierda
    Private Sub TimerEsfera2_Tick(sender As Object, e As EventArgs) Handles TimerEsfera1.Tick
        Esfera2.Left -= velocidadEsferas ' 
        If Esfera2.Bounds.IntersectsWith(Goku.Bounds) Then
            DetenerAnimaciones()
        End If
        If Esfera2.Left < -Esfera2.Width Then
            Esfera2.Left = Me.Width
            score += 1
            lblScore.Text = "SCORE: " & score
            SiguienteNivel()
        End If
    End Sub

    Private Sub TimerEsfera3_Tick(sender As Object, e As EventArgs) Handles TimerEsfera3.Tick
        Esfera3.Top += 25
        If Esfera3.Bounds.IntersectsWith(Goku.Bounds) Then
            DetenerAnimaciones()
        End If
        If Esfera3.Top > Me.Height Then
            Esfera3.Top = -Esfera3.Height
            score += 1
            lblScore.Text = "SCORE: " & score
            SiguienteNivel()
        End If
    End Sub

    Private Sub TimerEsfera4_Tick(sender As Object, e As EventArgs) Handles TimerEsfera4.Tick
        Esfera4.Top -= 25
        If Esfera4.Bounds.IntersectsWith(Goku.Bounds) Then
            DetenerAnimaciones()
        End If
        If Esfera4.Top < -Esfera4.Height Then
            Esfera4.Top = Me.Height
            score += 1
            lblScore.Text = "SCORE: " & score
            SiguienteNivel()
        End If
    End Sub

    ' Función para detener animaciones y mostrar el botón playGame
    Private Sub DetenerAnimaciones()
        bajando = False
        saltando = False
        TimerEsfera2.Stop()
        TimerEsfera1.Stop()
        TimerGoku.Stop()
        playGame.BringToFront()
        playGame.Visible = True
        juegoActivo = False
    End Sub

    ' Reiniciar el juego al hacer clic en playGame
    Private Sub playGame_Click(sender As Object, e As EventArgs) Handles playGame.Click
        score = 0
        nivel = 1
        velocidadHorizontal = 8
        velocidadEsferas = 15

        lblScore.Text = "SCORE: " & score
        lblnivel.Text = "NIVEL: " & nivel
        TimerEsfera3.Stop()
        TimerEsfera4.Stop()
        Esfera3.Visible = False
        Esfera4.Visible = False

        Goku.Top = alturaInicial
        Goku.Left = 600
        Esfera1.Left = -Esfera1.Width
        Esfera2.Left = Me.Width
        direccion = -1
        saltando = False
        persiguiendo = False
        juegoActivo = True
        juegoIniciado = True

        TimerEsfera1.Start()
        TimerEsfera2.Start()
        playGame.Visible = False

        Me.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\images.jpg")
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Goku.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\descargar__1_-removebg-preview.png")
        Goku.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BackgroundImage = Image.FromFile("C:\Users\jm994\Downloads\descargar__2_-removebg-preview.png")
    End Sub

    Private Sub Goku_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Esfera2_Click(sender As Object, e As EventArgs) Handles Esfera2.Click
    End Sub

    Private Sub Goku_Click_1(sender As Object, e As EventArgs) Handles Goku.Click
    End Sub

    Private Sub lblScore_Click(sender As Object, e As EventArgs) Handles lblScore.Click
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Esfera4.Click
    End Sub

End Class
