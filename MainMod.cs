using MelonLoader;
using HarmonyLib;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Trash;

[assembly: MelonInfo(typeof(BetterThrowing.BetterThrowing), BetterThrowing.BuildInfo.Name, BetterThrowing.BuildInfo.Version, BetterThrowing.BuildInfo.Author, BetterThrowing.BuildInfo.DownloadLink)]
[assembly: MelonColor()]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace BetterThrowing
{
    public static class BuildInfo
    {
        public const string Name = "Better Throwing";
        public const string Description = "A mod that improves throwing mechanics. Such as knockback on NPC's and a throw strength meter.";
        public const string Author = "3Exchange";
        public const string Version = "1.0";
        public const string DownloadLink = null;
    }

    public class BetterThrowing : MelonMod
    {
        [HarmonyPatch(typeof(TrashItem), "Awake")]
        public static class Player_Pickup
        {
            public static bool Prefix(TrashItem __Instance, Player __instance)
            {
                MelonLogger.Msg("Product is being consumed");
                return true;
            }
        }
    }
}
