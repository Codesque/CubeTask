using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{

    #region Fields

    public int points = 0;
    public static Counter Instance;
    
    [SerializeField]
    public TMP_Text counterTxt;
    
    #endregion
    
    
    
    public void Awake()
    {
        Instance = this;
    }

    public void IncreaseCounter()
    {
        points++;
        counterTxt.text = points.ToString();
    }
}
