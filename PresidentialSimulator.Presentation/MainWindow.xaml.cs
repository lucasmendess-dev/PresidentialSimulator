using System.Windows;
using PresidentialSimulator.Presentation.Views;

namespace PresidentialSimulator.Presentation;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        ShowDashboard();
    }

    private void DashboardButton_Click(object sender, RoutedEventArgs e)
    {
        ShowDashboard();
    }

    private void WorldMapButton_Click(object sender, RoutedEventArgs e)
    {
        ShowWorldMap();
    }

    private void WorldRankingButton_Click(object sender, RoutedEventArgs e)
    {
        ShowWorldRanking();
    }

    private void ShowDashboard()
    {
        MainContent.Content = new DashboardView();

        PageTitleText.Text = "PALÁCIO DO PLANALTO";

        PageSubtitleText.Text =
            "Brasília • República Federativa do Brasil";
    }

    private void ShowWorldMap()
    {
        MainContent.Content = new WorldMapView();

        PageTitleText.Text = "MAPA MUNDIAL";

        PageSubtitleText.Text =
            "Situação geopolítica global";
    }

    private void ShowWorldRanking()
    {
        MainContent.Content = new WorldRankingView();

        PageTitleText.Text = "RANKING DE POTÊNCIAS";

        PageSubtitleText.Text =
            "Classificação estratégica mundial";
    }
}