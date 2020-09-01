using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpMask : MonoBehaviour
{

    public GameObject enableSpriteMask; //Referencing the spritemask in the inspector

    void Start()
    {
        enableSpriteMask.SetActive(false); //SpriteMask is false at the start of scene
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            enableSpriteMask.SetActive(true); //When player collides with Pick Up Object and activates the sprite mask.
            Destroy(collision.gameObject); //destroys Pick Up object
        }
    }
}
