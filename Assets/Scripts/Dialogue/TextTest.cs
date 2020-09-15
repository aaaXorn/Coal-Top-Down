using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTest : MonoBehaviour
{
	public TextScript TS;
	bool dialogue = false;
	bool textSpawn = false;
	int page = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogue == true)
		{
			if(textSpawn == false)
			{
				TS.TextBoxAppear();
				textSpawn = true;
			}
			switch (page)
			{
				case 0:
					TS.text1.text = "RULES OF NATURE! And they run when the sun comes up,";
					TS.text2.text = "with their lives on the line. ALIIIIIIIVE! For a whiiile!";
					if((Input.GetKeyDown(KeyCode.Space)))
					{
						page++;
					}
					break;
				case 1:
					TS.text1.text = "NO CHOOOOOICE!";
					TS.text2.text = "GOTTA FOLLOW THE LAWS OF THE WIIIILD!";
					if((Input.GetKeyDown(KeyCode.Space)))
					{
						page++;
					}
					break;
				case 2:
					TS.TextBoxDisappear();
					dialogue = false;
					textSpawn = false;
					TS.text1.text = "";
					TS.text2.text = "";
					page = 0;
					Destroy(gameObject);
					break;
			}
		}
    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")
		{
			dialogue = true;
		}
	}
}
