using AgendamentoConsultorio.Domain.Models;
using AgendamentoConsultorio.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AgendamentoConsultorio.UIDesktop.Views
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DoctorService _service;

        public MainWindow(DoctorService service)
        {
            InitializeComponent();

            _service = service;

            Console.WriteLine(_service);
        }
    }
}