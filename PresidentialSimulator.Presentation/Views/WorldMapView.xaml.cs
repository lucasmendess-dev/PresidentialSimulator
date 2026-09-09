using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Web.WebView2.Core;

namespace PresidentialSimulator.Presentation.Views;

public partial class WorldMapView : UserControl
{
    public WorldMapView()
    {
        InitializeComponent();

        Loaded += WorldMapView_Loaded;
    }

    private async void WorldMapView_Loaded(
        object sender,
        System.Windows.RoutedEventArgs e)
    {
        Loaded -= WorldMapView_Loaded;

        await InitializeMapAsync();
    }

    private async Task InitializeMapAsync()
    {
        await MapWebView.EnsureCoreWebView2Async();

        MapWebView.CoreWebView2.WebMessageReceived +=
            CoreWebView2_WebMessageReceived;

        MapWebView.NavigateToString(GetMapHtml());
    }

    private void CoreWebView2_WebMessageReceived(
        object? sender,
        CoreWebView2WebMessageReceivedEventArgs e)
    {
        try
        {
            string json = e.WebMessageAsJson;

            SelectedCountryMessage? country =
                JsonSerializer.Deserialize<SelectedCountryMessage>(json);

            if (country is null)
                return;

            if (string.IsNullOrWhiteSpace(country.Code))
                return;

            UpdateCountryPanel(country.Code);
        }
        catch (Exception)
        {
            // Nesta etapa inicial do projeto,
            // mensagens inválidas são apenas ignoradas.
        }
    }

    private void UpdateCountryPanel(string countryCode)
    {
        switch (countryCode.ToUpper())
        {
            // =====================================================
            // BRASIL
            // =====================================================

            case "BR":

                SelectedCountryTitle.Text =
                    "BRASIL";

                SelectedCountrySubtitle.Text =
                    "República Federativa do Brasil";

                RelationshipText.Text =
                    "100/100";

                StabilityText.Text =
                    "99";

                InfluenceText.Text =
                    "100";

                StatusOneText.Text =
                    "● Potência global";

                StatusTwoText.Text =
                    "● Liderança da OTDS";

                StatusThreeText.Text =
                    "● União Sul-Americana";

                StatusFourText.Text =
                    "● Federação multinacional";

                RecentEventText.Text =
                    "Expansão da influência brasileira e consolidação da Federação.";

                break;


            // =====================================================
            // ARGENTINA
            // =====================================================

            case "AR":

                SelectedCountryTitle.Text =
                    "ARGENTINA";

                SelectedCountrySubtitle.Text =
                    "República Argentina";

                RelationshipText.Text =
                    "94/100";

                StabilityText.Text =
                    "82";

                InfluenceText.Text =
                    "76";

                StatusOneText.Text =
                    "● União Sul-Americana";

                StatusTwoText.Text =
                    "● OTDS";

                StatusThreeText.Text =
                    "● Integração econômica";

                StatusFourText.Text =
                    "● Estudo federativo em andamento";

                RecentEventText.Text =
                    "Audiências públicas nacionais sobre integração federativa.";

                break;


            // =====================================================
            // ESTADOS UNIDOS
            // =====================================================

            case "US":

                SelectedCountryTitle.Text =
                    "ESTADOS UNIDOS";

                SelectedCountrySubtitle.Text =
                    "Estados Unidos da América";

                RelationshipText.Text =
                    "89/100";

                StabilityText.Text =
                    "91";

                InfluenceText.Text =
                    "99";

                StatusOneText.Text =
                    "● Potência global";

                StatusTwoText.Text =
                    "● Aliança estratégica com o Brasil";

                StatusThreeText.Text =
                    "● Cooperação tecnológica";

                StatusFourText.Text =
                    "● Parceiro diplomático";

                RecentEventText.Text =
                    "Cooperação bilateral em segurança, tecnologia e instituições globais.";

                break;


            // =====================================================
            // CHINA
            // =====================================================

            case "CN":

                SelectedCountryTitle.Text =
                    "CHINA";

                SelectedCountrySubtitle.Text =
                    "República Popular da China";

                RelationshipText.Text =
                    "87/100";

                StabilityText.Text =
                    "94";

                InfluenceText.Text =
                    "98";

                StatusOneText.Text =
                    "● Potência global";

                StatusTwoText.Text =
                    "● Parceiro comercial estratégico";

                StatusThreeText.Text =
                    "● Cooperação industrial";

                StatusFourText.Text =
                    "● Competição tecnológica";

                RecentEventText.Text =
                    "Brasil e China ampliam diálogo econômico e tecnológico.";

                break;


            // =====================================================
            // PAÍS AINDA SEM DADOS
            // =====================================================

            default:

                SelectedCountryTitle.Text =
                    countryCode;

                SelectedCountrySubtitle.Text =
                    "País selecionado";

                RelationshipText.Text =
                    "--";

                StabilityText.Text =
                    "--";

                InfluenceText.Text =
                    "--";

                StatusOneText.Text =
                    "● Dados ainda não carregados";

                StatusTwoText.Text =
                    "";

                StatusThreeText.Text =
                    "";

                StatusFourText.Text =
                    "";

                RecentEventText.Text =
                    "Nenhum evento importante registrado.";

                break;
        }
    }

