using System.Linq;
using Windows.UI.Xaml.Controls;

namespace FlipViewContextPreview01for80
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            DataContext = new SampleData();
            InitializeComponent();

            // TODO testme only
            WinRTXamlToolkit.Debugging.DC.ShowVisualTree();
        }

        // TODO ListView event handler that keeps selected item in view
        private void ListViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            var listView = sender as ListView;
            if (listView != null && e != null && e.AddedItems.Count > 0)
            {
                listView.ScrollIntoView(e.AddedItems.First());
            }
        }
    }
}
