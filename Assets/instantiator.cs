using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour
{
    public GameObject objectToClone;

    void Start()
    {
        while (3==3)
        {
            Instantiate(objectToClone);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
