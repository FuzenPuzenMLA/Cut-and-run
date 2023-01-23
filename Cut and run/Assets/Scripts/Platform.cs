using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float maxLength;
    [SerializeField] private Vector3 startPosition;
    private Vector3 partPosition;
    [SerializeField] private GameObject part;
    [SerializeField] private PartComponent partComponent;
    private float partLength;
    private List<GameObject> partList = new List<GameObject>();
 
    private void Start()
    {
       partLength = partComponent.GetPartWight();
       startPosition -= new Vector3(partLength / 2, 0, 0);
       Spawn();
    }

    public void Spawn()
    {
        partPosition = startPosition;
        while(partList.Count * partLength < maxLength)
        {
            partList.Add(Instantiate(part, partPosition, Quaternion.identity));
            partPosition += new Vector3(partLength, 0, 0);
        }

    }
    
}
