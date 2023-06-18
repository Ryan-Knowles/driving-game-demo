using UnityEngine;
using UnityEngine.Events;

public class PopupMenu : MonoBehaviour
{
    private UnityAction Okay_Response;
    private UnityAction Cancel_Response;

    // When the 'OK' button is clicked we will call the 'Okay_Response' Action.
    public void OK_UI_Button_Clicked()
    {
        Okay_Response?.Invoke();
        Okay_Response = null;

        Destroy(gameObject);
    }
    // When the 'CANCEL' button is clicked we will call the "Cancel_Response" Action.
    public void Cancel_UI_Button_Clicked()
    {
        Cancel_Response?.Invoke();
        Cancel_Response = null;

        Destroy(gameObject);
    }

    public void SetResponses(UnityAction okay, UnityAction cancel)
    {
        Okay_Response = okay;
        Cancel_Response = cancel;
    }
}