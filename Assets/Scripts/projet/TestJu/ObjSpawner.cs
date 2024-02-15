using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    public GameObject Object;

    bool _isHere = true;
    GameObject _toy;
    ObjectBehavior _behavior;
    void Start()
    {
        _behavior = FindAnyObjectByType <ObjectBehavior>();
        _toy = Instantiate(Object, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        _behavior.IsHere = true; //ok je comprends pas pourquoi ça met un erreur alors que ça fonctionne ???
    }

    // Update is called once per frame
    void Update()
    {
        if (_behavior.IsHere == false) //idem ici ://
        {
            Debug.Log("AAAAAH");
           _toy = Instantiate(Object, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            
        }
    }
}
