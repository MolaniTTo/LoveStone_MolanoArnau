using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.INVOCABLE;
using Assets.Scripts.FIGHTER;
using UnityEngine.Accessibility;

namespace Assets.Scripts.INTERFACES
{
    internal interface IEffect
    {
        public void Effect();

        public void Effect(Fighter target);

        public void Effect(Fighter[] targets);

    }
}
