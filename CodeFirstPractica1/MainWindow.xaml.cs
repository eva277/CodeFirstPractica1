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
using System.Linq;
using CodeFirstPractica1.DAL;
using CodeFirstPractica1.Model;

namespace CodeFirstPractica1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Contacto contacto;
        PropertyValidateModel validador = new PropertyValidateModel();
        private UnitOfWork uow = new UnitOfWork();

        public MainWindow()
        {
            InitializeComponent();
            contacto = new Contacto();
            DataContext = contacto;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            contacto.Nombre = textBoxNombre.Text;
            contacto.Telefono=texBoxTfno.Text;
            contacto.Email = textBoxMail.Text;
            if (validador.errrores(contacto) != "")
            {
                MessageBox.Show(validador.errrores(contacto));
            }
            else
            {
                uow.RepositorioContacto.Insert(contacto);
                uow.Save();
            }
        }

        private void ModificateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DropButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
