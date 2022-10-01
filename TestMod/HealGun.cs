using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TestMod
{
    public class HealGun : MonoBehaviour
    {
        [SerializeField]
        private int health = 10;

        public void Update()
        {
            if (MonoSingleton<InputManager>.Instance.InputSource.Fire1.WasPerformedThisFrame)
            {
                NewMovement.Instance.GetHealth(health, true);
            }
        }
    }
}
