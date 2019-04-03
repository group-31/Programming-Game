using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorUnlock : MonoBehaviour
{
    public GameObject iController;
    public itemController iC;
    public Sprite locked;
    public Sprite unlocked;
    public BoxCollider2D col;

    // Start is called before the first frame update
    void Start()
    {
        iC = iController.GetComponent<itemController>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(iC.keyOwned == true)
        {
            col.enabled = false;
            this.GetComponent<SpriteRenderer>().sprite = unlocked;
        }
        else
        {
            col.enabled = true;
            this.GetComponent<SpriteRenderer>().sprite = locked;
        }
    }
}
