using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInAllScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindWithTag("ButtonMenu")!=gameObject)
        {
            Destroy(gameObject);    
        }

        
        
        DontDestroyOnLoad(gameObject);
    }

}
