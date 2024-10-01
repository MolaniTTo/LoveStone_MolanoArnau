using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class Anduin : MonoBehaviour
{
    public string AvatarName;

    public void Start()
    {
        GameManager.gamemanager.UpdateAvatar(AvatarName);
    }

    public void ChangeAvatarName(string newName)
    {
        AvatarName = newName;
        GameManager.gamemanager.UpdateAvatar(AvatarName);
    }
}

