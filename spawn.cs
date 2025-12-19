using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        Instantiate(prefab, Vector3.zero, Quaternion.identity);
    }
}
