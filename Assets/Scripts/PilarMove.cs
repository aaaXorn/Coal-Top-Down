using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilarMove : MonoBehaviour
{
	bool interact = true;
	bool move = false;
	bool stopping = false;
	public float timeToStop;
	float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stopping == true)
		{
			currentTime += Time.deltaTime;
		    if(currentTime > timeToStop)
		    {
				move = false;
		    }
		}
    }
	
	private void FixedUpdate()
	{
		if(move==true)
		{
			transform.Translate(0, 0.6f * Time.deltaTime, 0);
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
			float ycollision = collision.gameObject.transform.position.y;
            float y = gameObject.transform.position.y;
			if (y > ycollision)
			{
				move = true;
			}
		}
		if(collision.gameObject.tag == "Water")
		{
			stopping = true;
			interact = false;
			Destroy(collision.gameObject);
		}
	}
}
