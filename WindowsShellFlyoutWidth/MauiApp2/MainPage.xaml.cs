namespace MauiApp2 {
    public partial class MainPage : ContentPage {
        private int count;

        public MainPage() {
            InitializeComponent();            
        }

        private void OnCounterClicked(object sender, EventArgs e) {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            ((AppShell)Shell.Current).Counter = count;
        }
    }

}
