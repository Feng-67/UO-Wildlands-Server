using System;
using Server.Network;
using Server.Engines.Quests;
using Server.Mobiles;
using System.Collections.Generic;
using System.Linq;

namespace Server.Misc
{
    public class LoginStats
    {
        public static void Initialize()
        {
            // Register our event handler
            EventSink.Login += new LoginEventHandler(EventSink_Login);
        }

        public static void EventSink_Login(LoginEventArgs args)
        {
            Mobile m = args.Mobile;

            if (m.AccessLevel >= AccessLevel.Administrator)
            {
                m.SendMessage("Welcome, {0}! There are {1} user{2} online, with {3} mobile{4} and {5} item{6} in the world.", m.Name, NetState.Instances.Count, NetState.Instances.Count == 1 ? "" : "s", World.Mobiles.Count, World.Mobiles.Count == 1 ? "" : "s", World.Items.Count, World.Items.Count == 1 ? "" : "s");
            }
        }
    }
}
