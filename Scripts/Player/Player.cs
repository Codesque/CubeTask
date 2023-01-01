using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player Instance;
    public static int RotationSpeed_x = 20;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed_x * Time.deltaTime , 0 , 0);
    }
}
