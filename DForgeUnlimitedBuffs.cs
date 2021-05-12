using DForgeUnlimtedBuffs;
using Terraria;
using Terraria.ModLoader;

namespace DForgeUnlimitedBuffs
{
    public class DForgeUnlimitedBuffs : Mod
    {
        public DForgeUnlimitedBuffs() 
        {
        }
    }

    public class CheckDefenderForgeInventory : GlobalItem
    {
        public override void UpdateInventory(Item item, Player player)
        {
            int REQUIRED_QTY = ModContent.GetInstance<Config>().BuffQuantity;

            for (int i = 0; i < 40; ++i)
            {
                if (player.bank3.item[i].buffType > 0 && !player.bank3.item[i].summon && player.bank3.item[i].stack >= REQUIRED_QTY)
                {
                    player.AddBuff(player.bank3.item[i].buffType, 2, true);
                }
            }
        }
    }
}