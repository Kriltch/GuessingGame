using UnityEngine;
using System.Collections;

public class DAT : MonoBehaviour {//Destroy After Two

    void Start()
    {
        StartCoroutine(DestroyThis());
    }
    public IEnumerator DestroyThis()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);

    }
}
