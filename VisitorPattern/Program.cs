using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Media;

namespace VisitorPattern
{
    class Program
    {
        private static Player _player;
        static void Main(string[] args)
        {
            const CharacterRole characterRole = CharacterRole.Warrior;
            const CharacterClass characterClass = CharacterClass.Human;

            _player = CreateInstance(characterRole, characterClass);

            Console.WriteLine("The {0} is {1} class has {2} physical damage, {3} magical damage with {4} stamina and {5} steath stat!!!!",
                characterRole, characterClass, _player.PhysicalDamage, _player.MagicalDamage, _player.Stamina, _player.SteathStat);

            Console.ReadKey();
        }

        public static Player CreateInstance(CharacterRole role, CharacterClass characterClass)
        {
            var player = new Player
            {
                CharacterRole = CharacterRole.Warrior,
                CharacterClass = CharacterClass.Human
            };

            PlayerVistorCollection.Register().Visit(player);

            return player;
        }
    }

    
    public abstract class PlayerVisitor
    {
        public CharacterClass CharacterClass { get; set; }
        public CharacterRole CharacterRole { get; set; }
        public abstract Player Visit(Player player);
    }

    public class PlayerVistorCollection : Collection<PlayerVisitor>
    {
        public void Visit(Player player)
        {
            foreach (var playerVisitor in this)
            {
                if (playerVisitor.CharacterClass == player.CharacterClass && playerVisitor.CharacterRole == player.CharacterRole)
                {
                    playerVisitor.Visit(player);
                }
            }
        }
        public static PlayerVistorCollection Register()
        {
            var listVisitors = new PlayerVistorCollection
            {
                new WarriorHumanVisitor(),
                new WarriorElfVisitor(),
                new WarriorOrcVisitor(),
                new WarriorDwarfVisitor()
            };

            return listVisitors;
        }
    }

    #region WarriorVisitor
    public class WarriorHumanVisitor : PlayerVisitor
    {
        public WarriorHumanVisitor()
        {
            CharacterRole = CharacterRole.Warrior;
            CharacterClass = CharacterClass.Human;
        }
        public override Player Visit(Player player)
        {
            player.MagicalDamage = 3;
            player.PhysicalDamage = 12;
            player.Stamina = 100;
            player.SteathStat = 3;

            return player;
        }
    }

    public class WarriorElfVisitor : PlayerVisitor
    {
        public WarriorElfVisitor()
        {
            CharacterRole = CharacterRole.Warrior;
            CharacterClass = CharacterClass.Elf;
        }
        public override Player Visit(Player player)
        {
            player.MagicalDamage = 6;
            player.PhysicalDamage = 9;
            player.Stamina = 150;
            player.SteathStat = 10;

            return player;
        }
    }

    public class WarriorOrcVisitor : PlayerVisitor
    {
        public WarriorOrcVisitor()
        {
            CharacterRole = CharacterRole.Warrior;
            CharacterClass = CharacterClass.Orc;
        }
        public override Player Visit(Player player)
        {
            player.MagicalDamage = 1;
            player.PhysicalDamage = 15;
            player.Stamina = 250;
            player.SteathStat = 1;

            return player;
        }
    }
    public class WarriorDwarfVisitor : PlayerVisitor
    {
        public WarriorDwarfVisitor()
        {
            CharacterRole = CharacterRole.Warrior;
            CharacterClass = CharacterClass.Dwarf;
        }
        public override Player Visit(Player player)
        {
            player.MagicalDamage = 6;
            player.PhysicalDamage = 11;
            player.Stamina = 90;
            player.SteathStat = 3;

            return player;
        }
    }

    #endregion
    public class Player
    {
        public CharacterRole CharacterRole { get; set; }
        public CharacterClass CharacterClass { get; set; }
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
