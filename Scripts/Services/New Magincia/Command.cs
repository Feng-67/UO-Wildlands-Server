using Server;
using System;
using Server.Mobiles;
using Server.Items;
using Server.Gumps;
using Server.Commands;
using System.Collections.Generic;

namespace Server.Engines.NewMagincia
{
    public static class NewMaginciaCommand
    {
        public static void Initialize()
        {
            CommandSystem.Register("ViewLottos", AccessLevel.GameMaster, new CommandEventHandler(ViewLottos_OnCommand));

            CommandSystem.Register("GenNewMagincia", AccessLevel.GameMaster, new CommandEventHandler(GenNewMagincia_OnCommand));
            CommandSystem.Register("DeleteNewMagincia", AccessLevel.Administrator, Delete);
        }

        private static void Delete(CommandEventArgs e)
        {
            Mobile from = e.Mobile;

            // --- DELETE BAZAAR SYSTEM ---
            if (Server.Engines.NewMagincia.MaginciaBazaar.Instance != null)
            {
                from.SendMessage("Deleting New Magincia Bazaar System...");
                Server.Engines.NewMagincia.MaginciaBazaar.Instance.Delete();
                Server.Engines.NewMagincia.MaginciaBazaar.Instance = null;
                Console.WriteLine("New Magincia Bazaar System deleted.");
            }
            else
            {
                from.SendMessage("Magincia Bazaar System does not exist.");
            }

            // --- DELETE HOUSING LOTTO SYSTEM ---
            if (Server.Engines.NewMagincia.MaginciaLottoSystem.Instance != null)
            {
                from.SendMessage("Deleting New Magincia Housing Lotto System...");
                Server.Engines.NewMagincia.MaginciaLottoSystem.Instance.Delete();
                Server.Engines.NewMagincia.MaginciaLottoSystem.Instance = null;
                Console.WriteLine("New Magincia Housing Lotto System deleted.");
            }
            else
            {
                from.SendMessage("Magincia Housing Lotto System does not exist.");
            }

            // --- UPDATE THE TRACKING SYSTEM ---
            // Since CreateWorldData is inside the CreateWorld class, access it properly
            // The tracking system will be updated when the world loads/saves
            // But we can force it by setting the value in the dictionary

            from.SendMessage("New Magincia deletion complete.");
        }

        public static void GenNewMagincia_OnCommand(CommandEventArgs e)
        {
            Mobile from = e.Mobile;

            from.SendMessage("Generating New Magincia Bazaar System...");

            if (MaginciaBazaar.Instance == null)
            {
                MaginciaBazaar.Instance = new MaginciaBazaar();
                MaginciaBazaar.Instance.MoveToWorld(new Point3D(3729, 2058, 5), Map.Trammel);
                Console.WriteLine("Generated {0} New Magincia Bazaar Stalls.", MaginciaBazaar.Plots.Count);
            }
            else
                Console.WriteLine("Magincia Bazaar System already exists!");

            Console.WriteLine("Generating New Magincia Housing Lotty System..");

            if (MaginciaLottoSystem.Instance == null)
            {
                MaginciaLottoSystem.Instance = new MaginciaLottoSystem();
                MaginciaLottoSystem.Instance.MoveToWorld(new Point3D(3718, 2049, 5), Map.Trammel);

                Console.WriteLine("Generated {0} New Magincia Housing Plots.", MaginciaLottoSystem.Plots.Count);
            }
            else
                Console.WriteLine("Magincia Housing Lotto System already exists!");
        }

        public static void ViewLottos_OnCommand(CommandEventArgs e)
        {
            if (e.Mobile.AccessLevel > AccessLevel.Player)
            {
                e.Mobile.CloseGump(typeof(LottoTrackingGump));
                e.Mobile.SendGump(new LottoTrackingGump());
            }
        }
    }
}
