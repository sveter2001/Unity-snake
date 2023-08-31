using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    
    [SerializeField] public Follow f1;
    [SerializeField] public Follow f2;
    [SerializeField] public TailFollow f3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void plaing()
    {
        f1.enabled = true;
        f2.enabled = true;
        f3.enabled = true;
    }

    public void stop()
    {
        f1.enabled = false;
        f2.enabled = false;
        f3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
