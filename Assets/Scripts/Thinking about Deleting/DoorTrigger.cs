using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObject;
    public bool Action = false;
    

    // Start is called before the first frame update
    void Start()
    {
        Instruction.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "DoorTrigger")
        {
            Instruction.SetActive(true);
            Action = false;
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKey(KeyCode.Mouse0);

       if (down)
        {
            Instruction.SetActive(false);
            AnimeObject.GetComponent<Animator>().Play("Press");
            Action = false;
        }
    }

}
