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

namespace Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Event-Handler für das Click-Event des Buttons
        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            //Neuzuweisung der Content-Eigenschaft des Labels mit dem ausgewählten Inhalt der ComboBox
            Lbl_Output.Content = (Cbb_Auswahl.SelectedItem as ComboBoxItem)?.Content;

            //Änderung der Hintergrundfarbe des Fensters
            Wnd_Main.Background = new SolidColorBrush(Colors.Blue);

            //MessageBox mit dem Inhalt der TextBox
            MessageBox.Show(Tbx_Input.Text);

            //Prüfung, ob die Checkbox abgehakt ist
            if (Cbx_Haken.IsChecked == true)
                //Anzeige einer MessageBox mit Inhalt der TextBox und Auswahl der ComboBox
                MessageBox.Show(Tbx_Input.Text + "\n" + Cbb_Auswahl.Text);
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            //Öffen eines neuen Fensters als gleichberechtigtes Fenster
            new MainWindow().Show();
        }

        private void OpenDialogWindow(object sender, RoutedEventArgs e)
        {
            //Öffnen eines neuen Fensters als Dialogfenster mit Rückgabe des DialogResults
            bool? dialogresult = new MainWindow() { Title = "Neues Dialogfenster" }.ShowDialog();
            MessageBox.Show(dialogresult.ToString());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //nachfrage per MessageBox, ob Fenster geschlossen werden sollte
            if(MessageBox.Show("Möchtest du das Fenster wirklich schließen?", "Warnung", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                //Schließen des Fensters
                this.Close();


            //Beenden der Applikation
            //Application.Current.Shutdown();
        }
    }
}
