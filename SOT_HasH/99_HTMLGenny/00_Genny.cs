

using System.Text;
using System.Web;

using SOT_HasH.Object;

namespace SOT_HasH.Generator
{
    public partial class ST_HTMLGenny
    {
        StringBuilder G_HtmlString = new StringBuilder();

        public void _Clear()
        {
            G_HtmlString.Clear();
        }

        public StringBuilder _BuildHtml(HTMLObject P_HTML_Object)
        {
            G_HtmlString.Clear();
            _BuildElement(P_HTML_Object);
            
            return G_HtmlString;
        }

        public StringBuilder _BuildHtml(List<HTMLObject> P_HTML_Objects)
        {
            G_HtmlString.Clear();
            for (int i = 0; i < P_HTML_Objects.Count; i++)
            {
                _BuildElement(P_HTML_Objects[i]);
            }
            return G_HtmlString;
        }



        private string _Sanitise(string P_Value)
        {
            return HttpUtility.HtmlEncode(P_Value);
        }
    }
}
