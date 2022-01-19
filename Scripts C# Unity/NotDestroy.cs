using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotDestroy: MonoBehaviour
{
    // -- Mantendo o mesmo objeto  ao passar de fase ----
    private static NotDestroy instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    // se bugar use essa linha de código no lugar da de cima 

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //        DontDestroyOnLoad(instance);
    //    }
    //    else 
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
