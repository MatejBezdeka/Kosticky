namespace KostičkaGame {
    public class GameManager {
        public static GameManager manager = new GameManager();
        private GameForm gameForm;
        public void start() {
            gameForm = new GameForm();
            gameForm.Show();
        }

        public void AddScore(Kostka k) {
            gameForm.AddScore(k);
        }

        public void GetHurt(Kostka k) {
            gameForm.GetHurt(k);
        }
    }
}