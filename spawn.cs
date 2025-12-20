using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject prefab;
    public bool ThanksMessage = true
    
    void Start()
    {
        Instantiate(prefab, transform.position, Quaternion.identity); // will spawn at the object to place this script on

        if(ThanksMessage)
        {
            Debug.Log("Hey thanks for using my simple script, you can turn this message off in the script settings. No credits are needed");
        }
        
    }
}


