using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    public int maxPoints = 2;
    public Image uiPlayer;
    public string PlayerName;


    [Header("Key setap")]

    public KeyCode keyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode keyCodeMoveDown = KeyCode.DownArrow;

    public Rigidbody2D myrigidbody2d;

    [Header("Point")]

    public int currentPoints;
    public TextMeshProUGUI uiTextPoint;
     
    private void Awake()
    {
        ResetPlayer();
    }
    public void SetName(string c)
    {
        PlayerName = c; 
    }
    public void ResetPlayer()
    {
        currentPoints = 0;
        UpdeteUI();
    }

    void Update()
    {
        if(Input.GetKey(keyCodeMoveUp))
            myrigidbody2d.MovePosition(transform.position + transform.up * speed);
            //transform.Translate(transform.up * speed);
        else if(Input.GetKey(keyCodeMoveDown))
            myrigidbody2d.MovePosition(transform.position + transform.up * -speed);
            //transform.Translate(transform.up * speed * -1);
    }
    public void AddPoint()
    {
        currentPoints++;
        UpdeteUI();
        CheckMaxPoints();
        Debug.Log("CurrentPoint");
    }
    public void ChengeColor(Color c)
    {
        uiPlayer.color = c;
    }
    private void UpdeteUI()
    {
        uiTextPoint.text = currentPoints.ToString();
    }
     public void CheckMaxPoints()
    {
        if(currentPoints >= maxPoints)
        {
            GameManager.Instance.EndGame();
            HighScoreBase.Instance.SavePlayerwin(this);
        }
    }
    
}
