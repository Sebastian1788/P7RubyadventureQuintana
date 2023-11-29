using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
<<<<<<< HEAD
    public bool vertical;
    public float changeTime = 3.0f;

=======
    public bool verticle;
    public float changeTime;
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2

    Rigidbody2D rigidbody2d;

    float timer;
    int direction = 1;

    Animator animator;
<<<<<<< HEAD



=======
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
<<<<<<< HEAD
       animator = GetComponent<Animator>();
        
=======

>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
<<<<<<< HEAD
        }
    }
    private void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if(vertical)
=======
            animator = GetComponent<Animator>();

        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if (verticle)
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
        {
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            animator.SetFloat("Move X", direction);
<<<<<<< HEAD
            animator.SetFloat("Move Y", 0);
            position.x = position.x + Time.deltaTime * speed * direction;
        }

=======
            animator.SetFloat("move Y", 0);
            position.x = position.x + Time.deltaTime * speed * direction;
        }


>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
        rigidbody2d.MovePosition(position);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController>();
<<<<<<< HEAD
        if (player != null)
        {
            player.ChangeHealth(-1);
        }
=======
        if (player !=null)
        {
            player.ChangeHealth(-1);
        }
        
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
    }
}
