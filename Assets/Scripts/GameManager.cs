using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject hand;
    [SerializeField]
    Image fill;
    [SerializeField]
    Text cLevelText, nLevelText;
    [SerializeField]
    GameObject player, finish;
    [SerializeField]
    TextMesh levelNo;

    int level;
    float startDistance, distance;

    void Start()
    {
        startDistance = Vector3.Distance(player.transform.position, finish.transform.position);
    }

    private void Update()
    {
        distance = Vector3.Distance(player.transform.position, finish.transform.position);

        if (player.transform.position.x < finish.transform.position.x)
        {
            fill.fillAmount = 1 - (distance / startDistance);
        }
    }

    public void RemoveUI()
    {
        hand.SetActive(false);
    }
}
