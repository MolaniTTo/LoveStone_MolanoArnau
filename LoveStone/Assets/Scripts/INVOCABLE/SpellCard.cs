using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Experimental.Licensing;

namespace Assets.Scripts.INVOCABLE
{
    internal class SpellCard : Invocable
    {
        public EntitySO Entity;
        public int CostMana;

        private void Start()
        {
            ShowSpellCard();
        }

        public void ShowSpellCard()
        {
            GameManager.gamemanager.UpdateSpellCard(Entity, CostMana);
        }
        
    }
}
