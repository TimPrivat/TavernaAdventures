using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestVariables : MonoBehaviour
{

    public bool firstKey = false;
    public bool  secondKey = false;
    public bool mainKey = false;
    public bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mainKey = firstKey && secondKey;
    }
}
