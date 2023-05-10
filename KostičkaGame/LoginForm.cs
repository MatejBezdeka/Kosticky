using System;
using System.Windows.Forms;

namespace KostičkaGame {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e) {
            Hide();
            GameManager.manager.start();
        }
    }
}