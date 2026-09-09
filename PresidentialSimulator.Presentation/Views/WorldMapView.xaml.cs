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

            UpdateCountryPanel(
                country.Code,
                country.Name
            );
        }
        catch
        {
            // Mensagens inválidas são ignoradas por enquanto.
        }
    }

    private void UpdateCountryPanel(
        string countryCode,
        string countryName)
    {
        string code =
            countryCode.ToUpperInvariant();

        switch (code)
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
                    "Cooperação bilateral em tecnologia e instituições globais.";

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
            // GRANDE PARAGUAI
            // =====================================================

            case "PY":

                SelectedCountryTitle.Text =
                    "GRANDE PARAGUAI";

                SelectedCountrySubtitle.Text =
                    "Estado integrante da Federação";

                RelationshipText.Text =
                    "100/100";

                StabilityText.Text =
                    "96";

                InfluenceText.Text =
                    "72";

                StatusOneText.Text =
                    "● Federação brasileira";

                StatusTwoText.Text =
                    "● Cidadania brasileira integral";

                StatusThreeText.Text =
                    "● Integração institucional concluída";

                StatusFourText.Text =
                    "● Garantias culturais constitucionais";

                RecentEventText.Text =
                    "Integração federativa consolidada.";

                break;


            // =====================================================
            // BOLÍVIA
            // =====================================================

            case "BO":

                SelectedCountryTitle.Text =
                    "BOLÍVIA";

                SelectedCountrySubtitle.Text =
                    "Estado Plurinacional integrante da Federação";

                RelationshipText.Text =
                    "100/100";

                StabilityText.Text =
                    "94";

                InfluenceText.Text =
                    "73";

                StatusOneText.Text =
                    "● Federação brasileira";

                StatusTwoText.Text =
                    "● Autonomias preservadas";

                StatusThreeText.Text =
                    "● Cidadania brasileira integral";

                StatusFourText.Text =
                    "● Programa Bolívia 2045";

                RecentEventText.Text =
                    "Integração econômica e institucional continua avançando.";

                break;


            // =====================================================
            // SURINAME
            // =====================================================

            case "SR":

                SelectedCountryTitle.Text =
                    "SURINAME";

                SelectedCountrySubtitle.Text =
                    "Estado integrante da Federação";

                RelationshipText.Text =
                    "100/100";

                StabilityText.Text =
                    "93";

                InfluenceText.Text =
                    "64";

                StatusOneText.Text =
                    "● Federação brasileira";

                StatusTwoText.Text =
                    "● Neerlandês protegido";

                StatusThreeText.Text =
                    "● Programa Suriname 2046";

                StatusFourText.Text =
                    "● Proteção ambiental especial";

                RecentEventText.Text =
                    "Transição federativa concluída em julho de 2037.";

                break;


            // =====================================================
            // VENEZUELA
            // =====================================================

            case "VE":

                SelectedCountryTitle.Text =
                    "VENEZUELA";

                SelectedCountrySubtitle.Text =
                    "República Bolivariana da Venezuela";

                RelationshipText.Text =
                    "98/100";

                StabilityText.Text =
                    "78";

                InfluenceText.Text =
                    "81";

                StatusOneText.Text =
                    "● Tratado federativo assinado";

                StatusTwoText.Text =
                    "● Transição em andamento";

                StatusThreeText.Text =
                    "● Comissão Nacional de Garantias";

                StatusFourText.Text =
                    "● Entrada prevista para 01/01/2038";

                RecentEventText.Text =
                    "Instituições venezuelanas avançam na transição federativa.";

                break;


            // =====================================================
            // URUGUAI
            // =====================================================

            case "UY":

                SelectedCountryTitle.Text =
                    "URUGUAI";

                SelectedCountrySubtitle.Text =
                    "República Oriental do Uruguai";

                RelationshipText.Text =
                    "97/100";

                StabilityText.Text =
                    "95";

                InfluenceText.Text =
                    "72";

                StatusOneText.Text =
                    "● Referendo aprovado";

                StatusTwoText.Text =
                    "● Transição federativa";

                StatusThreeText.Text =
                    "● Comissão Oriental de Garantias";

                StatusFourText.Text =
                    "● Entrada prevista para 01/10/2038";

                RecentEventText.Text =
                    "Montevidéu prepara a transição constitucional.";

                break;


            // =====================================================
            // OUTROS PAÍSES
            // =====================================================

            default:

                SelectedCountryTitle.Text =
                    string.IsNullOrWhiteSpace(countryName)
                        ? code
                        : countryName.ToUpperInvariant();

                SelectedCountrySubtitle.Text =
                    $"Código internacional: {code}";

                RelationshipText.Text =
                    "--";

                StabilityText.Text =
                    "--";

                InfluenceText.Text =
                    "--";

                StatusOneText.Text =
                    "● País disponível no mapa";

                StatusTwoText.Text =
                    "● Dados estratégicos serão carregados pelo GameState";

                StatusThreeText.Text =
                    "";

                StatusFourText.Text =
                    "";

                RecentEventText.Text =
                    "Nenhum evento importante registrado neste protótipo.";

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
    overflow: hidden;

    background: #08101c;
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

    font-family:
        Segoe UI,
        Arial,
        sans-serif;
}


