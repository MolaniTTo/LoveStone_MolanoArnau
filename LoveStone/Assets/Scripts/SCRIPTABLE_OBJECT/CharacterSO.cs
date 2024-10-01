using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


    [CreateAssetMenu(fileName = "Character", menuName = "ScriptableObject/Character")]
    public class CharacterSO : ScriptableObject
{
    public string Name;
    public Sprite Design;
    public string Description;
    public int Damage;
    public int Health;
}

