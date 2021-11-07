using MelonLoader;
using HarmonyLib;

using Assets.Scripts.Unity.UI_New.InGame;
using Assets.Main.Scenes;
using BTD_Mod_Helper.Extensions;
using Assets.Scripts.Unity.Bridge;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using Assets.Scripts.Simulation.Track;
using Assets.Scripts.Unity.Map;
using UnityEngine;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Utils;
using System;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Unity;
using Assets.Scripts.Simulation.Towers.Projectiles;
using System.IO;
using BTD_Mod_Helper.Api.Towers;
using Assets.Scripts.Unity.UI_New.InGame.StoreMenu;
using UnityEngine.UI;
using Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;
using System.Collections.Generic;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Models.Towers.Projectiles.Behaviors;
using Assets.Scripts.Simulation.Objects;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers.Behaviors.Attack;
using System.Reflection;
using Assets.Scripts.Simulation.Towers.Behaviors.Abilities;
using Assets.Scripts.Unity.UI_New.InGame.RightMenu;


[assembly: MelonInfo(typeof(TemplateMod.TemplateMain), "Saber Monkey", "1.0.0", "Zukoix")]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]
namespace TemplateMod
{
	public class TemplateMain : BloonsTD6Mod
    {
		// Github API URL used to check if this mod is up to date. For example:
		// public override string GithubReleaseURL => "https://api.github.com/repos/gurrenm3/BTD-Mod-Helper/releases";

		// As an alternative to a GithubReleaseURL, a direct link to a web-hosted version of the .cs file
		// that has the "MelonInfo" attribute with the version of your mod
		//public override string MelonInfoCsURL => "https://raw.githubusercontent.com/doombubbles/BTD6-Mods/main/MegaKnowledge/Main.cs";

		// The link to your normal GitHub Releases page if you're using those, or a direct link to your dll file
		// public override string LatestURL => "https://github.com/gurrenm3/BTD-Mod-Helper/releases/latest ";


		public override void OnMainMenu()
		{
			base.OnMainMenu();
		}

		public override void OnApplicationStart()
        {
            MelonLogger.Msg("Saber Monkey Mod Loaded!");
        }
    }
}
