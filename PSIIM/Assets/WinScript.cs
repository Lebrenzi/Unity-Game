using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public string nextLevel;
    private Controls player;
    public SpriteRenderer m_SpriteRenderer;
    public Sprite closed;
    public Sprite opened;
    
    bool win;
    void Start()
    {
        player = FindObjectOfType<Controls>();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.sprite = closed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (player.crystals == 4)
        {
            
            SceneManager.LoadScene(nextLevel);
        }
    }
    void Update()
    {
        if(player.crystals == 4)
        {
            m_SpriteRenderer.sprite = opened;
        }
    }
}
