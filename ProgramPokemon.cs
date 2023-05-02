using VideoJuegosAPI;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Pokemon pokedex = new Pokemon();

app.MapGet("/api/v1/pokedex", () => { 
    return Results.Ok(pokedex.All());
});

app.MapPost("/api/v1/pokedex/pokemon", (PokemonDTO pokemon) => {
    pokedex.Add(pokemon);
    return Results.Ok(pokedex.All());
});

app.MapPut("/api/v1/pokedex/update/{id}", (int id, PokemonDTO pokemon) => {
    pokedex.Update(id, pokemon);
    
});

app.MapPut("/api/v1/pokedex/delete/{id}", (int id) => {
    pokedex.Delete(id);
    
});

app.MapGet("/api/v1/muchos/pokemons", (PokemonDTO[] Pokemons) => { 
    foreach(PokemonDTO pokemon in Pokemons)
    {
        pokedex.Add(pokemon);
    }
});


app.MapGet("/api/v1/pokedex/{tipo}", (string tipo ) => { 
    return Results.Ok(pokedex.Where(tipo));
});


app.Run();
