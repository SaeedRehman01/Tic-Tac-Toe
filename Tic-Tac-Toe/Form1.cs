namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        // Enum representing players X and O (AI)
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        Random rand = new Random();
        int playerWinCount = 0;
        int geniusAiWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            RestartGame();
        }

        // Genius AI (rule based strategy) makes a move
        private void AiMove(object sender, EventArgs e)
        {
            // Check for a winning move
            if (MakeStrategicMove(Player.O))
                return;

            // Block player's winning move
            if (MakeStrategicMove(Player.X))
                return;

            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Firebrick;
                buttons.RemoveAt(index);
                CheckGame();
                GeniusAITimer.Stop();
                EnableAllButtons();
            }
        }

        // Makes a strategic move for player O (AI) 
        private bool MakeStrategicMove(Player player)
        {
            foreach (Button button in buttons)
            {
                button.Text = player.ToString();
                if (CheckForWinner(player.ToString()))
                {
                    button.Text = Player.O.ToString();
                    button.Enabled = false;
                    button.BackColor = Color.Firebrick;
                    buttons.Remove(button);
                    CheckGame();
                    GeniusAITimer.Stop();
                    EnableAllButtons();
                    return true;
                }
                button.Text = "?";
            }
            return false;
        }

        // Handles click event when player X clicks on a button
        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.RoyalBlue;
            buttons.Remove(button);

            CheckGame();
            DisableAllButtons();
            GeniusAITimer.Start();
        }

        // Handles restart game button click event
        private void RestartGameButton(object sender, EventArgs e)
        {
            RestartGame();
        }

        // Checks the current state of the game and displays result when game is over
        private void CheckGame()
        {
            if (CheckForWinner("X"))
            {
                GeniusAITimer.Stop();
                MessageBox.Show( "Player Wins!", "W");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();
            }
            else if (CheckForWinner("O"))
            {
                GeniusAITimer.Stop();
                MessageBox.Show( "Genius AI Wins!", "L");
                geniusAiWinCount++;
                label2.Text = "Genius AI Wins: " + geniusAiWinCount;
                RestartGame();
            }
            else if (buttons.Count == 0)
            {
                MessageBox.Show( "It's a draw!", "Draw");
                RestartGame();
            }
        }

        // Checks which player has won the game or winning
        private bool CheckForWinner(string player)
        {
            return (button1.Text == player && button2.Text == player && button3.Text == player
                || button4.Text == player && button5.Text == player && button6.Text == player
                || button7.Text == player && button8.Text == player && button9.Text == player
                || button1.Text == player && button4.Text == player && button7.Text == player
                || button2.Text == player && button5.Text == player && button8.Text == player
                || button3.Text == player && button6.Text == player && button9.Text == player
                || button1.Text == player && button5.Text == player && button9.Text == player
                || button3.Text == player && button5.Text == player && button7.Text == player);
        }

        private void DisableAllButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void EnableAllButtons()
        {
            foreach (var button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = DefaultBackColor;
            }
        }


    }
}

