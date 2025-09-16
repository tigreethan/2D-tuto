using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHealth : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
       PlayerController controller = other.GetComponent<PlayerController>();
        //Debug.Log("Object that entered the trigger: " + other);

    if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
 
    
