namespace KostičkaGame {
    public class GameManager {
        public static GameManager manager = new GameManager();
        GameForm gameForm;
        string user;
        public void start() {
            gameForm = new GameForm();
            gameForm.Show();
        }

        public void setUser(string name) {
            user = name;
        }
        public string userName() {
            return user;
        }
        public void AddScore(Kostka k) {
            gameForm.AddScore(k);
        }

        public void GetHurt(Kostka k) {
            gameForm.GetHurt(k);
        }
    }
}