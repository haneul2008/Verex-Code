using System;
using System.Linq.Expressions;
using UnityEngine;

namespace Code.Skills.Passives.Base
{
    public abstract class LogicPassiveDataSO : PassiveDataSO
    {
        [SerializeReference, SubclassSelector] public ICloneablePassiveLogic passiveLogic;

        public override IPassiveLogic GetLogic()
        {
            if(passiveLogic == null) return null;

            return passiveLogic.Clone();
        }
    }
}