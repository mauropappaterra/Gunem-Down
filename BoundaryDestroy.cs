/* Gun'em Down
 * BoundaryDestroy.cs
 * Created by Mauro J. Pappaterra on 07 of July 2017.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryDestroy : MonoBehaviour {

    void OnTriggerExit(Collider other){
        Destroy(other.gameObject);
    }
}   