.leaflet-control-zoom
{
    border: none !important;

    box-shadow:
        0 4px 15px rgba(0,0,0,0.3) !important;
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

    box-shadow:
        0 5px 20px rgba(0,0,0,0.4);
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


.country-tooltip
{
    background: #0d1421 !important;

    color: white !important;

    border: 1px solid #334155 !important;

    border-radius: 6px !important;

    box-shadow:
        0 4px 12px rgba(0,0,0,0.4) !important;

    font-weight: 600;

    font-size: 12px;
}


.country-tooltip::before
{
    border-top-color:
        #334155 !important;
}

</style>

</head>


<body>

<div id="map"></div>


<script>

// =========================================================
// MAPA
// =========================================================

const map = L.map(
    'map',
    {
        zoomControl: true,

        minZoom: 2,

        maxZoom: 8,

        worldCopyJump: true
    }
)
.setView(
    [15, -20],
    2
);


// =========================================================
// MAPA BASE
// =========================================================

L.tileLayer(
    'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
    {
        maxZoom: 19,

        attribution:
            '&copy; OpenStreetMap contributors'
    }
)
.addTo(map);


// =========================================================
// ESTADO DO MAPA
// =========================================================

let selectedLayer = null;


// =========================================================
// CORES
// =========================================================

function getCountryColor(code)
{
    switch(code)
    {
        // Federação
        case 'BR':
        case 'PY':
        case 'BO':
        case 'SR':
            return '#16a34a';


        // Transição federativa
        case 'VE':
        case 'UY':
            return '#eab308';


        // Relações estratégicas
        case 'AR':
        case 'US':
        case 'CN':
            return '#2563eb';


        // Países restantes
        default:
            return '#334155';
    }
}


// =========================================================
// ESTILO
// =========================================================

function countryStyle(feature)
{
    const code =
        feature.properties['ISO3166-1-Alpha-2'];

    return {
        fillColor:
            getCountryColor(code),

        fillOpacity:
            0.42,

        color:
            '#64748b',

        weight:
            1,

        opacity:
            0.8
    };
}


// =========================================================
// SELECIONAR PAÍS
// =========================================================

function selectCountry(
    feature,
    layer)
{
    const code =
        feature.properties['ISO3166-1-Alpha-2'];

    const name =
        feature.properties.name;


    // Remove seleção anterior
    if(selectedLayer)
    {
        geoJsonLayer.resetStyle(
            selectedLayer
        );
    }


    selectedLayer =
        layer;


    // Destaque
    layer.setStyle(
        {
            weight: 3,

            color: '#ffffff',

            fillOpacity: 0.75
        }
    );


    // Traz para frente
    if(layer.bringToFront)
    {
        layer.bringToFront();
    }


    // Envia para WPF
    window.chrome.webview.postMessage(
        {
            code: code,

            name: name
        }
    );
}


// =========================================================
// INTERAÇÃO
// =========================================================

function onEachCountry(
    feature,
    layer)
{
    const name =
        feature.properties.name;


    const code =
        feature.properties['ISO3166-1-Alpha-2'];


    layer.bindTooltip(
        name,
        {
            sticky: true,

            direction: 'top',

            className:
                'country-tooltip'
        }
    );


    layer.on(
        {
            mouseover:
                function(event)
                {
                    const target =
                        event.target;

                    target.setStyle(
                        {
                            weight: 2,

                            color: '#ffffff',

                            fillOpacity: 0.65
                        }
                    );
                },


            mouseout:
                function(event)
                {
                    if(
                        event.target
                        !==
                        selectedLayer
                    )
                    {
                        geoJsonLayer.resetStyle(
                            event.target
                        );
                    }
                },


            click:
                function(event)
                {
                    selectCountry(
                        feature,
                        event.target
                    );
                }
        }
    );
}


// =========================================================
// GEOJSON
// =========================================================

let geoJsonLayer;


fetch(
    'https://raw.githubusercontent.com/datasets/geo-countries/main/data/countries.geojson'
)
.then(
    response =>
    {
        if(!response.ok)
        {
            throw new Error(
                'Falha ao carregar GeoJSON.'
            );
        }

        return response.json();
    }
)
.then(
    data =>
    {
        geoJsonLayer =
            L.geoJSON(
                data,
                {
                    style:
                        countryStyle,

                    onEachFeature:
                        onEachCountry
                }
            )
            .addTo(map);
    }
)
.catch(
    error =>
    {
        console.error(
            'Erro no mapa:',
            error
        );
    }
);


// =========================================================
// ESCALA
// =========================================================

L.control.scale(
    {
        imperial: false
    }
)
.addTo(map);

</script>

</body>

</html>
""";
    }


    private sealed class SelectedCountryMessage
    {
        [JsonPropertyName("code")]
        public string Code { get; set; } =
            string.Empty;


        [JsonPropertyName("name")]
        public string Name { get; set; } =
            string.Empty;
    }
}