using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AsyncAwaitWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Event-Handler für den synchronen Arbeitsschritt
        private void SyncButton_Click(object sender, RoutedEventArgs e)
        {
            StatusTextBlock.Text = "Status: läuft synchronisiert arbeitsschritte, dauer 5 sek...";
            DoSynchronousWork();
            StatusTextBlock.Text = "Status: Synchronisiert arbeit beeendet.";
        }

        // Event-Handler für den asynchronen Arbeitsschritt
        private async void AsyncButton_Click(object sender, RoutedEventArgs e)
        {
            StatusTextBlock.Text = "Status: läuft aynchrone arbeitsschritte, dauer 5 sek...";
            await DoAsynchronousWork();
            StatusTextBlock.Text = "Status: Asynchronisierte arbeit beeendet.";
        }

        // Eine Methode, die synchronen Arbeitsschritt ausführt
        private void DoSynchronousWork()
        {
            // Simuliert eine synchrone, blockierende Arbeit
            Thread.Sleep(5000); // Pausiert für 2 Sekunden
        }

        // Eine Methode, die einen asynchronen Arbeitsschritt ausführt
        private async Task DoAsynchronousWork()
        {
            // Simuliert eine asynchrone Arbeit
            await Task.Delay(5000); // Pausiert für 2 Sekunden, blockiert aber nicht den Thread
        }
    }
}
