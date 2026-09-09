using PresidentialSimulator.Application.Interfaces;
using PresidentialSimulator.Domain.Entities;
using PresidentialSimulator.Domain.Enums;
using PresidentialSimulator.Domain.State;

namespace PresidentialSimulator.Application.Services;

public class NewGameService : INewGameService
{
    public GameState CreateNewGame()
    {
        var gameState = new GameState
        {
            CurrentDate = new DateTime(2037, 9, 30, 19, 20, 0),

            PlayerCountryCode = "BR",

            CurrentEventTitle =
                "Argentina abre nova fase de estudos",

            CurrentEventDescription =
                "O governo argentino inicia uma nova rodada de audiências públicas nacionais sobre o futuro da integração."
        };

        gameState.Countries =
        [
            CreateBrazil(),
            CreateArgentina(),
            CreateUnitedStates(),
            CreateChina(),

            CreateParaguay(),
            CreateBolivia(),
            CreateSuriname(),
            CreateVenezuela(),
            CreateUruguay(),

            CreatePeru(),
            CreateChile(),
            CreateColombia(),
            CreateEcuador(),
            CreateGuyana(),

            CreateGermany(),
            CreateIndia(),
            CreateJapan(),
            CreateFrance(),
            CreateUnitedKingdom(),
            CreateRussia(),
            CreateSouthKorea()
        ];

        UpdateWorldRanking(gameState);

        return gameState;
    }


    // =========================================================
    // BRASIL
    // =========================================================

    private static Country CreateBrazil()
    {
        return new Country
        {
            Code = "BR",

            Name = "Brasil",

            OfficialName =
                "República Federativa do Brasil",

            Stability = 99,

            Influence = 100,

            RelationshipWithPlayer = 100,

            EconomyPower = 100,

            MilitaryPower = 99,

            TechnologyPower = 98,

            IndustrialPower = 99,

            DiplomaticPower = 100,

            IntelligencePower = 100,

            StrategicAutonomy = 100,

            PowerScore = 98.7,

            AllianceType =
                AllianceType.Federation,

            CrisisLevel =
                CrisisLevel.None,

            IsFederationMember = true,

            Status =
            [
                "Potência global",
                "Liderança da OTDS",
                "União Sul-Americana",
                "Federação multinacional"
            ],

            RecentEvent =
                "Brasil consolida sua posição como principal potência mundial."
        };
    }


    // =========================================================
    // ARGENTINA
    // =========================================================

    private static Country CreateArgentina()
    {
        return new Country
        {
            Code = "AR",

            Name = "Argentina",

            OfficialName =
                "República Argentina",

            Stability = 82,

            Influence = 76,

            RelationshipWithPlayer = 94,

            EconomyPower = 74,

            MilitaryPower = 67,

            TechnologyPower = 70,

            IndustrialPower = 76,

            DiplomaticPower = 79,

            IntelligencePower = 68,

            StrategicAutonomy = 75,

            PowerScore = 72.4,

            AllianceType =
                AllianceType.RegionalAlliance,

            CrisisLevel =
                CrisisLevel.None,

            Status =
            [
                "União Sul-Americana",
                "OTDS",
                "Integração econômica",
                "Estudos sobre integração federativa"
            ],

            RecentEvent =
                "Audiências públicas nacionais analisam diferentes caminhos para a integração."
        };
    }


    // =========================================================
    // ESTADOS UNIDOS
    // =========================================================

    private static Country CreateUnitedStates()
    {
        return new Country
        {
            Code = "US",

            Name = "Estados Unidos",

            OfficialName =
                "Estados Unidos da América",

            Stability = 91,

            Influence = 99,

            RelationshipWithPlayer = 89,

            EconomyPower = 99,

            MilitaryPower = 100,

            TechnologyPower = 100,

            IndustrialPower = 97,

            DiplomaticPower = 97,

            IntelligencePower = 100,

            StrategicAutonomy = 100,

            PowerScore = 96.4,

            AllianceType =
                AllianceType.StrategicPartner,

            CrisisLevel =
                CrisisLevel.None,

            Status =
            [
                "Potência global",
                "Parceiro estratégico do Brasil",
                "Cooperação tecnológica",
                "Cooperação diplomática"
            ],

            RecentEvent =
                "Brasil e Estados Unidos mantêm ampla parceria estratégica."
        };
    }


