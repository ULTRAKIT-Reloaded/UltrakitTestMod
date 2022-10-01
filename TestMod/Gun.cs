using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TestMod
{
    public class Gun : MonoBehaviour
    {
        [SerializeField]
        private int damage = 10;

        public void Update()
        {
            if (MonoSingleton<InputManager>.Instance.InputSource.Fire1.WasPerformedThisFrame)
            {
                MonoSingleton<NewMovement>.Instance.GetHurt(damage, false);
            }
        }
    }
}
