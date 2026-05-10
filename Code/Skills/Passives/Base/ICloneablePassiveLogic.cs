namespace Code.Skills.Passives.Base
{
    public interface ICloneablePassiveLogic : IPassiveLogic
    {
        public ICloneablePassiveLogic Clone();
    }
}