using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    public float jump = 1;
    public float fall = 1;
    private Rigidbody2D rb;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;
        if(move==0)
        {
            anim.SetBool("walk", false);
        }else
        {
            anim.SetBool("walk", true);
        }
        if(!Mathf.Approximately(0,move))
        {
            transform.rotation = move < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        if(Input.GetButtonDown("Jump")&&Mathf.Abs(rb.velocity.y)<0.01f)
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            anim.SetBool("onGround", false);
        }
        if ( Mathf.Abs(rb.velocity.y) < fall)
        {
            anim.SetBool("onGround", true);
        }
    }
}
