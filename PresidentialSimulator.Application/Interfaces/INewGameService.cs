using PresidentialSimulator.Domain.State;

namespace PresidentialSimulator.Application.Interfaces;

public interface INewGameService
{
    GameState CreateNewGame();
}