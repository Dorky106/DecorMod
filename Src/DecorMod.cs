using System.IO;

namespace DecorMod
{
	[ModLoader.ModManager]
	public static class DecorMod
	{
		public static string ModFolder;
		[ModLoader.ModCallback(ModLoader.EModCallbackType.OnAssemblyLoaded, "DecorMod.OnAssemblyLoaded")]
		public static void OnAssemblyLoaded(string path)
		{
			ModFolder = Path.GetDirectoryName(path);
		}

		[ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "DecorMod.AfterStartup")]
		[ModLoader.ModCallbackProvidesFor("phentrixgames.newcolonyapi.AfterStartup")]
		public static void AfterStartup()
		{
			PhentrixGames.NewColonyAPI.Managers.ModManager.RegisterMod("DecorMod", ModFolder);
		}
	}
}