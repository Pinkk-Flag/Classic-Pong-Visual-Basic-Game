Public Class frmGame

    ' Initial movement speed of the ball in the X and Y directions
    Dim Deltax As Integer = 5
    Dim Deltay As Integer = 5

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event is triggered when the form is loaded
        ' You can add any additional setup code here
    End Sub

    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        ' Timer event that updates the game state at regular intervals

        ' Check if the ball hits the top or bottom of the game area
        If picBall.Top < 0 Or picBall.Top + picBall.Height > pnlGameArea.Height Then
            Deltay = -1 * Deltay  ' Reverse the vertical direction of the ball
        End If

        ' Move the ball based on the current speed in the X and Y directions
        picBall.Left = picBall.Left + Deltax
        picBall.Top = picBall.Top + Deltay

        ' Check if the ball collides with either player
        If Collide(picBall, picPlayer1) Or Collide(picBall, picPlayer2) Then
            Deltax = -1 * Deltax  ' Reverse the horizontal direction of the ball
        End If

        ' Check if the ball goes beyond the left boundary
        If picBall.Left < 0 Then
            lblScore2.Text = Val(lblScore2.Text) + 1
            Deltax = 5  ' Reset the horizontal speed
            picBall.Left = picPlayer1.Left + picPlayer1.Width  ' Reset the ball position
        End If

        ' Check if the ball goes beyond the right boundary
        If picBall.Left + picBall.Width > pnlGameArea.Width Then
            lblScore1.Text = Val(lblScore1.Text) + 1
            Deltax = -5  ' Reset the horizontal speed
            picBall.Left = picPlayer2.Left - picBall.Width  ' Reset the ball position
        End If

        ' Check if Player 1 reaches the winning score
        If Val(lblScore1.Text) = 5 Then
            tmrGame.Enabled = False  ' Disable the game timer
            MsgBox("Player 1 wins!")
        End If

        ' Check if Player 2 reaches the winning score
        If Val(lblScore2.Text) = 5 Then
            tmrGame.Enabled = False  ' Disable the game timer
            MsgBox("Player 2 wins!")
        End If
    End Sub

    Private Sub frmGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Handle key presses for player movement

        ' Player 1 controls
        If e.KeyCode = Keys.A Then
            If picPlayer1.Top > 20 Then
                picPlayer1.Top = picPlayer1.Top - 20  ' Move player 1 up
            End If
        End If
        If e.KeyCode = Keys.Z Then
            If picPlayer1.Top + picPlayer1.Height < pnlGameArea.Height - 20 Then
                picPlayer1.Top = picPlayer1.Top + 20  ' Move player 1 down
            End If
        End If

        ' Player 2 controls
        If e.KeyCode = Keys.K Then
            If picPlayer2.Top > 20 Then
                picPlayer2.Top = picPlayer2.Top - 20  ' Move player 2 up
            End If
        End If
        If e.KeyCode = Keys.M Then
            If picPlayer2.Top + picPlayer2.Height < pnlGameArea.Height - 20 Then
                picPlayer2.Top = picPlayer2.Top + 20  ' Move player 2 down
            End If
        End If
    End Sub

    Private Function Collide(ByVal ObjA As Object, ByVal ObjB As Object) As Boolean
        ' Check for collisions between objects

        ' Check if the collision involves the ball and a player
        If ObjA.GetType() = picBall.GetType() Then
            If ObjA.Bounds.IntersectsWith(ObjB.Bounds) Then
                Collide = True  ' Collision detected
            Else
                Collide = False  ' No collision
            End If
        Else
            ' Check if the collision involves an object and the top or bottom boundaries
            If ObjA.Top < 0 Or ObjA.Top + ObjA.Height > pnlGameArea.Height Then
                Collide = True  ' Collision detected
            Else
                Collide = False  ' No collision
            End If
        End If
    End Function

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        ' Start a new game

        ' Set initial ball position and speed
        picBall.Left = 180
        picBall.Top = 120
        Deltax = 5
        Deltay = 5

        ' Reset score labels
        lblScore1.Text = "0"
        lblScore2.Text = "0"

        ' Enable the game timer
        tmrGame.Enabled = True
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        ' End the application
        End
    End Sub

End Class
