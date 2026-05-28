using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector2 diffrence = Vector2.zero;

    private void OnMouseDown()
    {
        diffrence = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2 )transform.position;
    }

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - diffrence;
    }
}
