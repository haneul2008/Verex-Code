using System;
using System.Collections.Generic;
using Code.Modules;
using Code.Skills.Passives.Base;
using UnityEngine;

namespace Code.Skills.Passives
{
    public class PassiveTester : MonoBehaviour
    {
        [SerializeField] private ModuleOwner target;
        [SerializeField] private PassiveDataSO passiveData;

        private readonly Dictionary<PassiveDataSO, IPassiveLogic> _passiveLogicPairs = new Dictionary<PassiveDataSO, IPassiveLogic>();

        private void Awake()
        {
            RegisterData();
        }

        [ContextMenu("Register data")]
        public void RegisterData()
        {
            _passiveLogicPairs.TryAdd(passiveData, passiveData.GetLogic());
        }
        
        [ContextMenu("Equip")]
        public void Equip()
        {
            if(IsDataRegistered(out IPassiveLogic logic) == false) return;
            
            logic.Equip(target);
        }
        
        [ContextMenu("UnEquip")]
        public void UnEquip()
        {
            if(IsDataRegistered(out IPassiveLogic logic) == false) return;
            
            logic.UnEquip(target);
        }

        [ContextMenu("Print logic id")]
        public void PrintLogicId()
        {
            if(IsDataRegistered(out IPassiveLogic logic) == false) return;

            print(logic.GetHashCode());
        }

        private bool IsDataRegistered(out IPassiveLogic passiveLogic)
        {
            passiveLogic = null;
            
            if (passiveData is null || _passiveLogicPairs.TryGetValue(passiveData, out IPassiveLogic logic) == false)
            {
                Debug.LogWarning("passive data is not registered");
                return false;
            }

            passiveLogic = logic;
            return true;
        }
    }
}