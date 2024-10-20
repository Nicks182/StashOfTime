
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public string G_BusyHolderId = "Div_BusyHolder";
        public ST_HTMLObject _Busy()
        {
            return _Modal(new HasH_Modal_Info
            {
                Id = "Busy_Modal",
                CanCloseOnMask = false,
                IsHidden = true,
                Content = ST_HTMLObject.Create(HasH_Tag.Div).Add_Attribute(HasH_Attribute.Class, "hourglass"),
            });
        }

    }

}
