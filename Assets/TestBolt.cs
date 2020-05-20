using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;
using Ludiq;

public class TestBolt : MonoBehaviour
{
    public bool SampleBoltFunction(int _a)
    {
        Debug.Log(_a);
        return true;
    }

    public bool TakeDamage( int _iDamage)
    {
        Debug.Log(_iDamage);
        if( 100 <= _iDamage)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

    public void TestFunc2()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
