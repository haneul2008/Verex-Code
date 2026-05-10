using Code.Modules;

namespace Code.Skills.Passives.Base
{
    public interface IPassiveLogic
    {
        public void Equip(ModuleOwner owner);
        public void UnEquip(ModuleOwner owner);
    }
}