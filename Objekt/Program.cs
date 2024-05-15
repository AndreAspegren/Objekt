namespace myApp
{
    class startClass
    {
        static void Main(string[] args)
        {
            var main = new mainClass();
            main.Run();
        }
    }

    class mainClass
    {
        public void Run()
        {
            var dex = new pokedex();
            dex.pokemonList.Add(new pokemon { name = "Pikachu", hp = 11000, attack = 1 });
            foreach (var x in dex.pokemonList) Console.WriteLine($@"{x.name + ' ' + x.hp + ' ' + x.attack}");
        }
    }

    public class pokemon
    {
        public string name;
        public int hp;
        public int attack;
    }
     public class pokedex {
         public List<pokemon> pokemonList = new List<pokemon>
        {
            new pokemon { name = "Charmander", hp = 39, attack = 52 },
            new pokemon { name = "Bulbasaur", hp = 45, attack = 49 },
            new pokemon { name = "Squirtle", hp = 44, attack = 48 }
        };
    }
}