    // =========================================================
    // CHINA
    // =========================================================

    private static Country CreateChina()
    {
        return new Country
        {
            Code = "CN",

            Name = "China",

            OfficialName =
                "República Popular da China",

            Stability = 94,

            Influence = 98,

            RelationshipWithPlayer = 87,

            EconomyPower = 100,

            MilitaryPower = 98,

            TechnologyPower = 99,

            IndustrialPower = 100,

            DiplomaticPower = 96,

            IntelligencePower = 98,

            StrategicAutonomy = 100,

            PowerScore = 95.8,

            AllianceType =
                AllianceType.EconomicPartner,

            CrisisLevel =
                CrisisLevel.None,

            Status =
            [
                "Potência global",
                "Parceiro comercial estratégico",
                "Cooperação industrial",
                "Competição tecnológica"
            ],

            RecentEvent =
                "Brasil e China ampliam diálogo econômico e tecnológico."
        };
    }


    // =========================================================
    // PARAGUAI
    // =========================================================

    private static Country CreateParaguay()
    {
        return new Country
        {
            Code = "PY",

            Name = "Grande Paraguai",

            OfficialName =
                "Estado do Grande Paraguai",

            Stability = 96,

            Influence = 72,

            RelationshipWithPlayer = 100,

            EconomyPower = 68,

            MilitaryPower = 70,

            TechnologyPower = 69,

            IndustrialPower = 72,

            DiplomaticPower = 70,

            IntelligencePower = 72,

            StrategicAutonomy = 80,

            PowerScore = 70.4,

            AllianceType =
                AllianceType.Federation,

            CrisisLevel =
                CrisisLevel.None,

            IsFederationMember = true,

            Status =
            [
                "Federação brasileira",
                "Cidadania brasileira integral",
                "Integração institucional concluída",
                "Garantias culturais constitucionais"
            ],

            RecentEvent =
                "Integração federativa consolidada."
        };
    }


    // =========================================================
    // BOLÍVIA
    // =========================================================

    private static Country CreateBolivia()
    {
        return new Country
        {
            Code = "BO",

            Name = "Bolívia",

            OfficialName =
                "Estado Plurinacional da Bolívia",

            Stability = 94,

            Influence = 73,

            RelationshipWithPlayer = 100,

            EconomyPower = 70,

            MilitaryPower = 72,

            TechnologyPower = 68,

            IndustrialPower = 73,

            DiplomaticPower = 72,

            IntelligencePower = 70,

            StrategicAutonomy = 82,

            PowerScore = 71.5,

            AllianceType =
                AllianceType.Federation,

            CrisisLevel =
                CrisisLevel.None,

            IsFederationMember = true,

            Status =
            [
                "Federação brasileira",
                "Autonomias preservadas",
                "Cidadania brasileira integral",
                "Programa Bolívia 2045"
            ],

            RecentEvent =
                "Integração econômica e institucional continua avançando."
        };
    }


    // =========================================================
    // SURINAME
    // =========================================================

    private static Country CreateSuriname()
    {
        return new Country
        {
            Code = "SR",

            Name = "Suriname",

            OfficialName =
                "Estado do Suriname",

            Stability = 93,

            Influence = 64,

            RelationshipWithPlayer = 100,

            EconomyPower = 64,

            MilitaryPower = 65,

            TechnologyPower = 66,

            IndustrialPower = 67,

            DiplomaticPower = 68,

            IntelligencePower = 65,

            StrategicAutonomy = 78,

            PowerScore = 66.3,

            AllianceType =
                AllianceType.Federation,

            CrisisLevel =
                CrisisLevel.None,

            IsFederationMember = true,

            Status =
            [
                "Federação brasileira",
                "Neerlandês protegido",
                "Programa Suriname 2046",
                "Proteção ambiental especial"
            ],

            RecentEvent =
                "Transição federativa concluída em julho de 2037."
        };
    }


