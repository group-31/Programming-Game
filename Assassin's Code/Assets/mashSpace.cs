using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mashSpace : MonoBehaviour
{
    public Sprite bar;
    public Sprite barPressed;
    public GameObject run;
    public run r;

    public void Start()
    {
        r = run.GetComponent<run>();
        this.gameObject.SetActive(false);
    }

    public void MashSpace()
    {
        StartCoroutine(Mash());
    }

    public IEnumerator Mash()
    {
        while (r.running == true)
        {
            while (!Input.GetKeyDown(KeyCode.Space)) yield return null;
            this.GetComponent<SpriteRenderer>().sprite = barPressed;
            while (!Input.GetKeyUp(KeyCode.Space)) yield return null;
            this.GetComponent<SpriteRenderer>().sprite = bar;
        }
        this.gameObject.SetActive(false);
    }
}
