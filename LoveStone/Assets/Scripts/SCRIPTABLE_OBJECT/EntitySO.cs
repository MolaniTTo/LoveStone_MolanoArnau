using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

    [CreateAssetMenu(fileName = "Entity", menuName = "ScriptableObject/Entity")]
    public class EntitySO : ScriptableObject
    {

        public string Name;
        public Sprite Image;
        public string Description;
    }

