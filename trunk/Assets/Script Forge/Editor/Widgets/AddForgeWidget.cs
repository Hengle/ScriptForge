//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using UnityEditor; 
using System.Linq;

namespace ScriptForge
{
		public static class AddForgeWidget 
		{

			private static GUIContent InfoLabelContent = new GUIContent("All forges already added", "Nothing to see here");
			private static GUIContent AddSelectedForgesContent = new GUIContent("Add Selected Forges", "Hit it now and forever confirm your peace");

			public static bool ButtonDownState = false;
			private static bool isOpen = false;

			private static bool layersValid = false;
			private static bool sortingLayersValid = false;
			private static bool tagsValid = false;
			private static bool scenesValid = false;
			private static bool inputValid = false; 

			private static bool addLayersForge = false;
			private static bool addSortingLayersForge = false;
			private static bool addTagsForge = false;
			private static bool addScenesForge = false;
			private static bool addInputForge = false;

			public static void Open()
			{
				isOpen = true;
				ButtonDownState = true;

				layersValid = !ScriptForge._widgets.OfType<LayersWidget>().Any();
				sortingLayersValid = !ScriptForge._widgets.OfType<SortingLayersWidget>().Any();
				tagsValid = !ScriptForge._widgets.OfType<TagsWidget>().Any();
				scenesValid = !ScriptForge._widgets.OfType<SceneWidget>().Any();
				inputValid = !ScriptForge._widgets.OfType<InputWidget>().Any();

				addLayersForge = false;
				addSortingLayersForge = false;
				addTagsForge = false;
				addScenesForge = false;
				addInputForge = false;
			}
			
			public static void Close()
			{
				isOpen = false; 
				ButtonDownState = false;
			}

			public static void OnGUI()
			{
				if( isOpen )
				{

				bool hasChoice = false;

					EditorWidget.Spacer();
				if( layersValid )
				{
					GUILayout.BeginHorizontal();
					GUILayout.Space(15.0f );
						addLayersForge = GUILayout.Toggle( addLayersForge, sf_Descriptions.DESCRIPTION_LAYERS_WIDGET, sf_Skins.Button );
					GUILayout.Space(15.0f );
					GUILayout.EndHorizontal();
					hasChoice = true; 
				}

				if( sortingLayersValid )
				{
					GUILayout.BeginHorizontal();
					GUILayout.Space(15.0f );
						addSortingLayersForge = GUILayout.Toggle( addSortingLayersForge, sf_Descriptions.DESCRIPTION_SORTINGLAYERS_WIDGET, sf_Skins.Button );
					GUILayout.Space(15.0f );
					GUILayout.EndHorizontal();
					hasChoice = true; 
				}

				if( tagsValid )
				{
					GUILayout.BeginHorizontal();
					GUILayout.Space(15.0f );
						addTagsForge = GUILayout.Toggle( addTagsForge, sf_Descriptions.DESCRIPTION_TAGS_WIDGET, sf_Skins.Button );
					GUILayout.Space(15.0f );
					GUILayout.EndHorizontal();
					hasChoice = true; 
				}

				if( scenesValid  )
				{
					GUILayout.BeginHorizontal();
					GUILayout.Space(15.0f );
						addScenesForge = GUILayout.Toggle( addScenesForge, sf_Descriptions.DESCRIPTION_SCENE_WIDGET, sf_Skins.Button );
					GUILayout.Space(15.0f );
					GUILayout.EndHorizontal();
					hasChoice = true; 
				}
				/* NOT READY YET
				if( inputValid )
				{
					GUILayout.BeginHorizontal();
					GUILayout.Space(15.0f );
						addInputForge = GUILayout.Toggle( addInputForge, sf_Descriptions.DESCRIPTION_INPUT_WIDGET, sf_Skins.Button );
					GUILayout.Space(15.0f );
					GUILayout.EndHorizontal();
					hasChoice = true; 
				}*/

				if( addLayersForge || addSortingLayersForge || addTagsForge || addScenesForge /*|| addInputForge */ )
				{
					GUILayout.BeginHorizontal();
					GUILayout.Space(10.0f );
					if( GUILayout.Button( AddSelectedForgesContent , sf_Skins.Button, GUILayout.Height(30)))
					{
						AddSelectedForges();
					}
					GUILayout.Space(10.0f );
					GUILayout.EndHorizontal();
				}

				if( !hasChoice )
				{
					GUILayout.Label(InfoLabelContent, sf_Skins.InfoLabel );
				}

					EditorWidget.Spacer();
				}
			}

			private static void AddSelectedForges()
			{

				if( addLayersForge )
					ScriptForge.AddWidget<LayersWidget>();

				if( addSortingLayersForge )
					ScriptForge.AddWidget<SortingLayersWidget>();
				if( addTagsForge )
					ScriptForge.AddWidget<TagsWidget>();
				if( addScenesForge )
					ScriptForge.AddWidget<SceneWidget>();
				if( addInputForge )
					ScriptForge.AddWidget<InputWidget>();

				ScriptForge.Instance.RefreshWidgets();

				Close();
			}
			
		}
}

