using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ULTRAKIT.Extensions.Classes;

namespace TestMod
{
    public static class ExploderCheat
    {
        private static void Enable()
        {

            Debug.Log("[PetersonE.test_mod] exploder_cheat - enabled");
        }

        private static void Disable()
        {
            Debug.Log("[PetersonE.test_mod] exploder_cheat - disabled");
        }

        private static void OnUpdate()
        {
            foreach (EnemyIdentifier enemy in GameObject.FindObjectsOfType<EnemyIdentifier>())
            {
                enemy.Invoke("Explode", 0.05f);
            }
        }

        public static Cheat cheat = new Cheat
        {
            LongName = "Exploder Cheat",
            Identifier = "PetersonE.test_mod.exploder_cheat",
            ButtonEnabledOverride = "Exploding",
            ButtonDisabledOverride = "Not Exploding",
            DefaultState = false,
            PersistenceMode = StatePersistenceMode.Persistent,
            EnableScript = Enable,
            DisableScript = Disable,
            UpdateScript = OnUpdate,
        };
    }
}
