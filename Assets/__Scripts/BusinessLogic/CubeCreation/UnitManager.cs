using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour, IUnitManagerDelegate {
    public GameObject UnitPrefab;
    public GameObject SculptureAnchor;

    public ArrayList units;

    public void DidSelect(UnitController unit, GameObject creationArrow) {
        Vector3 distance = (unit.representation.transform.position - creationArrow.transform.position) * 2;
        Vector3 newUnitPosition = unit.transform.position - distance;
        Debug.Log("Unit position:" + unit.transform.position + "\nNew unit position:" + newUnitPosition);
        Debug.Log(distance);
        CreateUnit(newUnitPosition);
    }

    // Use this for initialization
    void Start () {
        units = new ArrayList();
        CreateUnit(Vector3.zero);
	}
	
	
    void CreateUnit(Vector3 position) {
        GameObject newUnit = Instantiate(UnitPrefab, SculptureAnchor.transform, true);
        newUnit.transform.position = position;
        newUnit.SetActive(true);
        newUnit.GetComponent<UnitController>().manager = this;
        units.Add(newUnit);
    }

}
