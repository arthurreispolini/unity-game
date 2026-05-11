using UnityEngine;
using UnityEngine.InputSystem;

public class MoverLixeira : MonoBehaviour
{
    public float velocity = 5f;

    void Update()
    {
        float horizontalInput = 0f;

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontalInput = -1f;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontalInput = 1f;
        }

        transform.position += new Vector3(horizontalInput * velocity * Time.deltaTime, 0f, 0f);
    }
}