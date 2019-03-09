using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    public float r;
    public float g;
    public float b;
    bool dead = false;
    public float timeToDie = 0;
    SpriteRenderer sRender;
    Collider2D sCollider;
    // Start is called before the first frame update

    void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead At: " + timeToDie);
        sRender.enabled = false;
        sCollider.enabled = false;
    }
    void Start()
    {
        sRender = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRender.color = new Color(r, b, g);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
