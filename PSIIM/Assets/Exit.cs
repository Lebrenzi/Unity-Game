using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool end;
    public void ExitGame()
    {
        Application.Quit();
    }

}
