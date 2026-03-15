using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float playerOneSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        bool pressingUp = Input.GetKey(KeyCode.UpArrow);
        bool pressingDown = Input.GetKey(KeyCode.DownArrow);

        if (pressingUp)
        {
            transform.Translate(Vector2.up * Time.deltaTime);
        }

        if (pressingDown)
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
    }
}
