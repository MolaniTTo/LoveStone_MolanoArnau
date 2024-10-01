using UnityEngine.TextCore.Text;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.Scripts.INVOCABLE
{
    internal class CharacterCard : Card
    {
        public CharacterSO Character;

        public void ShowCard()
        {
            GameManager.gamemanager.UpdateCharCard(Character, Mana, Character.Damage, Character.Health);
        }

        public void Invoke()
        {
            ShowCard();
        }
        

    }
}
