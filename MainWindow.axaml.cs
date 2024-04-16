using Avalonia.Controls;

namespace AvaloniaDesktopProject
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RegistrationWindow p = new RegistrationWindow();
            ManagerUserWindow w = new ManagerUserWindow();

            w.Show();
            p.Show();
        }
    }
}