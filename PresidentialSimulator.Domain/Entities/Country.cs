using PresidentialSimulator.Domain.Enums;

namespace PresidentialSimulator.Domain.Entities;

public class Country
{
    public string Code { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string OfficialName { get; set; } = string.Empty;


    // =========================================================
    // INDICADORES POLÍTICOS
    // =========================================================

    public double Stability { get; set; }

    public double Influence { get; set; }


    // =========================================================
    // RELAÇÃO COM O PAÍS DO JOGADOR
    // =========================================================

    public double RelationshipWithPlayer { get; set; }


    // =========================================================
    // PODER NACIONAL
    // =========================================================

    public double EconomyPower { get; set; }

    public double MilitaryPower { get; set; }

    public double TechnologyPower { get; set; }

    public double IndustrialPower { get; set; }

    public double DiplomaticPower { get; set; }

    public double IntelligencePower { get; set; }

    public double StrategicAutonomy { get; set; }


    // =========================================================
    // CLASSIFICAÇÃO
    // =========================================================

    public double PowerScore { get; set; }

    public int WorldRanking { get; set; }


    // =========================================================
    // GEOPOLÍTICA
    // =========================================================

    public AllianceType AllianceType { get; set; }

    public CrisisLevel CrisisLevel { get; set; }


    // =========================================================
    // SITUAÇÃO ATUAL
    // =========================================================

    public List<string> Status { get; set; } = [];

    public string RecentEvent { get; set; } = string.Empty;


    // =========================================================
    // FEDERAÇÃO
    // =========================================================

    public bool IsFederationMember { get; set; }

    public bool IsFederationTransition { get; set; }


    // =========================================================
    // UTILIDADE
    // =========================================================

    public override string ToString()
    {
        return $"{Name} ({Code})";
    }
}