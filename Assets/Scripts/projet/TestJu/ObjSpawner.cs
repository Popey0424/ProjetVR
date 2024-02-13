using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    public GameObject Object;
    bool _isHere = true;
    void Start()
    {
        Instantiate(Object, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find(Object.name) != null)
            _isHere = false;
        else
            _isHere = true;

        if (_isHere == false)
            Instantiate(Object, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}
