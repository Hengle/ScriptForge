﻿ 
 
using System.Collections.ObjectModel;
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

		// An array containing all the names of our scenes.
		private static string[] m_Names = new string[]
		{
			"MainMenu",
			"LoadingScreen",
			"BossBattle",
			"Ending",
		};
		
		/// <summary>		
		/// Gets a read only version of the array of scene names in the build settings. 
		/// </summary>		
		public static ReadOnlyCollection<string> Names(string sceneName)
		{		
		    return new ReadOnlyCollection<string>(m_Names);
		}
		
		/// <summary>		
		/// This function takes in a string name and returns 		
		/// the scene ID with that name. If the name is invalid		
		/// it return -1.		
		/// </summary>		
		/// <returns>The ID of the requested scene name.</returns>		
		/// <param name="sceneName">A name of the scene you want the ID for.</param>		
		public static int SceneNameToID(string sceneName)
		{
		    for (int i = 0; i < m_Names.Length; i++)
		    {
				if(m_Names[i].Equals(sceneName, System.StringComparison.OrdinalIgnoreCase))
		        {
					return i;
		        }
		    }
		    //No scene found with that ID.		
		    return -1;
		}
		
		/// <summary>		
		/// This takes a scene ID and returns the name. If		
		/// the ID is invalid it returns 'None'.		
		/// </summary>		
		/// <returns>The identifier of the scene.</returns>		
		/// <param name="sceneIndex">An name of the scene with the requested ID</param>		
		public static string SceneIndexToName(int sceneIndex)
		{
		    if (sceneIndex >= 0 && sceneIndex < m_Names.Length)
		    {
		        return m_Names[sceneIndex];
		    }
		
		    return string.Empty;
		}
		
		/// <summary>		
		/// Determines if it is valid scene name.		
		/// </summary>		
		/// <returns><c>true</c> if is valid scene name the specified sceneName; otherwise, <c>false</c>.</returns>		
		/// <param name="sceneName">The name of the scene in build settings.</param>		
		public static bool IsValidSceneName(string sceneName)		
		{		
			for( int i = 0; i < m_Names.Length; i++)		
			{		
				if(m_Names[i].Equals(sceneName, System.StringComparison.OrdinalIgnoreCase))
				{
					return true;	
				}	
			}		
					
			return false;		
		}
		
		/// <summary>		
		/// Determines if is valid scene ID.		
		/// </summary>		
		/// <returns><c>true</c> if is valid scene I the specified anID; otherwise, <c>false</c>.</returns>		
		/// <param name="anID">An I.</param>		
		public static bool IsValidSceneID(int sceneID)		
		{		
			return sceneID >= 0 && sceneID < m_Names.Length;
		}
	}
}

