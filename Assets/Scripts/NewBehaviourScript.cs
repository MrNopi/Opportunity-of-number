using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    [SerializeField]
    int level;
    // Use this for initialization
   public void ChangeLevel(int level)
    {
        Application.LoadLevel(level);
    } 
	
	
}
