using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class WorkerAI : MonoBehaviour
{
    public GameObject[] trees;
    public float speed = 0.1f;
    public GameObject hut;
    private Vector3 randomTreePos;
    private Vector3 workerPos;
    public GameObject worker;
    
    
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hut = GetComponent<GameObject>();
        findingTree();
        chooseTreeToCut();
       workerPos = worker.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
       
        if (trees.Length == 0)
        {
         findingTree();
        }
        
        transform.position = Vector3.MoveTowards(workerPos, randomTreePos, speed * Time.deltaTime);
        transform.position = randomTreePos;



    }

    //Finding tree to cut
    void findingTree() 
    {
        trees = GameObject.FindGameObjectsWithTag("tree").ToArray<GameObject>();

    }


    //Choose random tree to cut

    void chooseTreeToCut() 
    {
        int index;
        GameObject randomTree;
        index = Random.Range(0, trees.Length);
        randomTree = trees[index];
        randomTreePos = randomTree.transform.position;
    }

}
