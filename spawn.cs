using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        Instantiate(prefab, transform.position, Quaternion.identity); // will spawn at the object to place this script on
    }
}

