using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
	Animator anim;
	bool open = false;
	public TextScript TS;
	bool dialogue = false;
	bool textSpawn = false;
	int page = 0;
	public PlayerControl PC;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
					TS.text1.text = "Aqui está a chave. Agora posso passar por aquela porta.";
					TS.text2.text = "";
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
				PC.keyGet = true;
				dialogue = true;
				anim.SetBool("chestOpen", true);
			}
		}
	}
}
