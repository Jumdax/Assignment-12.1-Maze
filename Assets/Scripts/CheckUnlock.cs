using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock : MonoBehaviour
{

    public GameObject door = null;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            // Unlock it!
            if(door.activeInHierarchy)
                door.SetActive(false);
        }
    }
}
