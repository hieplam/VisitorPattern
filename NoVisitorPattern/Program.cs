using System;

namespace NoVisitorPattern
{
    class Program
    {
        private static Player _player;
        public static void Main(string[] args)
        {
            const CharacterRole characterRole = CharacterRole.Warrior;
            const CharacterClass characterClass = CharacterClass.Human;
            _player = CreateInstance(characterRole, characterClass);

            Console.WriteLine("The {0} is {1} class has {2} physical damage, {3} magical damage with {4} stamina and {5} steath stat!!!!", 
                characterRole,characterClass,_player.PhysicalDamage,_player.MagicalDamage,_player.Stamina,_player.SteathStat);

            Console.ReadKey();
        }

        public static Player CreateInstance(CharacterRole role, CharacterClass characterClass)
        {
            Player player = null;
            switch (role)
            {
                case CharacterRole.Warrior:
                    switch (characterClass)
                    {
                        case CharacterClass.Human:
                            player = new Player
                            {
                                MagicalDamage = 3,
                                PhysicalDamage = 12,
                                Stamina = 100,
                                SteathStat = 3
                            };
                            break;
                        case CharacterClass.Elf:
                            player = new Player
                            {
                                MagicalDamage = 6,
                                PhysicalDamage = 9,
                                Stamina = 150,
                                SteathStat = 10
                            };
                            break;
                        case CharacterClass.Orc:
                            player = new Player
                            {
                                MagicalDamage = 1,
                                PhysicalDamage = 15,
                                Stamina = 250,
                                SteathStat = 1
                            };
                            break;
                        case CharacterClass.Dwarf:
                            player = new Player
                            {
                                MagicalDamage = 6,
                                PhysicalDamage = 11,
                                Stamina = 90,
                                SteathStat = 3
                            };
                            break;
                    }
                    break;
                //Mệt quá ếu define típ nữa (_.__!!)
                case CharacterRole.Wizzard:
                    switch (characterClass)
                    {   
                        case CharacterClass.Human:
                            player = new Player
                            {
                                
                            };
                            break;
                        case CharacterClass.Elf:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Orc:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Dwarf:
                            player = new Player
                            {

                            };
                            break;
                    }
                    break;
                case CharacterRole.Assassin:
                    switch (characterClass)
                    {
                        case CharacterClass.Human:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Elf:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Orc:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Dwarf:
                            player = new Player
                            {

                            };
                            break;

                    }
                    break;
                case CharacterRole.Archer:
                    switch (characterClass)
                    {
                        case CharacterClass.Human:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Elf:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Orc:
                            player = new Player
                            {

                            };
                            break;
                        case CharacterClass.Dwarf:
                            player = new Player
                            {

                            };
                            break;
                    }
                    break;
                default:
                    player = new Player();
                    break;
            }

            return player;
        }
    }

    public class Player
    {
        public int PhysicalDamage { get; set; }
        public int MagicalDamage { get; set; }
        public int SteathStat { get; set; }
        public int Stamina { get; set; }
    }

    public enum CharacterRole
    {
        Warrior,
        Wizzard,
        Assassin,
        Archer
    }

    public enum CharacterClass
    {
        Human,
        Elf,
        Orc,
        Dwarf
    }
}
