using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Score scoreManager;
 
    [SerializeField] ParticleSystem particleSystem;
    private void OnCollisionEnter(Collision collision) {
        
        particleSystem.Stop();
        switch(collision.gameObject.tag){
            case "Friendly":
                print("ok");
                break;
            case "Player":
                Debug.Log("Collision Detected");
                scoreManager.AddPoint();
                particleSystem.Play();
                break;
            default:
                print("lala");
                break;
        }

    }

}
