using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectables : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
           
        }
<<<<<<< HEAD

=======
       
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
    }
}
