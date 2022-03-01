using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
// class for specific pool objects
public class PoolObject {
  public GameObject poolObj;
  public int capacity;
  // will handle if we need to increase pool
  public bool increasePool;
}
// main class to handle object pool
public class ObjectPool : MonoBehaviour {
    // so we can access in other methods
	public static ObjectPool Instance;
    public List<PoolObject> thingsForPool;
    private List<GameObject> objectsInPool;

	void Awake() {
		Instance = this;
	}

    // will create object pool 
    void Start () {
        objectsInPool = new List<GameObject>();
        foreach(PoolObject item in thingsForPool){
            for(int i = 0; i < item.capacity; i++){
                GameObject obj = (GameObject)Instantiate(item.poolObj);
                obj.SetActive(false);
                objectsInPool.Add(obj);
            }
        }
    }
	
    public GameObject GetObjectFromPool(string tag){
        // goes through objects in pool to get game object
        for(int i = 0; i < objectsInPool.Count; i++){
            // if the object is not active and tag matches it returns object
            if(!objectsInPool[i].activeInHierarchy && objectsInPool[i].tag == tag) {
                return objectsInPool[i]; // return object from pool
            }
        }
        // now will go through to see if pool needs to increase
        // used for bullets
        foreach(PoolObject item in thingsForPool) {
            if(item.poolObj.tag == tag){
                if(item.increasePool){
                    increaseAddToPool(item.poolObj);
                }
            }
        }
        // returns null if not in pool
        return null;
    }

    // to handle adding new objects to pool if needed to expand
    private GameObject increaseAddToPool(GameObject obj){
        GameObject o = (GameObject)Instantiate(obj); 
        o.SetActive(false);
        objectsInPool.Add(o);
        return o;
    }
}

