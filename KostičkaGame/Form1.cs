using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostičkaGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        void NewGameButtonClick(object sender, EventArgs e) {
            LoginForm lf = new LoginForm();
            Hide();
            lf.Show();
        }
    }
}