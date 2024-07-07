using System.Text;

namespace SOT_HasH.Object
{
    public partial class HTMLObject
    {
        private Dictionary<string, StringBuilder> _Attributes { get; set; } = new Dictionary<string, StringBuilder>();
        public Dictionary<string, StringBuilder> Attributes 
        { 
            get { return _Attributes; }
        }

        /// <summary>
        /// <para>Add HTML attributes like 'class', 'onclick', 'name', ect along with it's value.</para>
        /// <para>If internal List already contains an item with same name, vallue will be appended to internal StringBuilder along with a space to separate values.</para>
        /// </summary>
        public HTMLObject Add_Attribute(string P_Name, string P_Value)
        {
            if(_Attributes.ContainsKey(P_Name) == true)
            {
                _Attributes[P_Name].Append(' ').Append(P_Value);
            }
            else
            {
                _Attributes.Add(P_Name, new StringBuilder (P_Value));
            }

            return this;
        }



    }

}
