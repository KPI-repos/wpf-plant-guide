using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpf_plant_guide.Repository;

namespace wpf_plant_guide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IPlantRepository _plantRepository;

        public MainWindow(IPlantRepository plantRepository)
        {
            InitializeComponent();
            _plantRepository = plantRepository;

            var plants = _plantRepository.GetAllAsync();
            foreach (var plant in plants.Result)
            {
                Console.WriteLine($"ID: {plant.PlantId}, Common Name: {plant.CommonName}, Scientific Name: {plant.ScientificName}");
            }
        }
    }
}