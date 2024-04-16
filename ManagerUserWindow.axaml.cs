using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Threading;

namespace AvaloniaDesktopProject
{
    public partial class ManagerUserWindow : Window
    {
        private bool isMenuVisible = false;
        private DockPanel menuPanel;
        private Border bordersidebar;
        public ManagerUserWindow()
        {
            InitializeComponent();
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            menuPanel = this.FindControl<DockPanel>("MenuPanel");
            bordersidebar = this.FindControl<Border>("BorderSidebar");
        }

        private void ToggleMenu_Click(object sender, RoutedEventArgs e)
        {
            menuPanel.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;

            if (menuPanel.Width == 40)
            {
                menuPanel.Width = 150;
                bordersidebar.Width = 150;
                //тут просто возвращаем значения нашего user

                Status.Text = "Статус";
                Login.Text = "Логин";
                GoToAuthorization.IsVisible = true;
            }

            else
            {
                menuPanel.Width = 40;
                bordersidebar.Width = 40;
                Status.Text = "";
                Login.Text = "";
                GoToAuthorization.IsVisible = false;
            }

            isMenuVisible = !isMenuVisible;
        }

    }
}
