using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note_Script : MonoBehaviour
{
    public Animator anim;
    public Sprite[] spriteArray;
    public int noteNumber = 0;

    public int delay = 1;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.Return)))
        {
            anim.SetBool("isDisplaying", false);
            player.GetComponent<Player_Movement>().canMove = true;
        }

        if(anim.GetBool("isDisplaying") == true)
        {
            player.GetComponent<Player_Movement>().canMove = false;
        }
    }

    public void ChangeSprite()
    {
        this.GetComponent<Image>().sprite = spriteArray[noteNumber];
        anim.SetInteger("note", noteNumber + 1);
        noteNumber++;
        Debug.Log("Sprite Changed");
    }
}
