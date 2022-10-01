using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ULTRAKIT.Extensions;
using ULTRAKIT.Loader;

namespace TestMod
{
    public static class Unlock
    {
        private static void Enable()
        {
            WeaponLoader.SetWeaponUnlock("testbundle", "killGun", true);
            cheat.Disable();
        }

        private static void Disable()
        {
            
        }

        private static void OnUpdate()
        {
            
        }

        public static Cheat cheat = new Cheat
        {
            LongName = "Unlock Gun",
            Identifier = "PetersonE.test_mod.gun_unlock",
            ButtonEnabledOverride = "Enabled",
            ButtonDisabledOverride = "Disabled",
            DefaultState = false,
            PersistenceMode = StatePersistenceMode.NotPersistent,
            EnableScript = Enable,
            DisableScript = Disable,
            UpdateScript = OnUpdate,
        };
    }
}
