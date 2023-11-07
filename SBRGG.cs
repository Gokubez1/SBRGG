using System;

namespace SBRGG
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gloves = {
            //Made by OnlyGoku
            //Oneshots and Gamepass glovs are removed by default! Go to the bottom for instructions on how to add them!
            //BTW "Oneshots" aren't gloves removed in no oneshot. Its the ones that literally one hit.
            //Last note: These are slap-req gloves.
            "Default",
            "Spin",
            "Duel",
            "Diamond",
            "ZZZZZZZ",
            "Extendend",
            "Brick",
            "Snow",
            "Pull",
            "Flash",
            "Spring",
            "Swapper",
            "Bull",
            "Dice",
            "Ghost",
            "Thanos",
            "Stun",
            "Za Hando",
            "Fort",
            "Magnet",
            "Pusher",
            "Anchor",
            "Space",
            "Boomerang",
            "Dream",
            "Mail",
            "T H I C K",
            "Golden",
            "Squid",
            "Cheeky",
            "Reaper",
            "Replica",
            "Defense",
            "Killstreak",
            "Reverse",
            "Shukuchi",
            "Duelist",
            "Woah",
            "Ice",
            "Gummy",
            "Adios",
            "Blocked",
            "Engineer",
            "Rocky",
            "Coil",
            "Conveyor",
            "Balloony",
            "Phantom",
            "Wormhole",
            "Stop",
            "Track",
            "Tableflip",
            "Shield",
            "Booster",
            "Ping Pong",
            "Baller",
            "Home Run",
            "Whirlwind",
            "Slicer",
            "Excavator",
            "Nightmare",
            "Thor",
            "Cloud",
            "Gravity",
            "Jebaited",
            "Meteor",
            "Guardian Angel",
            "Sun",
            //Next Up: Badge Gloves
            "Acrobat",
            "MEGAROCK",
            "Plague",
            "Hallow Jack",
            "[REDACTED]",
            "Bus",
            "Mitten",
            "Phase",
            "Warp",
            "Bomb",
            "Bubble",
            "Jet",
            "Shard",
            "Potato",
            "Cult",
            "bob",
            "Buddies",
            "Moon",
            "Jupiter",
            "Spy",
            "Detonator",
            "Rage",
            "Trap",
            "Orbit",
            "Hybrid",
            "Slapple",
            "Disarm",
            "Dominance",
            "Link",
            "Chain",
            "Rattlebones",
            "Charge",
            "Tycoon",
            "Confusion",
            "Glitch",
            "Snowball",
            "Elude",
            "RNG",
            "Fish",
            "Moyai",
            "Obby",
            "Voodoo",
            "Goofy",
            "Leash",
            "Flamarang",
            "Kinetic",
            "Berserk",
            "Sparky",
            "Boogie",
            "Recall",
            "Quake",
            "Psycho",
            "Kraken",
            "Counter",
            "Hammer",
            "rob",
            "Rhythm",
            "Rojo",
            "Hitman",
            "Retro",
            "Null",
            "Lure",
            "Tinkerer",
            "Necromancer",
            "Alchemist",
            "Druid"
            //Next up: Oneshots and Gamepasses. These will be disabled by default. To enable them, remove the "//" from them.
            //"OVERKILL", 
            //"Spectator",
            //"CUSTOM",
            //"Ultra Instinct",
            //"God's hand",
            //"Error",
            //"The Flex",
            //"Killerfish"
            };

            Console.WriteLine("How many gloves do you want to generate?");

            int amountgenerated = Convert.ToInt32(Console.ReadLine());

            Random rng = new Random();

            for (int i = 0; i < amountgenerated; i++)
            {
            int number = rng.Next(0, 118); //Set this to 0, 125 if you have oneshots/gamepasses enabled.

            Console.WriteLine("Your random glove is: " + gloves[number]);
            }
          Console.WriteLine("Press any key to close...");
          Console.ReadKey();
        }
    }
}
