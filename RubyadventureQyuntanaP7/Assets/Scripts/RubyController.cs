using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class RubyController: MonoBehaviour
{
    public float speed = 3.0f;

    public int maxHealth = 5;
    public float timeInvincible = 2.0f;
    public int health { get { return currentHealth; } }
=======
public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;
   public int health { get { return currentHealth; } }
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
    int currentHealth;

    bool isInvincible;
    float invincibleTimer;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2 (horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        animator.SetFloat(" look X", lookDirection.x);
        animator.SetFloat("look Y", lookDirection.y);
        animator.SetFloat("speed", move.magnitude);

        if(isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if(invincibleTimer < 0)
            {
                isInvincible = false;
            }
        }

    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
<<<<<<< HEAD

        rigidbody2d.MovePosition(position);
    }
    public void ChangeHealth(int amount)
=======
 
        rigidbody2d.MovePosition(position);
    }
   public void ChangeHealth(int amount)
>>>>>>> 63bd88aabf7fe24bce6a4b77fec97b9caf01cae2
    {
        if(amount < 0)
        {
            animator.SetTrigger("Hit");

            if(isInvincible)
            {
                return;
            }
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
