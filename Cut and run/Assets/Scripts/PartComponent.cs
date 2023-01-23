using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartComponent : MonoBehaviour
{
    [SerializeField] private BoxCollider2D partBoxCollider;

    public float GetPartWight()
    {
        return partBoxCollider.size.x * transform.localScale.x;    
    }
}
