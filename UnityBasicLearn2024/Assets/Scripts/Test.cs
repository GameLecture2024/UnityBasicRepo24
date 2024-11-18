using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string aFreind = "Bill";

        Debug.Log($"내 친구의 이름은 {aFreind}입니다.");
   

        Debug.Log("Hello Unity");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
    }
}
