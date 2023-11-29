using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
<<<<<<< HEAD
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
=======
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        
        if(controller !=null )
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
        {
            controller.ChangeHealth(-1);
        }
    }
}
