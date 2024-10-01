using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
    public abstract class Fighter : MonoBehaviour
    {
        public int Damage { get; set; }
        public int HP { get; set; }
        public int Team { get; set; }
        public int CurrentHP { get; set; }
        public int CurrentDamage { get; set; }

        public void Attack(Fighter fighter)
        {
            
        }
        
    }

