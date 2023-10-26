using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton4 : MonoBehaviour
{
    private Animator anim;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Button Press4");
            anim.SetTrigger("Press4");
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
        
    }
}
