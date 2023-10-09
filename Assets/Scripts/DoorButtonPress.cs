using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtonPress : MonoBehaviour
{
    private Animator anim;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Button Press1");
            anim.SetTrigger("Press");
        }

        if (other.CompareTag("Player"))
        {
            Debug.Log("Button Press2");
            anim.SetTrigger("Press");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        bool down = Input.GetKey(KeyCode.E);

        if (down)
        {
            anim.SetTrigger("Press");
        }*/
    }
        
}
