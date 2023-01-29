using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace SimpleLevels {
	[Label("Config")]
	class SimpleLevelsServerConfig : ModConfig {
			public override ConfigScope Mode => ConfigScope.ServerSide;
			public static SimpleLevelsServerConfig Instance;

			[Label("Damage Multiplier")]
			[Tooltip("The multiplier for the damage buff, 0.1% steps, caps at 1000.")]
			[Range(0, 1000)]
			[Increment(1)]
			[DefaultValue(20)]
			public int damageMultiplier;

			[Label("HP Multiplier")]
			[Tooltip("The multiplier for the hp buff, 0.1% steps, caps at 1000.")]
			[Range(0, 1000)]
			[Increment(1)]
			[DefaultValue(10)]
			public int hpMultiplier;

	}
}