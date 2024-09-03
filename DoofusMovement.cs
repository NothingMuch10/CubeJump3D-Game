using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoofusMovement : MonoBehaviour
{
    public float speed = 5f;
    public ScoreManager scoreManager;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        if (HasFallenOff())
        {
            scoreManager.EndGame();
        }
    }
    bool HasFallenOff()
    {
        return transform.position.y < -1;
    }
}
