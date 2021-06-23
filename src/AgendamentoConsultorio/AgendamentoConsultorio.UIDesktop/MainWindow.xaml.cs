using AgendamentoConsultorio.Domain.Models;
using AgendamentoConsultorio.Infra.Repositories;
using AgendamentoConsultorio.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendamentoConsultorio.UIDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var service = new DoctorService(new DoctorRepository("server=localhost;database=db_clinic;userid=developer;password=1234567;"));
            service.CreateNewDoctor(
                new Doctor("Gabriel", "Alergologista", "50156461862", 1200.5m, "Avenida 9 de Julho", "01313000")
            );
        }
    }
}
