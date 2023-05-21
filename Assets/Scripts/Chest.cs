using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Sprite chestOpen;
    public SpriteRenderer letterE;
    SpriteRenderer spriteRenderer;
    bool keyPress = false;
    bool chestOpenBool = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        letterE.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        keyPress = Input.GetKey(KeyCode.E);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision != null && !chestOpenBool)
        {
            letterE.enabled = true;

            if (collision.gameObject.tag == "Player" && keyPress)
            {
                chestOpenBool = true;
                spriteRenderer.sprite = chestOpen;
                letterE.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null)
        {
            letterE.enabled = false;
        }
    }
}
