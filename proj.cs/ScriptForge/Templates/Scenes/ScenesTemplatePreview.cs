﻿ 
 
//------------------------------------------------------------------------------
// <auto-generated>
// Scenes.cs
// This code was generated by ScriptForge. To rebuild the code go to 
// Project Settings ->Script Forge and on that window hit generate all. Any
// changes made to this script will be overwritten.  
// Asset Hash: b62288ca78c2769c271afefe24922517
// </auto-generated>
//------------------------------------------------------------------------------
namespace ScriptforgeGenerated
{
	public static partial class Scenes
	{
		/// <summary>
		/// An enum that contains the names of every scene that
		/// is in your project.
		/// </summary>
		public enum Types
		{
			MainMenu,
			LoadingScreen,
			BossBattle,
			Ending
		}

		public const string MAINMENU = "MainMenu";
		public const string LOADINGSCREEN = "LoadingScreen";
		public const string BOSSBATTLE = "BossBattle";
		public const string ENDING = "Ending";

		/// <summary>
		/// Returns back an new array containing all the
		/// scenes that are in the build settings. You
		/// should cache this value as it creates a new
		/// array each time.
		/// </summary>
		public static string[] Names
		{
			get
			{
				return new string[]
				{
					"MainMenu",
					"LoadingScreen",
					"BossBattle",
					"Ending",
				};
			}
		}
	}
}

