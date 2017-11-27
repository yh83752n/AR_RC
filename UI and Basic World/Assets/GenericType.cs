using UnityEngine;
using System.Collections;

public class GenericType<T> : MonoBehaviour
{
	GameObject prefab;
	public void someFn(){
		Instantiate (prefab, new Vector3 (0, 0, 0), Quaternion.identity);
	}
}

