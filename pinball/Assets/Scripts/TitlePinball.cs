using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitlePinball : MonoBehaviour
{
    public float glowSpeed = 1f;
    private TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.fontSharedMaterial.EnableKeyword("GLOW_ON");
        text.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowPower,0f);
        text.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowOffset,1f);
        text.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowOuter,1f);
        text.fontSharedMaterial.SetFloat("_GlowInner",0.4f);
        StartCoroutine(MakeGlow(glowSpeed));
    }

    IEnumerator MakeGlow(float speedSeconds){

        bool increase = true;
        float valueAdd = Time.deltaTime * speedSeconds;
        float currentValue = 0f;
        while(true){
            if(increase){
                currentValue += valueAdd;
            }else{
                currentValue -= valueAdd;
            }
            if(currentValue >= 1f){
                increase = false;
                currentValue = 1f;

            }else if(currentValue <= 0f){
                increase = true;
                currentValue = 0f;
            }
            text.fontSharedMaterial.SetFloat(ShaderUtilities.ID_GlowPower,currentValue);
            yield return null;
        }
    }
}
