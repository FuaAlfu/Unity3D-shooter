using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortGate : MonoBehaviour
{
    [SerializeField]
    Transform port;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject p;

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            StartCoroutine(DepartingTime());
        }
    }

    IEnumerator DepartingTime()
    {
        Hide();
        yield return new WaitForSeconds(1f);
        player.transform.position = port.transform.position;
        Show();
    }

    void Hide()
    {
       // Instantiate(p, port.position, Quaternion.identity);
        player.SetActive(false);
    }

    void Show()
    {
       // Instantiate(p, port.position, Quaternion.identity);
        player.SetActive(true);
    }
}