    // =========================================================
    // VENEZUELA
    // =========================================================

    private static Country CreateVenezuela()
    {
        return new Country
        {
            Code = "VE",

            Name = "Venezuela",

            OfficialName =
                "República Bolivariana da Venezuela",

            Stability = 78,

            Influence = 81,

            RelationshipWithPlayer = 98,

            EconomyPower = 75,

            MilitaryPower = 78,

            TechnologyPower = 69,

            IndustrialPower = 76,

            DiplomaticPower = 77,

            IntelligencePower = 76,

            StrategicAutonomy = 82,

            PowerScore = 77.2,

            AllianceType =
                AllianceType.RegionalAlliance,

            CrisisLevel =
                CrisisLevel.Attention,

            IsFederationTransition = true,

            Status =
            [
                "Tratado federativo assinado",
                "Transição federativa em andamento",
                "Comissão Nacional de Garantias",
                "Entrada prevista para 01/01/2038"
            ],

            RecentEvent =
                "Instituições venezuelanas avançam na transição federativa."
        };
    }


    // =========================================================
    // URUGUAI
    // =========================================================

    private static Country CreateUruguay()
    {
        return new Country
        {
            Code = "UY",

            Name = "Uruguai",

            OfficialName =
                "República Oriental do Uruguai",

            Stability = 95,

            Influence = 72,

            RelationshipWithPlayer = 97,

            EconomyPower = 72,

            MilitaryPower = 68,

            TechnologyPower = 75,

            IndustrialPower = 73,

            DiplomaticPower = 82,

            IntelligencePower = 71,

            StrategicAutonomy = 79,

            PowerScore = 73.1,

            AllianceType =
                AllianceType.RegionalAlliance,

            CrisisLevel =
                CrisisLevel.None,

            IsFederationTransition = true,

            Status =
            [
                "Processo federativo",
                "Transição institucional",
                "Garantias culturais",
                "Integração econômica"
            ],

            RecentEvent =
                "Montevidéu prepara a próxima etapa do processo federativo."
        };
    }


    // =========================================================
    // PERU
    // =========================================================

    private static Country CreatePeru()
    {
        return CreateRegionalCountry(
            "PE",
            "Peru",
            "República do Peru",
            86,
            70,
            88,
            69.8
        );
    }


    // =========================================================
    // CHILE
    // =========================================================

    private static Country CreateChile()
    {
        return CreateRegionalCountry(
            "CL",
            "Chile",
            "República do Chile",
            91,
            74,
            92,
            74.5
        );
    }


    // =========================================================
    // COLÔMBIA
    // =========================================================

    private static Country CreateColombia()
    {
        return CreateRegionalCountry(
            "CO",
            "Colômbia",
            "República da Colômbia",
            84,
            75,
            89,
            75.2
        );
    }


    // =========================================================
    // EQUADOR
    // =========================================================

    private static Country CreateEcuador()
    {
        return CreateRegionalCountry(
            "EC",
            "Equador",
            "República do Equador",
            83,
            66,
            90,
            65.8
        );
    }


    // =========================================================
    // GUIANA
    // =========================================================

    private static Country CreateGuyana()
    {
        return CreateRegionalCountry(
            "GY",
            "Guiana",
            "República Cooperativa da Guiana",
            88,
            63,
            91,
            64.9
        );
    }


    // =========================================================
    // ALEMANHA
    // =========================================================

    private static Country CreateGermany()
    {
        return CreateGlobalPower(
            "DE",
            "Alemanha",
            "República Federal da Alemanha",
            87.9,
            92,
            89
        );
    }


    // =========================================================
    // ÍNDIA
    // =========================================================

