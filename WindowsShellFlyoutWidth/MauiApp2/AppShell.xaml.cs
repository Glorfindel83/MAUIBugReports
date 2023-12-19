namespace MauiApp2 {
    public partial class AppShell : Shell {
        public AppShell() {
            BindingContext = this;
            InitializeComponent();
        }

        private int _counter;
        public int Counter { get => _counter; set { _counter = value; OnPropertyChanged(); } }
    }
}
