using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayHello : MonoBehaviour
{
    [SerializeField]
    GameObject texto;

    void Start()
    {
        StartCoroutine(SayHi());
    }
    void Update()
    {

    }
    IEnumerator SayHi()
    {
        texto.SetActive(false);
        yield return new WaitForSeconds(2);
        texto.SetActive(true);
    }
}
