using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HauntedScript : MonoBehaviour
{
    //this will go on Clair for Kitchen Scene
    //as she moves, the environment's local scale gets bigger

    public Transform environment;
    private Vector3 environmentScale;
    
    // Start is called before the first frame update
    void Start()
    {
        //environmentScale = new Vector3(environment.transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("EnviroGrow", 5f, 10f);
    }

    public void EnviroGrow()
    {
        environment.localScale += new Vector3(0.0003f, 0.0003f, 0.0003f);
    }
}
