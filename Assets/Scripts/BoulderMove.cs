using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderMove : MonoBehaviour
{
	bool interact = true;
	bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void FixedUpdate()
	{
		if(move==true)
		{
			transform.Translate(1 * Time.deltaTime, 0, 0);
		}
		else
		{
			transform.Translate(0, 0, 0);
		}
	}
	
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" && interact == true)
		{
			float xcollision = collision.gameObject.transform.position.x;
            float x = gameObject.transform.position.x;
			if (x > xcollision)
			{
				move = true;
			}
		}
		else if(collision.gameObject.tag == "BoulderCheck")
		{
			interact = false;
			move = false;
		}
	}
}
