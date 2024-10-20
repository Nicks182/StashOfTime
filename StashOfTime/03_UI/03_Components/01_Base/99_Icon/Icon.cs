
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Icon(SH_Components_IconTypes P_SH_Components_IconTypes)
        {
            return _Icon(null, P_SH_Components_IconTypes);
        }

        public ST_HTMLObject _Icon(string? P_Id, SH_Components_IconTypes P_SH_Components_IconTypes)
        {
            ST_HTMLObject L_HTML_Object = ST_HTMLObject.Create(HasH_Tag.Span)
                .Set_InnerText(P_SH_Components_IconTypes.ToString());

            if (string.IsNullOrEmpty(P_Id) == false)
            {
                L_HTML_Object.Add_Attribute("Id", P_Id);
            }


            return L_HTML_Object;
        }
    }

    public enum SH_Components_IconTypes
    {
        None,
        help,
        done,
    }
}
