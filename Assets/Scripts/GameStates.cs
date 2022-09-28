using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    public GameObject note;
    public Collider2D dumpCollider;
    public GameObject endTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (gameObject.name == "ice_cream_box")
        {
            Debug.Log("Note1 Triggered");
            note.GetComponent<Note_Script>().anim.SetBool("isDisplaying", true);
            DoDelayAction(3);
            //note.GetComponent<Note_Script>().anim.SetInteger("note", 1);
            gameObject.SetActive(false);
        }

        if (gameObject.name == "rubber_duck")
        {
            Debug.Log("Note2 Triggered");
            note.GetComponent<Note_Script>().anim.SetBool("isDisplaying", true);
            DoDelayAction(3);
            //note.GetComponent<Note_Script>().anim.SetInteger("note", 3);
            gameObject.SetActive(false);
        }

        if (gameObject.name == "dumpster_cake")
        {
            Debug.Log("Note3 Triggered");
            note.GetComponent<Note_Script>().anim.SetBool("isDisplaying", true);
            DoDelayAction(3);
            dumpCollider.GetComponent<BoxCollider2D>().isTrigger = false ;
            //note.GetComponent<Note_Script>().anim.SetInteger("note", 3);
            endTrigger.SetActive(true);
        }
    }

    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
    }

}
