using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public void OnClickExit(){

        Application.Quit();
        Debug.Log("Exit Button Click");
    }
}
