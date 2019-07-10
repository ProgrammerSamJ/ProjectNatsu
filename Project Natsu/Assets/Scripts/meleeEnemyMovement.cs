using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meleeEnemyMovement : MonoBehaviour
{
    public float speed;
    public float startHaelth = 10;
    private float currHealth;

    public Image healthBar;

    Rigidbody2D rigidBody;
    Vector2 change;
    Animator animator;

    //facing
    public GameObject enemyGraphic;

    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
        currHealth = startHaelth;
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");
        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector2.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void MoveCharacter()
    {
        rigidBody.MovePosition(rigidBody.position + change * speed * Time.deltaTime);
    }
}
