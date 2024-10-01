using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gamemanager;

    public Image Char, Spell, Token, Power, Avatar;
    public Text CharMana, CharDMG, CharHP, CharDesk, SpellMana, SpellDesk, PowerMana, TokenHP, TokenDMG;
    public Text AvatarName;
    
    private void Awake()
    {
        if(gamemanager == null)
        {
            gamemanager = this;
        }
        else if(gamemanager != this)
        {
            Destroy(gameObject);
        }
        
    }

    public void UpdateSpellCard(EntitySO entity, int CostMana)
    {
        Spell.sprite = entity.Image;
        SpellMana.text = CostMana.ToString();
        SpellDesk.text = entity.Description;
    }

    public void UpdateCharCard(CharacterSO character, int mana, int damage, int hp)
    {
        Char.sprite = character.Design;
        CharMana.text = mana.ToString();
        CharDMG.text = damage.ToString();
        CharHP.text = hp.ToString();
        CharDesk.text = character.Description;
    }

    public void UpdateToken(string hp, string damage)
    {
        TokenHP.text = hp;
        TokenDMG.text = damage;
    }

    public void UpdateAvatar(string name)
    {
       AvatarName.text = name;
    }







}
