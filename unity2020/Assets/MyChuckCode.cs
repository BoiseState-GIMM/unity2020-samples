using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChuckCode : MonoBehaviour
{
	void Start()
	{
		GetComponent<ChuckSubInstance>().RunCode(@"
		SinOsc foo => dac;
		while( true )
		{
			Math.random2f( 300, 1000 ) => foo.freq;
			100::ms => now;
		}
	");
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
