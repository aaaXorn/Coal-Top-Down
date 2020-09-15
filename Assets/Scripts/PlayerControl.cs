using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator anim;
    SpriteRenderer render;
    Rigidbody2D rigid;
    float inputX;
    float inputY;
    public float speedX;
    public float speedY;
	public bool keyGet = false;
	public bool fireGet = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
        anim.SetFloat("MoveX", Mathf.Abs(inputX));
        anim.SetFloat("MoveY", Mathf.Abs(inputY));
        if (inputY < 0)
        {
            anim.SetBool("MoveDown", true);
        }
        else if (inputY > 0)
        {
            anim.SetBool("MoveDown", false);
        }
        if (inputX < 0)
        {
            render.flipX = true;
        }
        else if (inputX > 0)
        {
            render.flipX = false;
        }

        if(inputX != 0 && inputY == 0  || inputX == 0 && inputY != 0)
        {
            rigid.velocity = new Vector2(inputX * speedX, inputY * speedY);
        }
        else if (inputX != 0 && inputY != 0)//para o movimento diagonal ter velocidade similar ao somente em X ou em Y
        {
            rigid.velocity = new Vector2(inputX * speedX * 0.7f, inputY * speedY * 0.7f);
        }
		else if (inputX == 0 && inputY == 0)
		{
			rigid.velocity = new Vector2(0, 0);
		}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Teleport")//mudança de level
        {
            transform.position = new Vector2(-6, -2);
        }
		if(collision.gameObject.tag == "Teleport1>2")
		{
			transform.position = new Vector2(37, -26.5f);
		}
		if(collision.gameObject.tag == "Teleport2>1")
		{
			transform.position = new Vector2(-10, -45.5f);
		}
		if(collision.gameObject.tag == "Teleport2>3")
		{
			transform.position = new Vector2(-6, -22.5f);
		}
		if(collision.gameObject.tag == "Teleport3>2")
		{
			transform.position = new Vector2(33, -12);
		}
		if(collision.gameObject.tag == "Teleport2>i1" && keyGet == true)
		{
			transform.position = new Vector2(89, -17.6f);
		}
		if(collision.gameObject.tag == "Teleporti1>2")
		{
			transform.position = new Vector2(51.8f, -11);
		}
		if(collision.gameObject.tag == "Teleporti1>i2")
		{
			transform.position = new Vector2(32.4f, -63);
		}
		if(collision.gameObject.tag == "Teleporti2>i1")
		{
			transform.position = new Vector2(84, -6.3f);
		}
		if(collision.gameObject.tag == "Teleporti1>i3")
		{
			transform.position = new Vector2(66, -59.5f);
		}
		if(collision.gameObject.tag == "Teleporti3>i1")
		{
			transform.position = new Vector2(94.5f, -6.3f);
		}
    }
}
