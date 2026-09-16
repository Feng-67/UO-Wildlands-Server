using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class WeaponStrap : Container
    {
        [Constructable]
        public WeaponStrap() : base(0x2B02)
        {
            Name = "Weapon Strap";
            Hue = 0x901;
            Layer = Layer.Cloak;
            Weight = 1.0;
            LootType = LootType.Blessed;  // <-- protects contents like Instrument Case
        }

        public WeaponStrap(Serial serial) : base(serial)
        {
        }

        public override bool IsArtifact { get { return true; } }

        public override int DefaultMaxItems { get { return 10; } }
        public override int DefaultGumpID { get { return 61; } }

        // Tooltip: weight reduction line
        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
            list.Add("Weight Reduction: 50%");
        }

        // Prevent non-melee-weapon items from being dropped in
        public override bool OnDragDrop(Mobile from, Item dropped)
        {
            if (dropped is BaseWeapon && !(dropped is BaseRanged))
            {
                return base.OnDragDrop(from, dropped);
            }

            from.SendMessage("This strap is designed only for melee weapons.");
            return false;
        }

        // Backup check for targeted drops / other insertion methods
        public override bool CheckHold(Mobile m, Item item, bool message, bool checkItems, int plusItems, int plusWeight)
        {
            if (item is BaseWeapon && !(item is BaseRanged))
            {
                return base.CheckHold(m, item, message, checkItems, plusItems, plusWeight);
            }

            if (message)
                m.SendMessage("This strap can only hold melee weapons.");

            return false;
        }

        // Logic for the 50% Weight Reduction - same pattern as InstrumentCase
        public override void UpdateTotal(Item abrownItem, TotalType type, int delta)
        {
            if (type == TotalType.Weight)
                delta = (int)(delta * 0.5);

            base.UpdateTotal(abrownItem, type, delta);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
