using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class treeMechanics : MonoBehaviour
{
    public double health;
    public int wood;
    public GameObject worker;
    private float scaleX= 0.15f;
    private float scaleY = 0.15f;
    private float scaleZ = 0.15f;
    public bool growth = true;
    private float delayTime =1;
    protected float Timer;


    // Start is called before the first frame update
    void Start()
    {
        health = 50;
        wood = 2;
        worker = GameObject.FindGameObjectWithTag("worker");

        transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        transform.localScale = new Vector3 (scaleX, scaleY, scaleZ);
        
        if (Timer >= delayTime) 
        {
            Timer = 0;

            if (growth) 
            {

                scaleX = scaleX + 0.15f;
                scaleY = scaleY + 0.15f;
                scaleZ = scaleZ + 0.15f;

            }


        }


    }
}
