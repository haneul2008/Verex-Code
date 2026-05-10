using Code.Core;
using UnityEngine;

namespace Code.Skills.Passives.Base
{
    public abstract class PassiveDataSO : ScriptableObject, IDisplayable
    {
        public Sprite Icon { get; private set; }
        public string DisplayName { get; private set; }
        public string Description { get; private set; }
        
        public string passiveName;

        public abstract IPassiveLogic GetLogic();
    }
}