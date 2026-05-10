using System;
using Code.Modules;
using Code.Skills.Passives.Base;
using UnityEngine;

namespace Code.Skills.Passives.Impl.ActivePassives
{
    [Serializable]
    public class TestLogic : PassiveLogic
    {
        [SerializeField] private int testValue;
        
        public override void Equip(ModuleOwner owner)
        {
            Debug.Log($"Equipped! value : {testValue}");
        }

        public override void UnEquip(ModuleOwner owner)
        {
            Debug.Log($"UnEquipped! value : {testValue}");
        }
    }
}