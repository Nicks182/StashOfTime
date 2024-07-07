
using SOT_HasH.Object;

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public HTMLObject _Home()
        {
            var L_HTML_Object = HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Id, "")
                .Add_Attribute(HasH_Attribute.Class, "Home")
                ;

            L_HTML_Object.Add_Child(_Label(new HasH_Control_Info
            {
                Text = "This is HOME!!"
            }));

            return L_HTML_Object;
        }
    }
}
