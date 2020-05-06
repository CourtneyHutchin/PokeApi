using PokeApiCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApiWebsite.Models
{
    public static class PokeAPIHelper
    {
        /// <summary>
        /// Get a pokemon by id, moves will be sorted in
        /// alphabetical order
        /// </summary>
        /// <param name="desiredId"></param>
        /// <returns></returns>
        public static async Task<Pokemon> GetById(int desiredId)
        {
            PokeApiClient myClient = new PokeApiClient();
            Pokemon result = await myClient.GetPokemonById(desiredId);

            // Sorts all the moves by name alphabetically
            result.moves.OrderBy(m => m.move.name);

            return result;
        }

        public static PokedexEntryViewModel GetPokedexEntryFromPokemon(Pokemon result)
        {
            // Refactor property names
            var entry = new PokedexEntryViewModel()
            {
                Id = result.Id,
                Name = result.Name,
                Height = result.Height.ToString(),
                Weight = result.Weight.ToString(),
                PokedexImageUrl = result.Sprites.FrontDefault,
                MoveList = result.moves
                    .OrderBy(m => m.move.name)
                    .Select(m => m.move.name)
                    .ToArray()
            };

            // Set First letter to uppercase
            entry.Name = entry.Name.FirstCharToUpper();
            return entry;
        }

    }
}
