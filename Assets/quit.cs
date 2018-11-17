using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();



    }

}
