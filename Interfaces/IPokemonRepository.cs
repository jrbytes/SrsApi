using SrsApi.Models;

namespace SrsApi.Interfaces
{
  public interface ITopicRepository
  {
    ICollection<Topic> GetPokemons();
    Topic GetPokemon(int id);
    bool PokemonExists(int pokeId);
    bool CreatePokemon(int ownerId, int categoryId, Topic pokemon);
    bool Save();
  }
}