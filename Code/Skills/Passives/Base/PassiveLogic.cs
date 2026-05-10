using System;
using Code.Modules;

namespace Code.Skills.Passives.Base
{
    public abstract class PassiveLogic : ICloneablePassiveLogic
    {
        public abstract void Equip(ModuleOwner owner);

        public abstract void UnEquip(ModuleOwner owner);

        public ICloneablePassiveLogic Clone() => MemberwiseClone() as ICloneablePassiveLogic;
    }
}