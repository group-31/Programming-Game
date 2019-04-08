using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject gameOver;
    public Sprite assassin, assassinBehind, assassinLeftSide, assassinRightSide;
    [SerializeField] GameObject player;
    [SerializeField] Collider2D wall;
    public GameObject manager;
    public int enemyFace;
    [SerializeField] int[] enemyPath = new int[8];
    public int moveCounter = 0;
    public gameManager gM;
    public bool touchWall;



    // Start is called before the first frame update
    void Start()
    {
        
        enemyFace = 0;
        manager = GameObject.Find("Game Manager");
        gM = manager.GetComponent<gameManager>();
        touchWall = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<Collider2D>().IsTouching(wall))
        {

            touchWall = true;
        }
        else
        {
            touchWall = false;
        }
    }

    public void changeEnemyLook(float n)
    {
        this.GetComponent<SpriteRenderer>().sprite = assassin;
        int z = Mathf.RoundToInt(n);
        if (z == 3)
        {

            this.GetComponent<SpriteRenderer>().sprite = assassinLeftSide;

        }
        if (z == 1)
        {

            this.GetComponent<SpriteRenderer>().sprite = assassinRightSide;

        }
        if (z == 0)
        {

            this.GetComponent<SpriteRenderer>().sprite = assassinBehind;


        }
        if (z == 2)
        {

            this.GetComponent<SpriteRenderer>().sprite = assassin;

        }
    }

    public void enemyMove()
    {



        if (moveCounter == 8)
        {
            moveCounter = 0;
        }

        Debug.Log(enemyPath[moveCounter]);

        if (enemyPath[moveCounter] == 0)
        {
            this.GetComponent<BoxCollider2D>().size = new Vector2(0.1f, 1.5f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, 2f);

            enemyFace = 0;
        }

        else if (enemyPath[moveCounter] == 90)
        {
            this.GetComponent<BoxCollider2D>().size = new Vector2(1.5f, 0.1f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(2, 0);
            enemyFace = 1;
        }

        else if (enemyPath[moveCounter] == 180)
        {
            this.GetComponent<BoxCollider2D>().size = new Vector2(0.1f, 1.5f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -2f);
            enemyFace = 2;
        }

        else if (enemyPath[moveCounter] == 270)
        {
            this.GetComponent<BoxCollider2D>().size = new Vector2(1.5f, 0.1f);
            this.GetComponent<BoxCollider2D>().offset = new Vector2(-2, 0);
            enemyFace = 3;
        }

        else if (enemyPath[moveCounter] == 1 && enemyFace == 0)
        {
            this.transform.position += transform.up;
        }
        else if (enemyPath[moveCounter] == 1 && enemyFace == 1)
        {
            this.transform.position += transform.right;
        }
        else if (enemyPath[moveCounter] == 1 && enemyFace == 2)
        {
            this.transform.position -= transform.up;
        }
        else if (enemyPath[moveCounter] == 1 && enemyFace == 3)
        {
            this.transform.position -= transform.right;
        }

        changeEnemyLook(enemyFace);
        StartCoroutine("waitCheck");


        moveCounter++;
    }

    IEnumerator waitCheck()
    {
        yield return new WaitForSeconds(0.1f);

        checkAssassin();
    }

    public void checkAssassin()
    {





        if (enemyFace == 0)
        {




            if (player.transform.position.y - this.transform.position.y > 0 && (player.transform.position.y - this.transform.position.y) < 2.5 && (player.transform.position.x) - (this.transform.position.x) < 0.1 && (player.transform.position.x) - (this.transform.position.x) > -0.1 && touchWall == false)
            {

                Debug.Log("dead");
                gameOver.SetActive(true);

            }
        }

        if (enemyFace == 1)
        {
            if ((player.transform.position.x - this.transform.position.x) > 0 && (player.transform.position.x - this.transform.position.x) < 2.5 && (player.transform.position.y) - (this.transform.position.y) < 0.1 && (player.transform.position.y) - (this.transform.position.y) > -0.1 && touchWall == false)
            {

                Debug.Log("dead");
                gameOver.SetActive(true);

            }
        }

        if (enemyFace == 2)
        {
            if ((this.transform.position.y - player.transform.position.y) > 0 && (this.transform.position.y - player.transform.position.y) < 2.5 && (player.transform.position.x) - (this.transform.position.x) < 0.1 && (player.transform.position.x) - (this.transform.position.x) > -0.1 && touchWall == false)
            {

                Debug.Log("dead");
                gameOver.SetActive(true);

            }
        }

        if (enemyFace == 3)
        {
            if ((this.transform.position.x - player.transform.position.x) > 0 && (this.transform.position.x - player.transform.position.x) < 2.5 && (player.transform.position.y) - (this.transform.position.y) < 0.1 && (player.transform.position.y) - (this.transform.position.y) > -0.1 && touchWall == false)
            {

                Debug.Log("dead");
                gameOver.SetActive(true);

            }
        }



    }




}
