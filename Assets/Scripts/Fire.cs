using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
	bool open = false;
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
					TS.text1.text = "Aqui está a chama. Agora é só levar a chama até a fonte e finalmente estarei livre dessa missão...";
					TS.text2.text = "e desse cheiro.";
					if((Input.GetKeyDown(KeyCode.Space)))
					{
						page++;
					}
					break;
				case 1:
					TS.TextBoxDisappear();
					open = true;
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
		if(open==false)
		{
			if(collision.gameObject.tag == "Player")
			{
				PC.fireGet = true;
				dialogue = true;
			}
		}
	}
}
