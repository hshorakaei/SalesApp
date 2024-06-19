using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace SalesApp
{
    public partial class MainWindow : Window
    {
        private SalesContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new SalesContext();
            _context.Database.EnsureCreated();
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductsDataGrid.ItemsSource = _context.Products.ToList();
        }
    }
}
