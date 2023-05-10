using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace KostičkaGame {
    public partial class GameForm : Form {
        int health = 30;
        int score = 0;
        private List<Kostka> listKostek = new List<Kostka>();
        public GameForm() {
            InitializeComponent();
        }
        private void timer1_Elapsed(object sender, ElapsedEventArgs e) {
            for (int i = 0; i < listKostek.Count; i++) {
                Kostka k = listKostek[i];
                if (k.TimePassed()) {
                    i--;
                    
                }
            }
            Kostka a = new Kostka(PlayingPanel);
            listKostek.Add(a);
        }

        public void GetHurt(Kostka k) {
            listKostek.Remove(k);
            health--;
            LivesLabel.Text = "Lives: " + health;
        }

        public void AddScore(Kostka k) {
            listKostek.Remove(k);
            score++;
            ScoreLabel.Text = "Score: " + score;
        }
    }
}