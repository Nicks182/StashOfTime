
using ST_HasH.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public ST_HTMLObject _Screen_Info(Screen_Info P_Screen_Info)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Screen_Info")
            
                .Add_Child(_Screen_Info_Header(P_Screen_Info))
                .Add_Children(_Screen_Info_Items(P_Screen_Info.Items))
                ;
        }

        internal ST_HTMLObject _Screen_Info_Header(Screen_Info P_Screen_Info)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Screen_Info_Header")

                .Set_InnerText(P_Screen_Info.Info);
        }

        internal List<ST_HTMLObject> _Screen_Info_Items(List<Screen_Info_Item> P_Items)
        {
            List<ST_HTMLObject> L_Items = new List<ST_HTMLObject>();
            
            foreach(Screen_Info_Item L_Item in P_Items)
            {
                L_Items.Add(_Screen_Info_Item(L_Item));
            }

            return L_Items;
        }

        internal ST_HTMLObject _Screen_Info_Item(Screen_Info_Item P_Screen_Info_Item)
        {
            return ST_HTMLObject.Create(HasH_Tag.Div)
                .Add_Attribute(HasH_Attribute.Class, "Screen_Info_Item")

                .Add_Child(_Label(new HasH_Control_Info { Value = P_Screen_Info_Item.Name }).Add_Attribute(HasH_Attribute.Class, "Screen_Info_Item_Name"))
                .Add_Child(_Label(new HasH_Control_Info { Value = P_Screen_Info_Item.Description }).Add_Attribute(HasH_Attribute.Class, "Screen_Info_Item_Description"));
        }
    }

    public class Screen_Info
    {
        public string Info { get; set;} 

        public List<Screen_Info_Item> Items { get; set;}
    }

    public class Screen_Info_Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

}
