
using SOT_State.Object;

namespace SOT_HasH.Component
{
    public partial class Components
    {
        public HasH_Control_Info _FromStateInfo_Control(StateObject_Field P_HasH_StateObject_Control)
        {
            return new HasH_Control_Info
            {
                Id          = P_HasH_StateObject_Control.Id,
                Text        = P_HasH_StateObject_Control.Text,
                Type        = HasH_Component_Types.Textbox,
                GuiId       = P_HasH_StateObject_Control.GuiId,
                IsFocus     = true,
                Caption     = P_HasH_StateObject_Control.Caption,
                IsHidden    = P_HasH_StateObject_Control.IsHidden,
                ValidMsg    = P_HasH_StateObject_Control.ValidMsg,
                IsReadonly  = P_HasH_StateObject_Control.IsReadonly,
                ValidStatus = P_HasH_StateObject_Control.ValidStatus,
            };
        }
    }

    public enum HasH_Component_Types
    {
        Textbox = 0,
        Label = 1,
        Checkbox = 2,
        Button = 3,
        Password = 4,
        Dropdown = 5,
        FolderBrowser = 6,
        Progressbar = 7,
        PlainText = 8,
        GridHeader = 9,
        GridCell = 10,
        Modal = 11,
        Form = 12,
    }

    public ref struct HasH_Control_Info
    {
        public Guid Id { get; set; }
        public string GuiId { get; set; }
        public string Caption { get; set; }
        public string Text { get; set; }
        public bool IsFocus { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsHidden { get; set; }
        public int StyleType { get; set; } // Determine how a component will be shown. Different button styles is one example...
        public int ValidStatus { get; set; }
        public string ValidMsg { get; set; } // Changes the style to indecate validation changes...


        public HasH_Component_Types Type { get; set; }

    }

    
}
