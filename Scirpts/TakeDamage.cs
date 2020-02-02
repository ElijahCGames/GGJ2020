using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour
{

    public MoveAndShoot movement; 

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Damage")
        {
            movement.healthBar.GetComponent<Slider>().value -= 1; 
        }
        
    }
}
