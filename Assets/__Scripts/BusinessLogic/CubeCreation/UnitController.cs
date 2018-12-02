using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnitManagerDelegate {
    void DidSelect(UnitController unit, GameObject creationArrow);
}

public class UnitController : MonoBehaviour, ISelectableDelegate {
    public IUnitManagerDelegate manager;

    public GameObject representation;
    public GameObject[] creationArrows;

    public void DidSelect(ClickSelectable selectable) {
        if (selectable == representation.GetComponent<ClickSelectable>()) {
            ShowArrows();
        } else {
            GameObject selected = selectable.gameObject;
            if (manager != null) {
                manager.DidSelect(this, selected);
            }
        }
    }

    void Start() {
        representation.GetComponent<ClickSelectable>().selectableDelegate = this;
        foreach (GameObject arrow in creationArrows) {
            arrow.GetComponent<ClickSelectable>().selectableDelegate = this;
        }
    }

    void HideArrows() {
        foreach (GameObject arrow in creationArrows) {
            arrow.SetActive(false);
        }
    }

    void ShowArrows() {
        foreach (GameObject arrow in creationArrows) {
            arrow.SetActive(true);
        }
    }

}
