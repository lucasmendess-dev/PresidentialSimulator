using PresidentialSimulator.Domain.Entities;

namespace PresidentialSimulator.Domain.State;

public class GameState
{
    // =========================================================
    // TEMPO
    // =========================================================

    public DateTime CurrentDate { get; set; }


    // =========================================================
    // PAÍS CONTROLADO
    // =========================================================

    public string PlayerCountryCode { get; set; } = "BR";


    // =========================================================
    // MUNDO
    // =========================================================

    public List<Country> Countries { get; set; } = [];


    // =========================================================
    // EVENTO ATUAL
    // =========================================================

    public string CurrentEventTitle { get; set; } = string.Empty;

    public string CurrentEventDescription { get; set; } = string.Empty;


    // =========================================================
    // BUSCAR PAÍS
    // =========================================================

    public Country? GetCountry(string countryCode)
    {
        return Countries.FirstOrDefault(
            country =>
                country.Code.Equals(
                    countryCode,
                    StringComparison.OrdinalIgnoreCase
                )
        );
    }


    // =========================================================
    // ORDENAR POTÊNCIAS
    // =========================================================

    public List<Country> GetWorldRanking()
    {
        return Countries
            .OrderByDescending(country => country.PowerScore)
            .ToList();
    }
}