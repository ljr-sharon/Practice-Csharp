using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private static volatile EnemyManager _instance;
    private static readonly Lazy<EnemyManager> _lazyInstance
        = new Lazy<EnemyManager>(() => new EnemyManager(), isThreadSafe: true);
    public static EnemyManager Instance => _lazyInstance.Value;
    [SerializeField] LevelType type;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
