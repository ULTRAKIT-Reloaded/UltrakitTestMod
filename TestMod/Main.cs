﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMM;
using UnityEngine;
using UnityEngine.SceneManagement;
using HarmonyLib;
using System.Collections;
using System.IO;
using ULTRAKIT.Loader.Loaders;

namespace TestMod
{
    [UKPlugin("Test Mod", "1.0.1", "Testing", false, false)]
    public class TestMod : UKMod
    {
        AssetBundle bundle = AssetBundle.LoadFromFile(Directory.GetCurrentDirectory() + @"\BepInEx\UMM Mods\TestMod\testBundle.assetBundle");

        public override void OnModLoaded()
        {
            Debug.Log("[PETERSONE.test_mod] Mod loaded successfully");
            SceneManager.sceneLoaded += OnSceneLoaded;
            WeaponLoader.LoadWeapons(bundle);
        }

        public override void OnModUnload()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
            WeaponLoader.UnloadWeapons("testbundle");
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            CheatsManager.Instance.RegisterCheat(HealthCheat.cheat, "test_mod");
            CheatsManager.Instance.RegisterCheat(ExploderCheat.cheat, "test_mod");
            CheatsManager.Instance.RegisterCheat(Unlock.cheat, "test_mod");
        }
    }
}
