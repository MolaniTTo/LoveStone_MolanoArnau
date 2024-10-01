using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.INVOCABLE;
using Assets.Scripts.INTERFACES;

namespace Assets.Scripts.CARDS
{
    internal class ArgentSquire : CharacterCard, IEffect
    {
        private void Start()
        {
            ShowCard();     
        }

        public void Effect()
        {
            throw new NotImplementedException();
        }

        public void Effect(Fighter target)
        {
            target.CurrentHP -= 1;
        }

        public void Effect(Fighter[] targets)
        {
            throw new NotImplementedException();
        }
    }
}
