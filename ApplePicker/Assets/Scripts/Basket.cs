/*
 * Created by: Ben Jenkins
 * Date created: 2/7/2022
 * Last Edited by: NA
 * Last edited: NA
 * Description: Basket control and apple collection
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;


    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score Counter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //get the current screen position of the mouse from input
        Vector3 mousePos2D = Input.mousePosition; //1

        //camer z position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z; //2

        //convert the point from 2D screen space to 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D); //3

        //move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;

    }
    private void OnCollisionEnter(Collision coll)
    {
        //Find what hit the basket
        GameObject collidedwith = coll.gameObject;
        if (collidedwith.tag == "Apple")
        {
            Destroy(collidedwith);
            
            int score = int.Parse(scoreGT.text);
            score += 100;
            scoreGT.text = score.ToString();

            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
}