    private static Country CreateIndia()
    {
        return CreateGlobalPower(
            "IN",
            "Índia",
            "República da Índia",
            90.2,
            91,
            88
        );
    }


    // =========================================================
    // JAPÃO
    // =========================================================

    private static Country CreateJapan()
    {
        return CreateGlobalPower(
            "JP",
            "Japão",
            "Japão",
            86.7,
            95,
            91
        );
    }


    // =========================================================
    // FRANÇA
    // =========================================================

    private static Country CreateFrance()
    {
        return CreateGlobalPower(
            "FR",
            "França",
            "República Francesa",
            84.1,
            91,
            92
        );
    }


    // =========================================================
    // REINO UNIDO
    // =========================================================

    private static Country CreateUnitedKingdom()
    {
        return CreateGlobalPower(
            "GB",
            "Reino Unido",
            "Reino Unido",
            82.8,
            90,
            90
        );
    }


    // =========================================================
    // RÚSSIA
    // =========================================================

    private static Country CreateRussia()
    {
        return CreateGlobalPower(
            "RU",
            "Rússia",
            "Federação Russa",
            81.5,
            87,
            79
        );
    }


    // =========================================================
    // COREIA DO SUL
    // =========================================================

    private static Country CreateSouthKorea()
    {
        return CreateGlobalPower(
            "KR",
            "Coreia do Sul",
            "República da Coreia",
            78.4,
            94,
            88
        );
    }


    // =========================================================
    // CRIADOR DE PAÍSES REGIONAIS
    // =========================================================

    private static Country CreateRegionalCountry(
        string code,
        string name,
        string officialName,
        double stability,
        double influence,
        double relationship,
        double powerScore)
    {
        return new Country
        {
            Code = code,

            Name = name,

            OfficialName = officialName,

            Stability = stability,

            Influence = influence,

            RelationshipWithPlayer = relationship,

            EconomyPower = powerScore,

            MilitaryPower = powerScore - 4,

            TechnologyPower = powerScore - 2,

            IndustrialPower = powerScore,

            DiplomaticPower = influence,

            IntelligencePower = powerScore - 3,

            StrategicAutonomy = powerScore,

            PowerScore = powerScore,

            AllianceType =
                AllianceType.RegionalAlliance,

            CrisisLevel =
                CrisisLevel.None,

            Status =
            [
                "União Sul-Americana",
                "OTDS",
                "Integração econômica regional"
            ],

            RecentEvent =
                "Relações regionais permanecem estáveis."
        };
    }


    // =========================================================
    // CRIADOR DE POTÊNCIAS GLOBAIS
    // =========================================================

    private static Country CreateGlobalPower(
        string code,
        string name,
        string officialName,
        double powerScore,
        double stability,
        double relationship)
    {
        return new Country
        {
            Code = code,

            Name = name,

            OfficialName = officialName,

            Stability = stability,

            Influence = powerScore,

            RelationshipWithPlayer = relationship,

            EconomyPower = powerScore,

            MilitaryPower = powerScore,

            TechnologyPower = powerScore,

            IndustrialPower = powerScore,

            DiplomaticPower = powerScore,

            IntelligencePower = powerScore,

            StrategicAutonomy = powerScore,

            PowerScore = powerScore,

            AllianceType =
                AllianceType.StrategicPartner,

            CrisisLevel =
                CrisisLevel.None,

            Status =
            [
                "Potência internacional",
                "Relações diplomáticas com o Brasil"
            ],

            RecentEvent =
                "Nenhum evento bilateral crítico registrado."
        };
    }


    // =========================================================
    // RANKING MUNDIAL
    // =========================================================

    private static void UpdateWorldRanking(
        GameState gameState)
    {
        var ranking =
            gameState.Countries
                .OrderByDescending(
                    country => country.PowerScore
                )
                .ToList();


        for (int index = 0;
             index < ranking.Count;
             index++)
        {
            ranking[index].WorldRanking =
                index + 1;
        }
    }
}