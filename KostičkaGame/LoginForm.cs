using System;
using System.Windows.Forms;

namespace KostičkaGame {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        void LogInButton_Click(object sender, EventArgs e) {
            //kontroluje jestli jméno není jen mezera
            string user = textBox1.Text.Replace(" ", String.Empty);
            if (user == "") {
                textBox1.Text = "";
                return;
            }
            
            Hide();
            GameManager.manager.start();
            GameManager.manager.setUser(user);
        }
    }
}