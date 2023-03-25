using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnderWater : MonoBehaviour
{
    public double waterLevel;
    private bool isUnderWater;
    public RawImage underWaterEffect;
  

    // Start is called before the first frame update
    void Start()
    {
        underWaterEffect.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.y < waterLevel) != isUnderWater) {
            
            isUnderWater = transform.position.y < waterLevel;
            if (isUnderWater) SetUnderWater();
            if (!isUnderWater) SetNormal();

        }
    }


    void SetNormal() {

        underWaterEffect.enabled = false;

    }

    void SetUnderWater()
    {

        underWaterEffect.enabled= true;
        
        
    }
}
