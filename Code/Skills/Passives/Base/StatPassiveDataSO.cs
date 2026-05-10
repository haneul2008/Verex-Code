using System.Collections.Generic;
using Code.Entities.StatSystem;
using Code.Modules;
using UnityEngine;

namespace Code.Skills.Passives.Base
{
    [CreateAssetMenu(fileName = "Stat passive data", menuName = "SO/Skill/Passive/StatPassive", order = 0)]
    public class StatPassiveDataSO : PassiveDataSO, IPassiveLogic
    {
        public List<StatPair> targetStats;

        public void Equip(ModuleOwner owner)
        {
            EntityStatCompo statCompo = owner.GetModule<EntityStatCompo>();
            
            foreach (StatPair statPair in targetStats)
            {
                statCompo.AddModifier(statPair.stat, passiveName, statPair.value);
            }
        }

        public void UnEquip(ModuleOwner owner)
        {
            EntityStatCompo statCompo = owner.GetModule<EntityStatCompo>();
            
            foreach (StatPair statPair in targetStats)
            {
                statCompo.RemoveModifier(statPair.stat, passiveName);
            }
        }

        public override IPassiveLogic GetLogic() => this;
    }
}