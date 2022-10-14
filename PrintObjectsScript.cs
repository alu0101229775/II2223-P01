/**
 * Print in console the Game Object's name and tag
 * 
 * @date 14/10/2022
 * @author Gerard Antony Caramazza Vilá
 * @email alu0101229775@ull.edu.es 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrintObjectsScript : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    Debug.Log("Game Object: " + name + "\nTag: " + tag);
    // Another way to do it:
    // GameObject go = GameObject.FindWithTag(tag);
    // Debug.Log("Game Object: " + go.name + "\nTag: " + tag);
  }

  // Update is called once per frame
  void Update() {
    
  }
}
