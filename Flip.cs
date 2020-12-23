using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public TargetFollow target;
    public float posy;
    public float negy;
    private SpriteRenderer _spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target.angle < posy && target.angle > negy)
        {
            _spriteRenderer.flipY = false;
        }
        else
        {
            _spriteRenderer.flipY = true;
        }
    }
}
