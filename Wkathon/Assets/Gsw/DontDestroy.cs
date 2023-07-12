using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public AudioSource musicsource;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(musicsource);
    }
}
