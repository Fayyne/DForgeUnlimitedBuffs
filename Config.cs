using Microsoft.Xna.Framework;
using System.ComponentModel;
using System.Collections.Generic;
using Terraria.ModLoader.Config;

namespace DForgeUnlimtedBuffs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        public static Config Instance;

        [Label("Buff Stack Quantity")]
        [Tooltip("The amount a stack needs to be to provide a buff.")]
        [DefaultValue(30)]
        [Range(1, 1000)]
        [Increment(5)]
        public int BuffQuantity;
    }
}
