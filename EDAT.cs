using EDAT.Items;
using EDAT.Tiles;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;

namespace EDAT
{
	public class EDAT : Mod
	{
		private Texture2D musicBoxes;

		public bool unloadCalled = false;

		public override void Load()
		{
			unloadCalled = false;

			musicBoxes = Main.tileTexture[TileID.MusicBoxes];

			if (!Main.dedServ)
			{
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime"), ModContent.ItemType<KingSlime>(), ModContent.TileType<KingSlimeTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EyeOfCthulhu"), ModContent.ItemType<EyeOfCthulhu>(), ModContent.TileType<EyeOfCthulhuTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/EaterOfWorlds"), ModContent.ItemType<EaterOfWorlds>(), ModContent.TileType<EaterOfWorldsTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BrainOfCthulhu"), ModContent.ItemType<BrainOfCthulhu>(), ModContent.TileType<BrainOfCthulhuTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Twins"), ModContent.ItemType<Twins>(), ModContent.TileType<TwinsTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SkeletronPrime"), ModContent.ItemType<SkeletronPrime>(), ModContent.TileType<SkeletronPrimeTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DukeFishron"), ModContent.ItemType<DukeFishron>(), ModContent.TileType<DukeFishronTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LunaticCultist"), ModContent.ItemType<LunaticCultist>(), ModContent.TileType<LunaticCultistTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeRain"), ModContent.ItemType<SlimeRain>(), ModContent.TileType<SlimeRainTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Party"), ModContent.ItemType<Party>(), ModContent.TileType<PartyTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/FrostLegion"), ModContent.ItemType<FrostLegion>(), ModContent.TileType<FrostLegionTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle"), ModContent.ItemType<JungleOverworld>(), ModContent.TileType<JungleOverworldTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GlowingMushroom"), ModContent.ItemType<MushroomOverworld>(), ModContent.TileType<MushroomOverworldTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundDesert"), ModContent.ItemType<UndergroundDesert>(), ModContent.TileType<UndergroundDesertTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Marble"), ModContent.ItemType<Marble>(), ModContent.TileType<MarbleTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Granite"), ModContent.ItemType<Granite>(), ModContent.TileType<GraniteTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SpiderCave"), ModContent.ItemType<SpiderNest>(), ModContent.TileType<SpiderNestTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Village"), ModContent.ItemType<Town>(), ModContent.TileType<TownTile>());
			}
		}

		public override void Unload()
		{
			unloadCalled = true;

			if (!Main.dedServ)
				Main.tileTexture[TileID.MusicBoxes] = musicBoxes;
		}

		public override void PostSetupContent()
		{
			if (!Main.gameMenu)
			{
				if (!Main.dedServ)
				{
					musicBoxes = Main.tileTexture[TileID.MusicBoxes];
					Helper.ReplaceItemTexture(ItemID.MusicBoxCorruption, "Items/Replacments/Corruption", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxCrimson, "Items/Replacments/Crimson", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxDesert, "Items/Replacments/Desert", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxBoss3, "Items/Replacments/Destroyer", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxFrostMoon, "Items/Replacments/FrostMoon", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxBoss4, "Items/Replacments/Golem", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxTheHallow, "Items/Replacments/Hallow", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxHell, "Items/Replacments/Hell", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxIce, "Items/Replacments/Ice", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxMartians, "Items/Replacments/Martian", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxEerie, "Items/Replacments/Meteor", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxLunarBoss, "Items/Replacments/MoonLord", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxDD2, "Items/Replacments/OOA", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxTowers, "Items/Replacments/Pillar", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxBoss5, "Items/Replacments/QueenBee", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxRain, "Items/Replacments/Rain", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxSnow, "Items/Replacments/Snow", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxEclipse, "Items/Replacments/SolarEclipse", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxSpace, "Items/Replacments/Space", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxTitle, "Items/Replacments/Title", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxUndergroundCrimson, "Items/Replacments/UndergroundCrimson", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxUndergroundCorruption, "Items/Replacments/UndergroundCorruption", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxUndergroundHallow, "Items/Replacments/UndergroundHallow", unloadCalled);
					Helper.ReplaceItemTexture(ItemID.MusicBoxBoss2, "Items/Replacments/WallOfFlesh", unloadCalled);
				}
			}
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.musicVolume != 0)
			{
				if (Main.myPlayer != -1 && !Main.gameMenu && Main.LocalPlayer.active)
				{
					//Bosses as first priority for replacing themes
					if (Main.npc.Any(n => n.active && n.boss))
					{
						if (NPC.AnyNPCs(NPCID.KingSlime))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/KingSlime");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.EyeofCthulhu))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/EyeOfCthulhu");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.EaterofWorldsHead))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/EaterOfWorlds");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.BrainofCthulhu))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/BrainOfCthulhu");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.Retinazer) || NPC.AnyNPCs(NPCID.Spazmatism))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Twins");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.SkeletronPrime))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/SkeletronPrime");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.DukeFishron))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/DukeFishron");
							priority = MusicPriority.BossHigh;
						}
						if (NPC.AnyNPCs(NPCID.CultistBoss))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/LunaticCultist");
							priority = MusicPriority.BossHigh;
						}
					}
					else
					{
						//Invasions
						if (Main.slimeRain)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeRain");
							priority = MusicPriority.Event;
						}
						if (Main.bloodMoon)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/BloodMoon");
							priority = MusicPriority.Event;
						}
						if (BirthdayParty.PartyIsUp && ExtraBiomes.ZoneTown(Main.LocalPlayer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Party");
							priority = MusicPriority.Event;
						}
						if (NPC.AnyNPCs(NPCID.MisterStabby) || NPC.AnyNPCs(NPCID.SnowmanGangsta) || NPC.AnyNPCs(NPCID.SnowBalla))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/FrostLegion");
							priority = MusicPriority.Event;
						}
						//Biomes
						if (Main.LocalPlayer.ZoneJungle && !Main.LocalPlayer.ZoneRockLayerHeight)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Jungle");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneGlowshroom && Main.LocalPlayer.ZoneOverworldHeight)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/GlowingMushroom");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneCorrupt && Main.LocalPlayer.ZoneRockLayerHeight && ModContent.GetInstance<Config>().UndergroundCorruptionTheme)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCorruption");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneCrimson && Main.LocalPlayer.ZoneRockLayerHeight && ModContent.GetInstance<Config>().UndergroundCrimsonTheme)
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundCrimson");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneUndergroundDesert && (Main.LocalPlayer.ZoneRockLayerHeight || Main.LocalPlayer.ZoneDirtLayerHeight))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/UndergroundDesert");
							priority = MusicPriority.BiomeMedium;
						}
						if (ExtraBiomes.ZoneMarble(Main.LocalPlayer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Marble");
							priority = MusicPriority.BiomeMedium;
						}
						if (ExtraBiomes.ZoneGranite(Main.LocalPlayer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Granite");
							priority = MusicPriority.BiomeMedium;
						}
						if (ExtraBiomes.ZoneSpiderCave(Main.LocalPlayer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/SpiderCave");
							priority = MusicPriority.BiomeMedium;
						}
						if (ExtraBiomes.ZoneTown(Main.LocalPlayer))
						{
							music = GetSoundSlot(SoundType.Music, "Sounds/Music/Village");
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneSnow && !Main.LocalPlayer.ZoneRockLayerHeight)
						{
							music = MusicID.Ice;
							priority = MusicPriority.BiomeMedium;
						}
						if (Main.LocalPlayer.ZoneSnow && Main.LocalPlayer.ZoneRockLayerHeight)
						{
							music = MusicID.Snow;
							priority = MusicPriority.BiomeMedium;
						}
					}
				}
			}
		}
	}
}