using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fala2 : MonoBehaviour
{
	public TextScript TS;
	bool dialogue = false;
	bool textSpawn = false;
	int page = 0;
	public PlayerControl PC;
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
					TS.text1.text = "Não me falaram nada sobre uma porta trancada... Como será que devo abri-la?";
					TS.text2.text = "";
					if((Input.GetKeyDown(KeyCode.Space)))
					{
						page++;
					}
					break;
				case 1:
					TS.TextBoxDisappear();
					dialogue = false;
					textSpawn = false;
					TS.text1.text = "";
					TS.text2.text = "";
					page = 0;
					break;
			}
		}
    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag == "Player" && PC.keyGet == false)
		{
			dialogue = true;
		}
	}
}
