using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text, Image 등의UI관련 변수 등을 사용할수 있게됩니다
using UnityEngine.SceneManagement;
 
public class PanelOpener : MonoBehaviour
{
    public Image TestIm0; //기존에 존제하는 이미지
    public Sprite Im1; //바뀌어질 이미지
    public Sprite Im2;
    public Sprite Im3;
    public Sprite Im4;
    public Sprite Im5;
    public int count = 0;
 
    public void ChangeImage()
    {
        if(count == 0){
            TestIm0.sprite = Im1;
            count ++; //TestImage에 SourceImage를 TestSprite에 존제하는 이미지로 바꾸어줍니다
        }else if(count == 1){
            TestIm0.sprite = Im2;
            count ++;
        }else if(count == 2){
            TestIm0.sprite = Im3;
            count ++;
        }else if(count == 3){
            TestIm0.sprite = Im4;
            count ++;
        }else if(count == 4){
            count ++;
            TestIm0.sprite = Im5;
        
        }
        
    }

}