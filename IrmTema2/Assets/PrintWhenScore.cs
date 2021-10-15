using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintWhenScore : MonoBehaviour
{
    public GameObject BasketBall;
    public GameObject Basket;
    public GameObject PrintScore;


    private float ballDistance = 2f;
    private bool holdingBall = false;
    void Start()
    {
        PrintScore.GetComponent<Text>().text = "";
    }

    void Update()
    {
        if (Vector3.Distance(BasketBall.transform.position, Basket.transform.position) < 0.2f)
        {
            PrintScore.GetComponent<Text>().text = "You scored";
        }

        BasketBall.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 0.0f, 0.0f));
        if (holdingBall)
        {
            BasketBall.transform.position = Basket.transform.position + Basket.transform.forward * ballDistance;

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                BasketBall.GetComponent<Rigidbody>().useGravity = true;

            }
        }
    }
}
