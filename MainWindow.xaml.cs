using FarmFeed.Data;
using FarmFeed.Models;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FarmFeed
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using var db = new AppDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

        }
    }
}
