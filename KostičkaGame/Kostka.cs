using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KostičkaGame {
    public class Kostka {
        private Random rn = new Random();
        
        private Panel panel;
        private int size = 20;
        private int health;
        private List<Color> barvy = new List<Color>() {
            Color.Green,
            Color.Blue,
            Color.Red
        };
        public Kostka(Panel playingField) {
            health = rn.Next(1, barvy.Count+1);
            panel = new Panel();
            panel.BackColor = barvy[health-1];
            panel.Size = new Size(size, size);
            panel.Left = rn.Next(0,playingField.Width - size);
            panel.Top = rn.Next(0, playingField.Height - size);
            panel.Click += (GetClicked);
            playingField.Controls.Add(panel);
        }

        void GetClicked(object sender, EventArgs e) {
            
                Die();
                //add score
                GameManager.manager.AddScore(this);
                return;
        }

        public bool TimePassed() {
            health--;
            if (health == 0) {
                //-- životy
                Die();
                GameManager.manager.GetHurt(this);
                return true;
            }
            UpdateColor();
            return false;
        }

        void UpdateColor() {
            panel.BackColor = barvy[health - 1];
        }
        void Die() {
            panel.Parent.Controls.Remove(panel);
        }
    }
}