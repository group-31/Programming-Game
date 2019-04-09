using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showScroll : MonoBehaviour
{
    public GameObject scroll;
    public GameObject targetScrollPosShow;
    public GameObject targetScrollPosHide;
    GameObject showButton;
    GameObject hideButton;

    public float speed = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        showButton = GameObject.Find("Show");
        hideButton = GameObject.Find("Hide");
        hideButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Show()
    {
         while (Vector3.Distance(scroll.transform.position, targetScrollPosShow.transform.position) > 1f)
             scroll.transform.position = Vector3.MoveTowards(scroll.transform.position, targetScrollPosShow.transform.position, Time.deltaTime * speed);

        showButton.SetActive(false);
        hideButton.SetActive(true);
    }

    public void Hide()
    {
        while (Vector3.Distance(scroll.transform.position, targetScrollPosHide.transform.position) > 1f)
            scroll.transform.position = Vector3.MoveTowards(scroll.transform.position, targetScrollPosHide.transform.position, Time.deltaTime * speed);

        showButton.SetActive(true);
        hideButton.SetActive(false);
    }
}
