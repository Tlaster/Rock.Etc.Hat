using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Rock.Etc.Hat.Avalonia.Controls.Paging;

namespace Rock.Etc.Hat.Avalonia.Activities
{
    public class IndexActivity : Activity
    {
        public IndexActivity()
        {
            var button = new Button {Content = "Go back!"};
            button.Click += ButtonOnClick;
            Content = new StackPanel
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Children =
                {
                    button,
                    new TextBox()
                }
            };
        }

        private void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            Finish();
        }
    }
}