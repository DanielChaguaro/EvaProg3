using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionUI : MonoBehaviour
{
    public GameObject logo;
    public GameObject bjugar;
    public GameObject bopciones;
    public GameObject bcreditos;
    void Start(){
        LeanTween.moveY(logo.GetComponent<RectTransform>(),162,1.5f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.moveX(bjugar.GetComponent<RectTransform>(),0,1.5f).setEase(LeanTweenType.easeInOutBounce);
        LeanTween.moveX(bopciones.GetComponent<RectTransform>(),0,1.5f).setEase(LeanTweenType.easeInOutElastic);
        LeanTween.moveY(bcreditos.GetComponent<RectTransform>(),-99,1.5f).setEase(LeanTweenType.easeInCirc);

    }
}
