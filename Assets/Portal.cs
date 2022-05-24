using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string sceneName;
    public float x = 0.0f;
    public float y = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                SceneManager.LoadScene(sceneName);
                coll.transform.position = new Vector3(x, y, 0);
            }
        }
    }
}
