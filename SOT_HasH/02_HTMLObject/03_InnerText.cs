
namespace SOT_HasH.Object
{
    public partial class HTMLObject
    {
        private string _InnerText { get; set; } = string.Empty;
        public string InnerText 
        { 
            get 
            { 
                return _InnerText; 
            }
        }

        private bool _IsRaw { get; set; } = false;
        public bool IsRaw 
        { 
            get { return _IsRaw; }
        }

        /// <summary>
        /// <para>Add plain text inside of the HTML tag.</para>
        /// <para>By default, the text will be Sanitised/made HTML safe.</para>
        /// <para>BE CAREFULL WHEN DOING THIS.</para>
        /// <para>Setting the IsRaw property to TRUE will skip the sanitasation and the text will be added complately raw to the HTML document.</para>
        /// </summary>
        public HTMLObject Set_InnerText(string P_Text, bool P_IsRaw = false)
        {
            _IsRaw = P_IsRaw;

            _InnerText = P_Text;

            return this;
        }


        /// <summary>
        /// <para>Return True or False.</para>
        /// <para>Return whether this object has any Inner Text or not.</para>
        /// </summary>
        public bool HasInnerText()
        {
            return string.IsNullOrEmpty(_InnerText) == false;
        }

        


    }

}
