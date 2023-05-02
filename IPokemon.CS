namespace VideoJuegosAPI;

interface IPokemon
{
    void Add(PokemonDTO pokemon);
    void Delete(int Id);
    void Update(int Id, PokemonDTO pokemon);
    
    List<PokemonDTO> All();
}