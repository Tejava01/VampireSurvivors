using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    private Vector2 _moveDir = Vector2.zero;
    private float _speed = 5.0f;

    public Vector2 MoveDir { get { return _moveDir; } set { _moveDir = value.normalized; } }

    void Start()
    {
        
    }

    void Update()
    {
        //PrivUpdateInput();
        PrivMovePlayer();
    }

    private void PrivUpdateInput()
    {
        Vector2 moveDir = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            moveDir.y += 1;
        if (Input.GetKey(KeyCode.S))
            moveDir.y -= 1;
        if (Input.GetKey(KeyCode.A))
            moveDir.x -= 1;
        if (Input.GetKey(KeyCode.D))
            moveDir.x += 1;

        _moveDir = moveDir.normalized;
    }

    private void PrivMovePlayer()
    {
        Vector3 dir =_moveDir * _speed *Time.deltaTime;
        transform.position += dir;
    }
}
