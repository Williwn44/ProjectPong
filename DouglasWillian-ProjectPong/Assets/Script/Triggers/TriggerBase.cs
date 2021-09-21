using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBase : MonoBehaviour
{
    public Player player;

    public string KeyToCheck = "Boll";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == KeyToCheck)
        {
            Debug.Log("Bati Na bola");
            ContPoint();
        }
    }
    private void ContPoint()
    {
        StateMachine.Instance.ResetPosition();
        player.AddPoint();
    }
}
