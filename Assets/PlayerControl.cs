using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl: MonoBehaviour
{
    public float moveSpeed = 3.0f;
    Transform tr;
    // Start is called before the first frame update
    private static PlayerControl instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
    }

}
