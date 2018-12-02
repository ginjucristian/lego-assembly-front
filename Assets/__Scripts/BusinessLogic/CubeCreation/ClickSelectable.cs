using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ISelectableDelegate {
    void DidSelect(ClickSelectable selectable);
}

public class ClickSelectable : MonoBehaviour {
    public ISelectableDelegate selectableDelegate;
	
    public void select() {
        if (selectableDelegate != null) {
            selectableDelegate.DidSelect(this);
        }
    }
}
