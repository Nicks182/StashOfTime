

function _Modal_Hide(P_ModalId)
{
    const L_Modal = document.getElementById(P_ModalId);
    if (L_Modal)
    {
        L_Modal.remove();
    }
}