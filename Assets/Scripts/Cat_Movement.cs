using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Movement : MonoBehaviour
{
    public float speed;
    public float jump;
    private Animator anim;
    private SpriteRenderer sp;
    float moveVelocity;
    bool isGrounded = true;
    float xinicial, yinicial;

    
    // Start is called before the first frame update
    void Start()
    {
        xinicial = transform.position.x;
        yinicial = transform.position.y;
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            if (isGrounded){
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
                isGrounded = false;
            }
        }

        moveVelocity = 0;

        if (Input.GetKey(KeyCode.D)){
            moveVelocity = speed;
            anim.SetFloat("Moving", 1f);
            sp.flipX =  false;
        }
        else if (Input.GetKey(KeyCode.A)){
            moveVelocity = -speed;
            anim.SetFloat("Moving", 1f);
            sp.flipX = true;
        }else {
            anim.SetFloat("Moving", -1f);
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);



    }
    void OnCollisionEnter2D(Collision2D obj){
        if (obj.gameObject.tag == "Stage") {
            Debug.Log("Estoy en suelo");
            isGrounded = true;
        }
    } 
    public void Re(){
        transform.position = new Vector3(xinicial,yinicial,0);
    }

}