    private string GetMapHtml()
    {
        return """
<!DOCTYPE html>

<html>

<head>

<meta charset="utf-8"/>

<meta name="viewport"
      content="width=device-width, initial-scale=1.0"/>

<link
    rel="stylesheet"
    href="https://unpkg.com/leaflet@1.9.4/dist/leaflet.css"/>

<script
    src="https://unpkg.com/leaflet@1.9.4/dist/leaflet.js">
</script>

<style>

html,
body
{
    width: 100%;
    height: 100%;
    margin: 0;
    background: #08101c;
    overflow: hidden;
}

#map
{
    width: 100%;
    height: 100%;
    background: #08101c;
}

.leaflet-container
{
    background: #08101c;
    font-family: Arial, sans-serif;
}

.leaflet-control-zoom
{
    border: none !important;
}

.leaflet-control-zoom a
{
    background: #151d2c !important;
    color: white !important;
    border-color: #263348 !important;
}

.leaflet-control-zoom a:hover
{
    background: #1e293b !important;
}

.leaflet-popup-content-wrapper
{
    background: #151d2c;
    color: white;
    border-radius: 8px;
}

.leaflet-popup-tip
{
    background: #151d2c;
}

.leaflet-popup-content
{
    font-size: 13px;
    font-weight: 600;
}

</style>

</head>

<body>

<div id="map"></div>

<script>

const map = L.map(
    'map',
    {
        zoomControl: true,
        minZoom: 2,
        maxZoom: 7,
        worldCopyJump: true
    }
).setView(
    [15, -20],
    2
);


L.tileLayer(
    'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
    {
        maxZoom: 19,
        attribution: '&copy; OpenStreetMap contributors'
    }
).addTo(map);


function selectCountry(countryCode)
{
    window.chrome.webview.postMessage(
        {
            code: countryCode
        }
    );
}


function createCountryMarker(
    latitude,
    longitude,
    countryCode,
    countryName,
    color)
{
    const marker = L.circleMarker(
        [latitude, longitude],
        {
            radius: 8,
            fillColor: color,
            color: '#ffffff',
            weight: 2,
            opacity: 1,
            fillOpacity: 0.9
        }
    ).addTo(map);


    marker.bindPopup(
        countryName,
        {
            closeButton: false
        }
    );


    marker.on(
        'click',
        function()
        {
            selectCountry(countryCode);
        }
    );
}


// =========================================================
// BRASIL
// =========================================================

createCountryMarker(
    -14.2,
    -51.9,
    'BR',
    'Brasil',
    '#22c55e'
);


// =========================================================
// ARGENTINA
// =========================================================

createCountryMarker(
    -38.4,
    -63.6,
    'AR',
    'Argentina',
    '#3b82f6'
);


// =========================================================
// ESTADOS UNIDOS
// =========================================================

createCountryMarker(
    39.8,
    -98.5,
    'US',
    'Estados Unidos',
    '#3b82f6'
);


// =========================================================
// CHINA
// =========================================================

createCountryMarker(
    35.8,
    104.1,
    'CN',
    'China',
    '#3b82f6'
);


L.control.scale(
    {
        imperial: false
    }
).addTo(map);

</script>

</body>

</html>
""";
    }


    // =========================================================
    // MENSAGEM RECEBIDA DO JAVASCRIPT
    // =========================================================

    private sealed class SelectedCountryMessage
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } =
            string.Empty;
    }
}