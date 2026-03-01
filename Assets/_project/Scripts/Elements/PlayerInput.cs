using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Player _player;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DragStarted();
        }

        if (Input.GetMouseButton(0))
        {
            Dragger();
        }

        if (Input.GetMouseButtonUp(0))
        {
            DragStopped();
        }
    }

    void DragStarted()
    {

    }
    void Dragger()
    {
        var mousePosX = Input.mousePosition.x;
        var mousePosNormalized = mousePosX - Screen.width /2;
        mousePosNormalized = mousePosNormalized * 4 / Screen.width;
        GetComponent<Player>().MovePlayer(mousePosNormalized);
    }
    void DragStopped()
    {

    }
}
