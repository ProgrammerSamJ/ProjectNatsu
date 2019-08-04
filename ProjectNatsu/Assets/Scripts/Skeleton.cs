using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skeleton : Enemy
{


    // Start is called before the first frame update
    public Transform target;
    public float chaseRadius;
    public float attackRadius;
    public Transform homePosition;
    private Animator animator;

    void Start()
    {
          animator = GetComponent<Animator>();
          animator.SetBool("Move", false);
          animator.SetBool("Attack", false);
          target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
          CheckDistance();
    }

    void CheckDistance(){
          if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRadius){
                animator.SetBool("Move", true);
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
          }
          else if(Vector3.Distance(target.position, transform.position) <= attackRadius){
                animator.SetBool("Attack", true);
          }
          else{
                animator.SetBool("Move", false);
                animator.SetBool("Attack", false);
          }
    }
}
