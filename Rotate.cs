/* Gun'em Down
 * Rotate.cs
 * Created by Mauro J. Pappaterra on 10 of July 2017.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour{

    public float tumble;

    void Start(){
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

}
