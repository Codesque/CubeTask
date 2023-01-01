using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameButton : MonoBehaviour
{

    #region Fields

    public bool isHit;

    public const float ThresholdDegree = 20f; 
    public const float DelaySeconds = 1f;
    
    #endregion
    
    
    #region MiscellaneousMethods
    
    
    public void ButtonClicked()
    {

        float absDegree = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x % 90);

        if (absDegree <= ThresholdDegree && !isHit)
        {
            isHit = true;
            StartCoroutine(ResetHit());
            Counter.Instance.IncreaseCounter();
        }
        else if(!isHit) 
        {
            isHit = true;
            StartCoroutine(ResetHit());
        }


    }


    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(DelaySeconds);
        isHit = false; 

    }


    private void Update()
    {
        //Debug.Log( Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x)); 
    }

    #endregion
    
    
    
    
    

}
