using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager Manager; 
    
    void OnTriggerEnter()
    {
        Manager.levelComplete();
    }
}
