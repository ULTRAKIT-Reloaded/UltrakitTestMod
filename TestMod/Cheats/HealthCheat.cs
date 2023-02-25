using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ULTRAKIT.Extensions.Classes;

namespace TestMod
{
    public static class HealthCheat
    {
        private static void Enable()
        {
            Debug.Log("[PetersonE.test_mod] health_cheat - enabled");
        }

        private static void Disable()
        {
            Debug.Log("[PetersonE.test_mod] health_cheat - disabled");
        }

        private static void OnUpdate()
        {
            NewMovement.Instance.hp = 300;
        }

        public static Cheat cheat = new Cheat
        {
            LongName = "Health Cheat",
            Identifier = "PetersonE.test_mod.health_cheat",
            ButtonEnabledOverride = "Enabled",
            ButtonDisabledOverride = "Disabled",
            DefaultState = false,
            PersistenceMode = StatePersistenceMode.Persistent,
            EnableScript = Enable,
            DisableScript = Disable,
            UpdateScript = OnUpdate,
        };
    }
}
