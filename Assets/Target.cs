using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Target : MonoBehaviour
{
    public Score scoreManager;
    
    
     private void OnCollisionEnter(Collision collision) {
        switch(collision.gameObject.tag){
            case "Friendly":
                print("friendly detected");
                break;
            case "Player":                
                Debug.Log("Collision Detected");
                scoreManager.AddPoint();
                Destroy(gameObject);
                break;
            default:
                print("lala");
                break;
    }

    }



}

    
