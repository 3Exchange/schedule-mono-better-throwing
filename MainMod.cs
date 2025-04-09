using MelonLoader;
using HarmonyLib;
// using ScheduleOne.Product;
// using ScheduleOne.PlayerScripts;

[assembly: MelonInfo(typeof(ExampleMod.ExampleMod), ExampleMod.BuildInfo.Name, ExampleMod.BuildInfo.Version, ExampleMod.BuildInfo.Author, ExampleMod.BuildInfo.DownloadLink)]
[assembly: MelonColor()]
[assembly: MelonGame("TVGS", "Schedule I")]

namespace ExampleMod
{
    public static class BuildInfo
    {
        public const string Name = "Better Throwing";
        public const string Description = "A mod that improves throwing mechanics. Such as knockback on NPC's and a throw strength meter.";
        public const string Author = "3Exchange";
        public const string Version = "1.0";
        public const string DownloadLink = null;
    }

    public class ExampleMod : MelonMod
    {
        // [HarmonyPatch(typeof(Player), "ConsumeProduct")]
        public static class Player_ConsumeProduct_Patch
        {
            // public static bool Prefix(Player __instance, ProductItemInstance product)
            // {
            //     MelonLogger.Msg("Product is being consumed");
            //     return true;
            // }
        }
    }
}
