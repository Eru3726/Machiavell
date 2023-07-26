using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColCheck : MonoBehaviour
{
    public UnityEvent OnHit;

    void OnTriggerEnter2D(Collider2D collision)
    {
        OnHit.Invoke();
    }
}
