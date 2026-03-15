using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 10f;

    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


}
