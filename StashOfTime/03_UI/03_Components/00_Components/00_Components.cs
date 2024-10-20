
using ST_HasH.Object;
using ST_StateManager;
using ST_StateManager.Object;

namespace ST_UI.Component
{
    public partial class Components
    {
        public HasH_Control_Info _From_StateInfo_To_Field(Guid P_StateId, ST_StateObject_Field P_ST_StateObject_Field)
        {
            HasH_Control_Info L_HasH_Control_Info = new HasH_Control_Info
            {
                Id = P_ST_StateObject_Field.Id,
                Value = P_ST_StateObject_Field.Text,
                StateId = P_StateId,
                Type = P_ST_StateObject_Field.Type,
                GuiId = P_ST_StateObject_Field.GuiId,
                IsFocus = true,
                Caption = P_ST_StateObject_Field.Caption,
                IsHidden = P_ST_StateObject_Field.IsHidden,
                ValidMsg = P_ST_StateObject_Field.ValidMsg,
                IsReadonly = P_ST_StateObject_Field.IsReadonly,
                ValidStatus = P_ST_StateObject_Field.ValidStatus,
            };

            L_HasH_Control_Info = _Set_Field_EventHandler(L_HasH_Control_Info);

            return L_HasH_Control_Info;
        }

        private HasH_Control_Info _Set_Field_EventHandler(HasH_Control_Info P_HasH_Control_Info)
        {
            switch (P_HasH_Control_Info.Type)
            {
                case ST_Object_Type.Checkbox:
                    //P_HasH_Control_Info.EventHandler = _Checkbox_Changed_Event(P_HasH_Control_Info);
                    break;

            }

            return P_HasH_Control_Info;
        }
    }

    public struct HasH_Modal_Info
    {
        public string Id { get; set; }
        public string Caption { get; set; }
        public bool NoMask { get; set; }
        public bool IsHidden { get; set; }
        public bool HasCloseBtn { get; set; }
        public bool CanCloseOnMask { get; set; }
        public bool RemoveOnClose { get; set; }
        public ST_HTMLObject Content { get; set; }
    }

    public struct HasH_Control_Info
    {
        public Guid Id { get; set; }
        public Guid StateId { get; set; }
        public string GuiId { get; set; }
        public string Caption { get; set; }
        public string Value { get; set; }
        public bool IsFocus { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsHidden { get; set; }
        public int StyleType { get; set; } // Determine how a component will be shown. Different button styles is one example...
        public int ValidStatus { get; set; }
        public string ValidMsg { get; set; } // Changes the style to indecate validation changes...

        public HasH_Control_Info_EventHandler EventHandler { get; set; }


        public ST_Object_Type Type { get; set; }

    }

    public struct HasH_Control_Info_EventHandler
    {
        public string EventName { get; set; }
        public string Handler { get; set; }
    }
}
