using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class RedCardToken : MonoBehaviour
{
    public string TokenHP;
    public string TokenDMG;

    public void Start()
    {
        GameManager.gamemanager.UpdateToken(TokenHP, TokenDMG);
    }

}

