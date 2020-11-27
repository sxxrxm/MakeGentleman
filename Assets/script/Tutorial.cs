using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Tutorial_Start", PlayerPrefs.GetInt("Tutorial_Start", 0));

        if(PlayerPrefs.GetInt("Tutorial_Start")==0){
            Debug.Log("튜토리얼을 시작합니다.");
            PlayerPrefs.SetInt("Tutorial_Start",1);
            SceneManager.LoadScene("saristory");
            PlayerPrefs.Save();
            
        }
        else if(PlayerPrefs.GetInt("Tutorial_Start")!=0){
            Debug.Log("튜토리얼을 시작한 경험이 있습니다.");
            SceneManager.LoadScene("main");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
