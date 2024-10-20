

using System.Text;
using System.Web;

using ST_HasH.Object;

namespace ST_HasH.Generator
{
    public partial class SF_HTMLGenerator
    {
        StringBuilder G_HtmlString = new StringBuilder();

        public void _Clear()
        {
            G_HtmlString.Clear();
        }

        public StringBuilder _BuildHtml(ST_HTMLObject P_HTML_Object)
        {
            G_HtmlString.Clear();
            _BuildElement(P_HTML_Object);
            
            return G_HtmlString;
        }

        public StringBuilder _BuildHtml(List<ST_HTMLObject> P_HTML_Objects)
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
