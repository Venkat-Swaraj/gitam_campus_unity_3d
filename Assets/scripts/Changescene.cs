using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{
    // Start is called before the first frame update
    public int x;
    void Start()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
