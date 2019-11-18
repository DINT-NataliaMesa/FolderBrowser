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




namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.DataContext = this;
        }

       
        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Titulo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TituloProperty =
            DependencyProperty.Register("Titulo", typeof(string), typeof(UserControl1), new PropertyMetadata(""));







        public string Contenido
        {
            get { return (string)GetValue(ContenidoProperty); }
            set { SetValue(ContenidoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Contenido.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContenidoProperty =
            DependencyProperty.Register("Contenido", typeof(string), typeof(UserControl1), new PropertyMetadata(""));

        private void SeleccionarButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogo = new System.Windows.Forms.FolderBrowserDialog();

            System.Windows.Forms.DialogResult resultado = dialogo.ShowDialog();


            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = dialogo.SelectedPath;

                Contenido = ruta;

                

            }
        }
    }
}
