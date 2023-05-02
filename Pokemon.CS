namespace VideoJuegosAPI;

public class Pokemon: IPokemon
{
    private List<PokemonDTO> DB;
    public Pokemon(){
         DB = new List<PokemonDTO>();
    }

    public void Add(PokemonDTO pokemon)
    {
        DB.Add(pokemon);
    }

    public void Delete(int id)
    {
        DB.RemoveAll(pokemon => pokemon.Id == id);
    }

    public void Update(int id, PokemonDTO pokemon)
    {
        PokemonDTO pokemonUpdate = DB.Single(pokemon => pokemon.Id == id);
        pokemonUpdate.Nombre = pokemon.Nombre;
        pokemonUpdate.Tipo = pokemon.Tipo;
        pokemonUpdate.Defensa = pokemon.Defensa;
        pokemonUpdate.Skills = pokemon.Skills;
        pokemonUpdate.Daño = pokemon.Daño;
    }


    public List<PokemonDTO> All()
    {
        return DB;
    }

    public IEnumerable<PokemonDTO> Where(string tipo){
      return this.DB.Where(pokemon => pokemon.Tipo == tipo);

    }



}